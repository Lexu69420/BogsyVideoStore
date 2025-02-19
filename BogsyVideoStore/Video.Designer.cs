namespace BogsyVideoStore
{
    partial class Video_panel
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
            dgv_Video = new DataGridView();
            label1 = new Label();
            videoID_txtfield = new TextBox();
            title_txtfield = new TextBox();
            label2 = new Label();
            label3 = new Label();
            price_txtfield = new TextBox();
            label4 = new Label();
            stocks_txtfield = new TextBox();
            label5 = new Label();
            category_cmbox = new ComboBox();
            label6 = new Label();
            add_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            clear_btn = new Button();
            genre_txtfield = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Video).BeginInit();
            SuspendLayout();
            // 
            // dgv_Video
            // 
            dgv_Video.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Video.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Video.Dock = DockStyle.Right;
            dgv_Video.Location = new Point(403, 0);
            dgv_Video.Name = "dgv_Video";
            dgv_Video.Size = new Size(723, 664);
            dgv_Video.TabIndex = 0;
            dgv_Video.CellContentClick += dgv_Video_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(29, 71);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 1;
            label1.Text = "Video ID";
            // 
            // videoID_txtfield
            // 
            videoID_txtfield.Location = new Point(29, 106);
            videoID_txtfield.Name = "videoID_txtfield";
            videoID_txtfield.ReadOnly = true;
            videoID_txtfield.Size = new Size(273, 23);
            videoID_txtfield.TabIndex = 2;
            // 
            // title_txtfield
            // 
            title_txtfield.Location = new Point(29, 174);
            title_txtfield.Name = "title_txtfield";
            title_txtfield.Size = new Size(273, 23);
            title_txtfield.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(29, 150);
            label2.Name = "label2";
            label2.Size = new Size(39, 21);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 294);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // price_txtfield
            // 
            price_txtfield.Location = new Point(29, 385);
            price_txtfield.Name = "price_txtfield";
            price_txtfield.ReadOnly = true;
            price_txtfield.Size = new Size(273, 23);
            price_txtfield.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(29, 361);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // stocks_txtfield
            // 
            stocks_txtfield.Location = new Point(29, 451);
            stocks_txtfield.Name = "stocks_txtfield";
            stocks_txtfield.Size = new Size(273, 23);
            stocks_txtfield.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(29, 427);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 9;
            label5.Text = "Stocks";
            // 
            // category_cmbox
            // 
            category_cmbox.FormattingEnabled = true;
            category_cmbox.Items.AddRange(new object[] { "VCD", "DVD" });
            category_cmbox.Location = new Point(29, 322);
            category_cmbox.Name = "category_cmbox";
            category_cmbox.Size = new Size(121, 23);
            category_cmbox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 9);
            label6.Name = "label6";
            label6.Size = new Size(202, 40);
            label6.TabIndex = 12;
            label6.Text = "Video Library";
            label6.Click += label6_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(29, 559);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 13;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(128, 559);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(75, 23);
            edit_btn.TabIndex = 14;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(236, 559);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 23);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(29, 516);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 16;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // genre_txtfield
            // 
            genre_txtfield.Location = new Point(29, 244);
            genre_txtfield.Name = "genre_txtfield";
            genre_txtfield.Size = new Size(273, 23);
            genre_txtfield.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(29, 220);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 17;
            label7.Text = "Genre";
            // 
            // Video_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1126, 664);
            Controls.Add(genre_txtfield);
            Controls.Add(label7);
            Controls.Add(clear_btn);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(add_btn);
            Controls.Add(label6);
            Controls.Add(category_cmbox);
            Controls.Add(stocks_txtfield);
            Controls.Add(label5);
            Controls.Add(price_txtfield);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(title_txtfield);
            Controls.Add(label2);
            Controls.Add(videoID_txtfield);
            Controls.Add(label1);
            Controls.Add(dgv_Video);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Video_panel";
            Text = "Video";
            Load += Video_panel_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Video).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox videoID_txtfield;
        private TextBox title_txtfield;
        private Label label2;
        private Label label3;
        private TextBox price_txtfield;
        private Label label4;
        private TextBox stocks_txtfield;
        private Label label5;
        private ComboBox category_cmbox;
        private Label label6;
        private Button add_btn;
        private Button edit_btn;
        private Button delete_btn;
        private Button clear_btn;
        private TextBox genre_txtfield;
        private Label label7;
        private DataGridView dgv_Video;
    }
}