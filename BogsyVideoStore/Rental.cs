using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BogsyVideoStore
{
    public partial class Rental_panel : Form
    {
        private string mysqlCon = "server=127.0.0.1; user=root; database=bogsy_video_store; password=";

        public Rental_panel()
        {
            InitializeComponent();
        }

        private void Rental_panel_Load_1(object sender, EventArgs e)
        {
            LoadRentalData();
        }
        private void LoadRentalData()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT RentalID, CustomerID, VideoID, RentalDate, ReturnDate, Status, TotalAmount FROM rental_tbl";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Rental_dgv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rental data: " + ex.Message);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();

                    string checkCustomerQuery = "SELECT COUNT(*) FROM customer_tbl WHERE CustomerID = @CustomerID";
                    using (MySqlCommand cmd = new MySqlCommand(checkCustomerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID_txtfield.Text);
                        int customerExists = Convert.ToInt32(cmd.ExecuteScalar());

                        if (customerExists == 0)
                        {
                            MessageBox.Show("Customer ID does not exist.");
                            return;
                        }
                    }

                    string videoCategory = "";
                    int stock = 0;
                    string checkVideoQuery = "SELECT Category, Stock FROM video_tbl WHERE VideoID = @VideoID";
                    using (MySqlCommand cmd = new MySqlCommand(checkVideoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@VideoID", videoID_txtfield.Text);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Video ID does not exist.");
                                return;
                            }
                            videoCategory = reader["Category"].ToString();
                            stock = Convert.ToInt32(reader["Stock"]);
                        }
                    }

                    if (stock <= 0)
                    {
                        MessageBox.Show("This video is out of stock.");
                        return;
                    }

                    DateTime rentalDate = rentalDate_datepick.Value;
                    DateTime returnDate = returnDate_datepick.Value;
                    int rentalDays = (int)(returnDate - rentalDate).TotalDays;

                    if (rentalDays > 3)
                    {
                        MessageBox.Show("Return date cannot be more than 3 days after the rental date.");
                        return;
                    }
                    if (rentalDays < 1)
                    {
                        MessageBox.Show("Rental duration must be at least 1 day.");
                        return;
                    }

                    int pricePerDay = (videoCategory == "DVD") ? 50 : (videoCategory == "VCD") ? 25 : 0;
                    if (pricePerDay == 0)
                    {
                        MessageBox.Show("Invalid video category. Price could not be determined.");
                        return;
                    }

                    int totalAmount = rentalDays * pricePerDay;

                    string insertQuery = "INSERT INTO rental_tbl (CustomerID, VideoID, RentalDate, ReturnDate, Status, TotalAmount) " +
                                         "VALUES (@CustomerID, @VideoID, @RentalDate, @ReturnDate, 'Rented', @TotalAmount)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID_txtfield.Text);
                        cmd.Parameters.AddWithValue("@VideoID", videoID_txtfield.Text);
                        cmd.Parameters.AddWithValue("@RentalDate", rentalDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.ExecuteNonQuery();
                    }

                    string updateStockQuery = "UPDATE video_tbl SET Stock = Stock - 1 WHERE VideoID = @VideoID";
                    using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@VideoID", videoID_txtfield.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Rental added successfully!");
                    LoadRentalData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding rental: " + ex.Message);
                }
            }
        }




        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            rentalID_txtfield.Clear();
            customerID_txtfield.Clear();
            videoID_txtfield.Clear();
            rentalDate_datepick.Value = DateTime.Now;
            returnDate_datepick.Value = DateTime.Now;
            status_txtfield.Clear();
            totalamount_txtfield.Clear();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (Rental_dgv.CurrentRow != null && Rental_dgv.CurrentRow.Cells["RentalID"].Value != null)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        conn.Open();

                        string updateQuery = "UPDATE rental_tbl SET CustomerID = @CustomerID, VideoID = @VideoID, RentalDate = @RentalDate, " +
                                             "ReturnDate = @ReturnDate, Status = @Status, TotalAmount = @TotalAmount WHERE RentalID = @RentalID";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID_txtfield.Text);
                            cmd.Parameters.AddWithValue("@VideoID", videoID_txtfield.Text);
                            cmd.Parameters.AddWithValue("@RentalDate", rentalDate_datepick.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@ReturnDate", returnDate_datepick.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Status", status_txtfield.Text);
                            cmd.Parameters.AddWithValue("@TotalAmount", totalamount_txtfield.Text);
                            cmd.Parameters.AddWithValue("@RentalID", Convert.ToInt32(Rental_dgv.CurrentRow.Cells["RentalID"].Value));

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Rental record updated successfully!");
                        LoadRentalData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating rental: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a rental record to edit.");
            }
        }



        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (Rental_dgv.CurrentRow == null || Rental_dgv.CurrentRow.Cells["RentalID"].Value == null)
            {
                MessageBox.Show("Please select a valid rental record to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rentalID = Convert.ToInt32(Rental_dgv.CurrentRow.Cells["RentalID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this rental record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM rental_tbl WHERE RentalID = @rentalID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@rentalID", rentalID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Rental record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadRentalData();
                            }
                            else
                            {
                                MessageBox.Show("Rental record not found or already deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting rental record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void Rental_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Rental_dgv.Rows[e.RowIndex];

                rentalID_txtfield.Text = row.Cells["RentalID"].Value.ToString();
                customerID_txtfield.Text = row.Cells["CustomerID"].Value.ToString();
                videoID_txtfield.Text = row.Cells["VideoID"].Value.ToString();
                rentalDate_datepick.Value = Convert.ToDateTime(row.Cells["RentalDate"].Value);
                returnDate_datepick.Value = Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                status_txtfield.Text = row.Cells["Status"].Value.ToString();
                totalamount_txtfield.Text = row.Cells["TotalAmount"].Value.ToString();
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (Rental_dgv.CurrentRow == null || Rental_dgv.CurrentRow.Cells["RentalID"].Value == null)
            {
                MessageBox.Show("Please select a rental record to return.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rentalID = Convert.ToInt32(Rental_dgv.CurrentRow.Cells["RentalID"].Value);
            string videoID = Rental_dgv.CurrentRow.Cells["VideoID"].Value.ToString();

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();


                    string updateRentalQuery = "UPDATE rental_tbl SET Status = 'Returned' WHERE RentalID = @rentalID";
                    using (MySqlCommand cmd = new MySqlCommand(updateRentalQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@rentalID", rentalID);
                        cmd.ExecuteNonQuery();
                    }

                    string updateStockQuery = "UPDATE video_tbl SET Stock = Stock + 1 WHERE VideoID = @VideoID";
                    using (MySqlCommand cmd = new MySqlCommand(updateStockQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@VideoID", videoID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Video returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRentalData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating rental status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
