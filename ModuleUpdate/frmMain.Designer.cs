namespace ModuleUpdate
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblstatus = new System.Windows.Forms.Label();
            this.progressWork = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblstatus.Location = new System.Drawing.Point(80, 83);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(51, 13);
            this.lblstatus.TabIndex = 0;
            this.lblstatus.Text = "Loading..";
            // 
            // progressWork
            // 
            this.progressWork.Location = new System.Drawing.Point(83, 165);
            this.progressWork.Name = "progressWork";
            this.progressWork.Size = new System.Drawing.Size(366, 23);
            this.progressWork.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 280);
            this.Controls.Add(this.progressWork);
            this.Controls.Add(this.lblstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "Hệ thống đang cập nhật..";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ProgressBar progressWork;
    }
}

