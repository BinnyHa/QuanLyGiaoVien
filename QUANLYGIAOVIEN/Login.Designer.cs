namespace QUANLYGIAOVIEN
{
    partial class flogin
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
            this.exit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.mkhau = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.đăngnhập = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(577, 163);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(484, 163);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Đăng nhập";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // mkhau
            // 
            this.mkhau.Location = new System.Drawing.Point(484, 89);
            this.mkhau.Name = "mkhau";
            this.mkhau.Size = new System.Drawing.Size(168, 20);
            this.mkhau.TabIndex = 3;
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.matkhau.Location = new System.Drawing.Point(362, 93);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(66, 16);
            this.matkhau.TabIndex = 2;
            this.matkhau.Text = "Mật khẩu";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(484, 38);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(168, 20);
            this.username.TabIndex = 1;
            // 
            // đăngnhập
            // 
            this.đăngnhập.AutoSize = true;
            this.đăngnhập.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đăngnhập.Location = new System.Drawing.Point(348, 39);
            this.đăngnhập.Name = "đăngnhập";
            this.đăngnhập.Size = new System.Drawing.Size(104, 16);
            this.đăngnhập.TabIndex = 0;
            this.đăngnhập.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QUANLYGIAOVIEN.Properties.Resources.ảnh_động;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // flogin
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 230);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.đăngnhập);
            this.Controls.Add(this.mkhau);
            this.Controls.Add(this.username);
            this.Controls.Add(this.matkhau);
            this.Name = "flogin";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox mkhau;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label đăngnhập;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

