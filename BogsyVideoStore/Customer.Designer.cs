
namespace BogsyVideoStore
{
    partial class Customer_Panel
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
            dgv_Customer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            customerid_txtfield = new TextBox();
            age_txtfield = new TextBox();
            label4 = new Label();
            gender_txtfield = new TextBox();
            label5 = new Label();
            contactnumber_txtfield = new TextBox();
            label6 = new Label();
            address_txtfield = new TextBox();
            label7 = new Label();
            clear_btn = new Button();
            add_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            customername_txtfield = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Customer).BeginInit();
            SuspendLayout();
            // 
            // dgv_Customer
            // 
            dgv_Customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Customer.Dock = DockStyle.Right;
            dgv_Customer.Location = new Point(403, 0);
            dgv_Customer.Name = "dgv_Customer";
            dgv_Customer.Size = new Size(723, 664);
            dgv_Customer.TabIndex = 0;
            dgv_Customer.CellContentClick += dgv_Customer_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 40);
            label1.TabIndex = 1;
            label1.Text = "Customer Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer ID";
            // 
            // customerid_txtfield
            // 
            customerid_txtfield.Font = new Font("Segoe UI", 12F);
            customerid_txtfield.Location = new Point(29, 106);
            customerid_txtfield.Name = "customerid_txtfield";
            customerid_txtfield.ReadOnly = true;
            customerid_txtfield.Size = new Size(273, 29);
            customerid_txtfield.TabIndex = 3;
            // 
            // age_txtfield
            // 
            age_txtfield.Font = new Font("Segoe UI", 12F);
            age_txtfield.Location = new Point(29, 284);
            age_txtfield.Name = "age_txtfield";
            age_txtfield.Size = new Size(273, 29);
            age_txtfield.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(29, 249);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // gender_txtfield
            // 
            gender_txtfield.Font = new Font("Segoe UI", 12F);
            gender_txtfield.Location = new Point(29, 365);
            gender_txtfield.Name = "gender_txtfield";
            gender_txtfield.Size = new Size(273, 29);
            gender_txtfield.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(29, 330);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // contactnumber_txtfield
            // 
            contactnumber_txtfield.Font = new Font("Segoe UI", 12F);
            contactnumber_txtfield.Location = new Point(29, 453);
            contactnumber_txtfield.Name = "contactnumber_txtfield";
            contactnumber_txtfield.Size = new Size(273, 29);
            contactnumber_txtfield.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(29, 418);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 10;
            label6.Text = "Contact Number";
            // 
            // address_txtfield
            // 
            address_txtfield.Font = new Font("Segoe UI", 12F);
            address_txtfield.Location = new Point(29, 536);
            address_txtfield.Name = "address_txtfield";
            address_txtfield.Size = new Size(273, 29);
            address_txtfield.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(29, 501);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 12;
            label7.Text = "Address";
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(29, 579);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 14;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(29, 619);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 15;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += button2_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(128, 619);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(75, 23);
            edit_btn.TabIndex = 16;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(227, 619);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 17;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += button4_Click;
            // 
            // customername_txtfield
            // 
            customername_txtfield.Font = new Font("Segoe UI", 12F);
            customername_txtfield.Location = new Point(29, 191);
            customername_txtfield.Name = "customername_txtfield";
            customername_txtfield.Size = new Size(273, 29);
            customername_txtfield.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(29, 156);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 20;
            label8.Text = "Customer Name";
            // 
            // Customer_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1126, 664);
            Controls.Add(customername_txtfield);
            Controls.Add(label8);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(clear_btn);
            Controls.Add(address_txtfield);
            Controls.Add(label7);
            Controls.Add(contactnumber_txtfield);
            Controls.Add(label6);
            Controls.Add(gender_txtfield);
            Controls.Add(label5);
            Controls.Add(age_txtfield);
            Controls.Add(label4);
            Controls.Add(customerid_txtfield);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Customer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Panel";
            Text = "Customer";
            Load += Customer_Panel_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Customer;
        private Label label1;
        private Label label2;
        private TextBox customerid_txtfield;
        private TextBox age_txtfield;
        private Label label4;
        private TextBox gender_txtfield;
        private Label label5;
        private TextBox contactnumber_txtfield;
        private Label label6;
        private TextBox address_txtfield;
        private Label label7;
        private Button clear_btn;
        private Button add_btn;
        private Button edit_btn;
        private Button delete_btn;
        private TextBox customername_txtfield;
        private Label label8;
    }
}