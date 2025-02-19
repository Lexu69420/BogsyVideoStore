using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BogsyVideoStore
{
    public partial class Customer_Panel : Form
    {
        private string mysqlCon = "server=127.0.0.1; user=root; database=bogsy_video_store; password=";

        public Customer_Panel()
        {
            InitializeComponent();
        }

        private void Customer_Panel_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CustomerID, CustomerName, Age, Gender, ContactNumber, Address FROM customer_tbl";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_Customer.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message);
                }
            }
        }

       private void button4_Click(object sender, EventArgs e)
        {
            int customerID;
            if (!int.TryParse(customerid_txtfield.Text.Trim(), out customerID))
            {
                MessageBox.Show("Please select a valid customer to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM customer_tbl WHERE CustomerID = @customerID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@customerID", customerID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadCustomerData();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearFields()
        {
            customerid_txtfield.Text = "";
            customername_txtfield.Text = "";
            age_txtfield.Text = "";
            gender_txtfield.Text = "";
            contactnumber_txtfield.Text = "";
            address_txtfield.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customerID = customerid_txtfield.Text.Trim();
            string customerName = customername_txtfield.Text.Trim();
            string ageText = age_txtfield.Text.Trim();
            string gender = gender_txtfield.Text.Trim();
            string contactNumber = contactnumber_txtfield.Text.Trim();
            string address = address_txtfield.Text.Trim();
            int age;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(ageText) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ageText, out age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO customer_tbl (CustomerID, CustomerName, Age, Gender, ContactNumber, Address) " +
                                   "VALUES (@customerID, @customerName, @age, @gender, @contactNumber, @address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@customerName", customerName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomerData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Customer.Rows[e.RowIndex];
                customerid_txtfield.Text = row.Cells["CustomerID"].Value.ToString();
                customername_txtfield.Text = row.Cells["CustomerName"].Value.ToString();
                age_txtfield.Text = row.Cells["Age"].Value.ToString();
                gender_txtfield.Text = row.Cells["Gender"].Value.ToString();
                contactnumber_txtfield.Text = row.Cells["ContactNumber"].Value.ToString();
                address_txtfield.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string customerID = customerid_txtfield.Text.Trim();
            string customerName = customername_txtfield.Text.Trim();
            string ageText = age_txtfield.Text.Trim();
            string gender = gender_txtfield.Text.Trim();
            string contactNumber = contactnumber_txtfield.Text.Trim();
            string address = address_txtfield.Text.Trim();
            int age;

            if (!int.TryParse(ageText, out age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE customer_tbl SET CustomerName = @customerName, Age = @age, Gender = @gender, ContactNumber = @contactNumber, Address = @address WHERE CustomerID = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@customerName", customerName);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@contactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@address", address);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomerData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
