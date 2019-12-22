namespace MessengerBrowser
{
    partial class frmUpdateDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateDownload));
            this.progressWork = new System.Windows.Forms.ProgressBar();
            this.btnOKSystem = new MetroFramework.Controls.MetroButton();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressWork
            // 
            this.progressWork.Location = new System.Drawing.Point(127, 137);
            this.progressWork.Name = "progressWork";
            this.progressWork.Size = new System.Drawing.Size(311, 23);
            this.progressWork.TabIndex = 0;
            // 
            // btnOKSystem
            // 
            this.btnOKSystem.Location = new System.Drawing.Point(228, 197);
            this.btnOKSystem.Name = "btnOKSystem";
            this.btnOKSystem.Size = new System.Drawing.Size(101, 42);
            this.btnOKSystem.TabIndex = 6;
            this.btnOKSystem.Text = "Xác nhận";
            this.btnOKSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKSystem.UseSelectable = true;
            this.btnOKSystem.Click += new System.EventHandler(this.btnOKSystem_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstatus.Location = new System.Drawing.Point(124, 77);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(54, 13);
            this.lblstatus.TabIndex = 7;
            this.lblstatus.Text = "Loading...";
            // 
            // frmUpdateDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnOKSystem);
            this.Controls.Add(this.progressWork);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateDownload";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUpdateDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressWork;
        private MetroFramework.Controls.MetroButton btnOKSystem;
        private System.Windows.Forms.Label lblstatus;
    }
}