namespace Hospital_Managment_System
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            Admin = new RichTextBox();
            Password = new RichTextBox();
            label2 = new Label();
            LoginBtn = new Button();
            ClrBtn = new Button();
            CrossBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_20_1821092;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 119);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_20_182906;
            pictureBox2.Location = new Point(150, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(803, 119);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(122, 218);
            label1.Name = "label1";
            label1.Size = new Size(83, 27);
            label1.TabIndex = 6;
            label1.Text = "Admin";
            // 
            // Admin
            // 
            Admin.Location = new Point(283, 211);
            Admin.Name = "Admin";
            Admin.Size = new Size(377, 34);
            Admin.TabIndex = 7;
            Admin.Text = "";
            // 
            // Password
            // 
            Password.Location = new Point(283, 290);
            Password.Name = "Password";
            Password.Size = new Size(377, 34);
            Password.TabIndex = 9;
            Password.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CadetBlue;
            label2.Location = new Point(122, 297);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 8;
            label2.Text = "PASSWORD";
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Teal;
            LoginBtn.Location = new Point(283, 377);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(103, 37);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ClrBtn
            // 
            ClrBtn.Font = new Font("Swis721 BlkEx BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClrBtn.ForeColor = Color.Teal;
            ClrBtn.Location = new Point(557, 377);
            ClrBtn.Name = "ClrBtn";
            ClrBtn.Size = new Size(103, 37);
            ClrBtn.TabIndex = 11;
            ClrBtn.Text = "CLEAR";
            ClrBtn.UseVisualStyleBackColor = true;
            ClrBtn.Click += ClrBtn_Click;
            // 
            // CrossBtn
            // 
            CrossBtn.BackColor = Color.WhiteSmoke;
            CrossBtn.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrossBtn.ForeColor = Color.Crimson;
            CrossBtn.Location = new Point(904, 1);
            CrossBtn.Name = "CrossBtn";
            CrossBtn.Size = new Size(49, 39);
            CrossBtn.TabIndex = 12;
            CrossBtn.Text = "X";
            CrossBtn.UseVisualStyleBackColor = false;
            CrossBtn.Click += CrossBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(953, 544);
            Controls.Add(CrossBtn);
            Controls.Add(ClrBtn);
            Controls.Add(LoginBtn);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(Admin);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private RichTextBox Admin;
        private RichTextBox Password;
        private Label label2;
        private Button LoginBtn;
        private Button ClrBtn;
        private Button CrossBtn;
    }
}
