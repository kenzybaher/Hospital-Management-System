namespace Hospital_Managment_System
{
    partial class Doctor
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            HomeBtn = new Button();
            ResetBtn = new Button();
            DelBtn = new Button();
            UpdateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Swis721 BlkEx BT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(403, 31);
            label1.Name = "label1";
            label1.Size = new Size(179, 41);
            label1.TabIndex = 34;
            label1.Text = "Doctor";
            label1.Click += label1_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.WhiteSmoke;
            CrossBtn.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = Color.Crimson;
            CrossBtn.Location = new Point(971, 1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(49, 39);
            CrossBtn.TabIndex = 33;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_20_182906;
            pictureBox2.Location = new Point(148, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(872, 119);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_20_1821092;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 119);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 36;
            label3.Text = "Doctor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(165, 165);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 37;
            label2.Text = "Doctor Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(365, 165);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 38;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(510, 165);
            label5.Name = "label5";
            label5.Size = new Size(257, 20);
            label5.TabIndex = 39;
            label5.Text = "Years Of Experience";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(785, 165);
            label6.Name = "label6";
            label6.Size = new Size(221, 20);
            label6.TabIndex = 40;
            label6.Text = "Medical Licensce";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 41;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(510, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 43;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(771, 200);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(235, 27);
            textBox4.TabIndex = 44;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 46;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(350, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 47;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(996, 204);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Teal;
            AddBtn.Location = new Point(32, 458);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(103, 37);
            AddBtn.TabIndex = 49;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // HomeBtn
            // 
            HomeBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.Teal;
            HomeBtn.Location = new Point(600, 458);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(103, 37);
            HomeBtn.TabIndex = 51;
            HomeBtn.Text = "HOME";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.Teal;
            ResetBtn.Location = new Point(456, 458);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(103, 37);
            ResetBtn.TabIndex = 52;
            ResetBtn.Text = "RESET";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelBtn.ForeColor = Color.Teal;
            DelBtn.Location = new Point(313, 458);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(112, 37);
            DelBtn.TabIndex = 53;
            DelBtn.Text = "DELETE";
            DelBtn.UseVisualStyleBackColor = true;
            DelBtn.Click += DelBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Teal;
            UpdateBtn.Location = new Point(165, 458);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 37);
            UpdateBtn.TabIndex = 54;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1018, 507);
            Controls.Add(UpdateBtn);
            Controls.Add(DelBtn);
            Controls.Add(ResetBtn);
            Controls.Add(HomeBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CrossBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctor";
            Text = "Doctor";
            Load += Doctor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button HomeBtn;
        private Button ResetBtn;
        private Button DelBtn;
        private Button UpdateBtn;
    }
}