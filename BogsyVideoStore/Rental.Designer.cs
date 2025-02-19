namespace BogsyVideoStore
{
    partial class Rental_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rentalID_txtfield = new TextBox();
            customerID_txtfield = new TextBox();
            label2 = new Label();
            videoID_txtfield = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            status_txtfield = new TextBox();
            label7 = new Label();
            totalamount_txtfield = new TextBox();
            label8 = new Label();
            add_btn = new Button();
            clear_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            rentalDate_datepick = new DateTimePicker();
            returnDate_datepick = new DateTimePicker();
            Rental_dgv = new DataGridView();
            return_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Rental_dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(29, 71);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Rental ID";
            label1.Click += label1_Click_1;
            // 
            // rentalID_txtfield
            // 
            rentalID_txtfield.Location = new Point(29, 106);
            rentalID_txtfield.Name = "rentalID_txtfield";
            rentalID_txtfield.ReadOnly = true;
            rentalID_txtfield.Size = new Size(272, 23);
            rentalID_txtfield.TabIndex = 2;
            // 
            // customerID_txtfield
            // 
            customerID_txtfield.Location = new Point(29, 167);
            customerID_txtfield.Name = "customerID_txtfield";
            customerID_txtfield.Size = new Size(272, 23);
            customerID_txtfield.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(29, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer ID";
            // 
            // videoID_txtfield
            // 
            videoID_txtfield.Location = new Point(29, 233);
            videoID_txtfield.Name = "videoID_txtfield";
            videoID_txtfield.Size = new Size(272, 23);
            videoID_txtfield.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(29, 210);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Video ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(29, 282);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Rental Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 9);
            label5.Name = "label5";
            label5.Size = new Size(239, 45);
            label5.TabIndex = 9;
            label5.Text = "Rental Module";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(29, 351);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 10;
            label6.Text = "Return Date";
            // 
            // status_txtfield
            // 
            status_txtfield.Location = new Point(29, 439);
            status_txtfield.Name = "status_txtfield";
            status_txtfield.ReadOnly = true;
            status_txtfield.Size = new Size(272, 23);
            status_txtfield.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(29, 416);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 12;
            label7.Text = "Status";
            // 
            // totalamount_txtfield
            // 
            totalamount_txtfield.Location = new Point(29, 512);
            totalamount_txtfield.Name = "totalamount_txtfield";
            totalamount_txtfield.ReadOnly = true;
            totalamount_txtfield.Size = new Size(272, 23);
            totalamount_txtfield.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(29, 489);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 14;
            label8.Text = "Total Amount";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(29, 603);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 17;
            add_btn.Text = "Rent";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(29, 563);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 18;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(126, 603);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(75, 23);
            edit_btn.TabIndex = 19;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(226, 603);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 20;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // rentalDate_datepick
            // 
            rentalDate_datepick.Location = new Point(29, 305);
            rentalDate_datepick.Name = "rentalDate_datepick";
            rentalDate_datepick.Size = new Size(272, 23);
            rentalDate_datepick.TabIndex = 21;
            // 
            // returnDate_datepick
            // 
            returnDate_datepick.Location = new Point(29, 374);
            returnDate_datepick.Name = "returnDate_datepick";
            returnDate_datepick.Size = new Size(272, 23);
            returnDate_datepick.TabIndex = 22;
            // 
            // Rental_dgv
            // 
            Rental_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Rental_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rental_dgv.Dock = DockStyle.Right;
            Rental_dgv.Location = new Point(403, 0);
            Rental_dgv.Name = "Rental_dgv";
            Rental_dgv.Size = new Size(723, 664);
            Rental_dgv.TabIndex = 23;
            Rental_dgv.CellContentClick += Rental_dgv_CellClick;
            // 
            // return_btn
            // 
            return_btn.Location = new Point(126, 563);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(75, 23);
            return_btn.TabIndex = 24;
            return_btn.Text = "Return";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Rental_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1126, 664);
            Controls.Add(return_btn);
            Controls.Add(Rental_dgv);
            Controls.Add(returnDate_datepick);
            Controls.Add(rentalDate_datepick);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(clear_btn);
            Controls.Add(add_btn);
            Controls.Add(totalamount_txtfield);
            Controls.Add(label8);
            Controls.Add(status_txtfield);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(videoID_txtfield);
            Controls.Add(label3);
            Controls.Add(customerID_txtfield);
            Controls.Add(label2);
            Controls.Add(rentalID_txtfield);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rental_panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rental";
            Load += Rental_panel_Load_1;
            ((System.ComponentModel.ISupportInitialize)Rental_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox rentalID_txtfield;
        private TextBox customerID_txtfield;
        private Label label2;
        private TextBox videoID_txtfield;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox status_txtfield;
        private Label label7;
        private TextBox totalamount_txtfield;
        private Label label8;
        private Button add_btn;
        private Button clear_btn;
        private Button edit_btn;
        private Button delete_btn;
        private DateTimePicker rentalDate_datepick;
        private DateTimePicker returnDate_datepick;
        private DataGridView Rental_dgv;
        private Button return_btn;
    }
}