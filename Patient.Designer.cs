namespace Hospital_Managment_System
{
    partial class Patient
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
            CrossBtn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            textBox55 = new TextBox();
            textBox22 = new TextBox();
            textBox33 = new TextBox();
            textBox44 = new TextBox();
            textBox11 = new TextBox();
            textBox66 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            DelBtn = new Button();
            ResetBtn = new Button();
            HomeBtn = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Swis721 BlkEx BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(402, 32);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 38;
            label1.Text = "Patient";
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.WhiteSmoke;
            CrossBtn.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = Color.Crimson;
            CrossBtn.Location = new Point(970, 2);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(43, 39);
            CrossBtn.TabIndex = 37;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_20_182906;
            pictureBox2.Location = new Point(147, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(872, 119);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_20_1821092;
            pictureBox1.Location = new Point(-2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 119);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(23, 127);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 39;
            label3.Text = "Patient ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(23, 181);
            label2.Name = "label2";
            label2.Size = new Size(169, 20);
            label2.TabIndex = 40;
            label2.Text = "Patient Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(23, 304);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 44;
            label7.Text = "Patient Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(23, 244);
            label8.Name = "label8";
            label8.Size = new Size(200, 20);
            label8.TabIndex = 45;
            label8.Text = "Patient Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(447, 244);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 49;
            label4.Text = "Blood Group";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(447, 304);
            label5.Name = "label5";
            label5.Size = new Size(184, 20);
            label5.TabIndex = 48;
            label5.Text = "Major Disease";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(447, 191);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 47;
            label6.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(447, 131);
            label9.Name = "label9";
            label9.Size = new Size(173, 20);
            label9.TabIndex = 46;
            label9.Text = "Patient Phone";
            // 
            // textBox55
            // 
            textBox55.Location = new Point(645, 131);
            textBox55.Name = "textBox55";
            textBox55.Size = new Size(151, 27);
            textBox55.TabIndex = 50;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(243, 179);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(151, 27);
            textBox22.TabIndex = 51;
            textBox22.TextChanged += textBox2_TextChanged;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(243, 237);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(151, 27);
            textBox33.TabIndex = 52;
            // 
            // textBox44
            // 
            textBox44.Location = new Point(243, 297);
            textBox44.Name = "textBox44";
            textBox44.Size = new Size(151, 27);
            textBox44.TabIndex = 53;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(243, 124);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(151, 27);
            textBox11.TabIndex = 54;
            textBox11.TextChanged += textBox5_TextChanged;
            // 
            // textBox66
            // 
            textBox66.Location = new Point(645, 301);
            textBox66.Name = "textBox66";
            textBox66.Size = new Size(151, 27);
            textBox66.TabIndex = 55;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(645, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 56;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A+", "B+", "O+", "A-", "B-", "O-", "AB+", "AB-" });
            comboBox2.Location = new Point(645, 241);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 57;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Teal;
            AddBtn.Location = new Point(881, 124);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 37);
            AddBtn.TabIndex = 58;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Teal;
            UpdateBtn.Location = new Point(881, 164);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 37);
            UpdateBtn.TabIndex = 59;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click_1;
            // 
            // DelBtn
            // 
            DelBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = Color.Teal;
            DelBtn.Location = new Point(881, 207);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(112, 37);
            DelBtn.TabIndex = 60;
            DelBtn.Text = "DELETE";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.Teal;
            ResetBtn.Location = new Point(881, 250);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(103, 37);
            ResetBtn.TabIndex = 61;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.Teal;
            HomeBtn.Location = new Point(881, 296);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(103, 37);
            HomeBtn.TabIndex = 62;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Azure;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 334);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(996, 184);
            dataGridView2.TabIndex = 63;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1019, 531);
            Controls.Add(dataGridView2);
            Controls.Add(HomeBtn);
            Controls.Add(ResetBtn);
            Controls.Add(DelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox66);
            Controls.Add(textBox11);
            Controls.Add(textBox44);
            Controls.Add(textBox33);
            Controls.Add(textBox22);
            Controls.Add(textBox55);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CrossBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.PowderBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient";
            Load += Patient_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CrossBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox textBox55;
        private TextBox textBox22;
        private TextBox textBox33;
        private TextBox textBox44;
        private TextBox textBox11;
        private TextBox textBox66;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DelBtn;
        private Button ResetBtn;
        private Button HomeBtn;
        private DataGridView dataGridView2;
    }
}