using MySql.Data.MySqlClient;

namespace BogsyVideoStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=bogsy_video_store; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        } 
        
        private void Form1_Load(object sender, EventArgs e)
        {
            RentalToPanel(new Rental_panel());
        }
        private void rental_btn_Click(object sender, EventArgs e)
        {
            RentalToPanel(new Rental_panel());
        }
        private void RentalToPanel(Form frm)
        {
            Main_panel.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Main_panel.Controls.Add(frm);
            frm.Show();
        }
        private void video_btn_Click(object sender, EventArgs e)
        {
            VideoToPanel(new Video_panel());
        }
        private void VideoToPanel(Form frm)
        {
            Main_panel.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Main_panel.Controls.Add(frm);
            frm.Show();
        }
        private void customer_btn_Click(object sender, EventArgs e)
        {
            CustomerToPanel(new Customer_Panel());
        }
        private void CustomerToPanel(Form frm)
        {
            Main_panel.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            Main_panel.Controls.Add(frm);
            frm.Show();
        }
        private void Payment_btn_Click(object sender, EventArgs e)
        {

        }
        private void report_btn_Click(object sender, EventArgs e)
        {

        }
        private void archive_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
