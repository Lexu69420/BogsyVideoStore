using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BogsyVideoStore
{
    public partial class Video_panel : Form
    {
        private string mysqlCon = "server=127.0.0.1; user=root; database=bogsy_video_store; password=";

        public Video_panel()
        {
            InitializeComponent();
        }

        private void Video_panel_Load(object sender, EventArgs e)
        {
            LoadVideoData();
        }

        private void LoadVideoData()
        {
            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT VideoID, Title, Genre, Category, Price, Stocks FROM video_tbl";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv_Video.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading videos: " + ex.Message);
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgv_Video_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Video.Rows[e.RowIndex];

                videoID_txtfield.Text = row.Cells["VideoID"].Value.ToString();
                title_txtfield.Text = row.Cells["Title"].Value.ToString();
                genre_txtfield.Text = row.Cells["Genre"].Value.ToString();
                category_cmbox.SelectedItem = row.Cells["Category"].Value.ToString();
                price_txtfield.Text = row.Cells["Price"].Value.ToString();
                stocks_txtfield.Text = row.Cells["Stocks"].Value.ToString();
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            string title = title_txtfield.Text.Trim();
            string genre = genre_txtfield.Text.Trim();
            string category = category_cmbox.SelectedItem?.ToString();
            string price = (category == "DVD") ? "50" : "25";
            int stocks;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stocks_txtfield.Text.Trim(), out stocks) || stocks < 0)
            {
                MessageBox.Show("Please enter a valid stock number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO video_tbl (Title, Genre, Category, Price, Stocks) VALUES (@title, @genre, @category, @price, @stocks)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@stocks", stocks);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Video added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadVideoData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding video: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFields()
        {
            videoID_txtfield.Text = "";
            title_txtfield.Text = "";
            genre_txtfield.Text = "";
            category_cmbox.SelectedIndex = -1;
            price_txtfield.Text = "";
            stocks_txtfield.Text = "";
        }


        private void edit_btn_Click(object sender, EventArgs e)
        {
            int videoID;
            if (!int.TryParse(videoID_txtfield.Text.Trim(), out videoID))
            {
                MessageBox.Show("Please select a valid video to edit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = title_txtfield.Text.Trim();
            string genre = genre_txtfield.Text.Trim();
            string category = category_cmbox.SelectedItem?.ToString();
            string price = (category == "DVD") ? "50" : "25";
            int stocks;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(stocks_txtfield.Text.Trim(), out stocks) || stocks < 0)
            {
                MessageBox.Show("Please enter a valid stock number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE video_tbl SET Title = @title, Genre = @genre, Category = @category, Price = @price, Stocks = @stocks WHERE VideoID = @videoID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@stocks", stocks);
                        cmd.Parameters.AddWithValue("@videoID", videoID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Video updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadVideoData();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating video: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            int videoID;
            if (!int.TryParse(videoID_txtfield.Text.Trim(), out videoID))
            {
                MessageBox.Show("Please select a valid video to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this video?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM video_tbl WHERE VideoID = @videoID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@videoID", videoID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Video deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadVideoData();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting video: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
