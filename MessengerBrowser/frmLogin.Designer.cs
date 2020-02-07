namespace MessengerBrowser
{
    partial class frmLogin
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
            this.txtAcc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtAcc
            // 
            // 
            // 
            // 
            this.txtAcc.CustomButton.Image = null;
            this.txtAcc.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtAcc.CustomButton.Name = "";
            this.txtAcc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAcc.CustomButton.TabIndex = 1;
            this.txtAcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAcc.CustomButton.UseSelectable = true;
            this.txtAcc.CustomButton.Visible = false;
            this.txtAcc.Lines = new string[0];
            this.txtAcc.Location = new System.Drawing.Point(195, 190);
            this.txtAcc.MaxLength = 32767;
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.PasswordChar = '\0';
            this.txtAcc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAcc.SelectedText = "";
            this.txtAcc.SelectionLength = 0;
            this.txtAcc.SelectionStart = 0;
            this.txtAcc.ShortcutsEnabled = true;
            this.txtAcc.Size = new System.Drawing.Size(215, 23);
            this.txtAcc.TabIndex = 0;
            this.txtAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAcc.UseSelectable = true;
            this.txtAcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Email/Number Phone";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(122, 231);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(195, 229);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(215, 23);
            this.txtPass.TabIndex = 2;
            this.txtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPass.UseSelectable = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(68, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(330, 76);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Hệ thống yêu cầu tài khoản và mật khẩu của Facebook.\r\nVui lòng cung cấp cho phần " +
    "mềm để đăng nhập. \r\nTôi sẽ không bao giờ thu thập thông tin cá nhân,\r\ndữ liệu củ" +
    "a bạn được mã hóa!";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 364);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtAcc);
            this.Name = "frmLogin";
            this.Text = "Đăng nhập";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAcc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}