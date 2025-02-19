
namespace BogsyVideoStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customer_btn = new Button();
            video_btn = new Button();
            rental_btn = new Button();
            report_btn = new Button();
            archive_btn = new Button();
            panel1 = new Panel();
            Payment_btn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            Main_panel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customer_btn
            // 
            customer_btn.BackColor = Color.FromArgb(224, 224, 224);
            customer_btn.Location = new Point(32, 292);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(164, 64);
            customer_btn.TabIndex = 1;
            customer_btn.Text = "Customer Library";
            customer_btn.UseVisualStyleBackColor = false;
            customer_btn.Click += customer_btn_Click;
            // 
            // video_btn
            // 
            video_btn.BackColor = Color.FromArgb(224, 224, 224);
            video_btn.Location = new Point(32, 193);
            video_btn.Name = "video_btn";
            video_btn.Size = new Size(164, 64);
            video_btn.TabIndex = 2;
            video_btn.Text = "Video Library";
            video_btn.UseVisualStyleBackColor = false;
            video_btn.Click += video_btn_Click;
            // 
            // rental_btn
            // 
            rental_btn.BackColor = Color.FromArgb(224, 224, 224);
            rental_btn.Location = new Point(32, 99);
            rental_btn.Name = "rental_btn";
            rental_btn.Size = new Size(164, 64);
            rental_btn.TabIndex = 3;
            rental_btn.Text = "Rental Module";
            rental_btn.UseVisualStyleBackColor = false;
            rental_btn.Click += rental_btn_Click;
            // 
            // report_btn
            // 
            report_btn.BackColor = Color.FromArgb(224, 224, 224);
            report_btn.Location = new Point(32, 591);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(164, 64);
            report_btn.TabIndex = 4;
            report_btn.Text = "Reports";
            report_btn.UseVisualStyleBackColor = false;
            report_btn.Click += report_btn_Click;
            // 
            // archive_btn
            // 
            archive_btn.BackColor = Color.FromArgb(224, 224, 224);
            archive_btn.Location = new Point(32, 490);
            archive_btn.Name = "archive_btn";
            archive_btn.Size = new Size(164, 64);
            archive_btn.TabIndex = 5;
            archive_btn.Text = "Archives";
            archive_btn.UseVisualStyleBackColor = false;
            archive_btn.Click += archive_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Payment_btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(rental_btn);
            panel1.Controls.Add(report_btn);
            panel1.Controls.Add(customer_btn);
            panel1.Controls.Add(archive_btn);
            panel1.Controls.Add(video_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 729);
            panel1.TabIndex = 6;
            // 
            // Payment_btn
            // 
            Payment_btn.BackColor = Color.FromArgb(224, 224, 224);
            Payment_btn.Location = new Point(32, 391);
            Payment_btn.Name = "Payment_btn";
            Payment_btn.Size = new Size(164, 64);
            Payment_btn.TabIndex = 7;
            Payment_btn.Text = "Payment History";
            Payment_btn.UseVisualStyleBackColor = false;
            Payment_btn.Click += Payment_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 65);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(224, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1126, 65);
            panel3.TabIndex = 7;
            // 
            // Main_panel
            // 
            Main_panel.BackColor = Color.FromArgb(224, 224, 224);
            Main_panel.Dock = DockStyle.Fill;
            Main_panel.Location = new Point(224, 65);
            Main_panel.Name = "Main_panel";
            Main_panel.Size = new Size(1126, 664);
            Main_panel.TabIndex = 8;
            Main_panel.Paint += panel4_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(Main_panel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Bogsy Video Store";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private Button customer_btn;
        private Button video_btn;
        private Button rental_btn;
        private Button report_btn;
        private Button archive_btn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel Main_panel;
        private Button Payment_btn;
    }
}
