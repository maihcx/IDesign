namespace MessengerBrowser
{
    partial class frmpoupupMessenging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpoupupMessenging));
            this.pnClose = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPoupup = new System.Windows.Forms.Panel();
            this.pnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnClose
            // 
            this.pnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnClose.BackColor = System.Drawing.Color.White;
            this.pnClose.Controls.Add(this.label1);
            this.pnClose.Location = new System.Drawing.Point(254, 242);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(72, 63);
            this.pnClose.TabIndex = 1;
            this.pnClose.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // pnPoupup
            // 
            this.pnPoupup.BackColor = System.Drawing.Color.White;
            this.pnPoupup.BackgroundImage = global::MessengerBrowser.Properties.Resources.messengerIcon40x40;
            this.pnPoupup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnPoupup.Location = new System.Drawing.Point(12, 12);
            this.pnPoupup.Name = "pnPoupup";
            this.pnPoupup.Size = new System.Drawing.Size(50, 48);
            this.pnPoupup.TabIndex = 0;
            this.pnPoupup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseDown);
            this.pnPoupup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseMove);
            this.pnPoupup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseUp);
            // 
            // frmpoupupMessenging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(565, 317);
            this.Controls.Add(this.pnPoupup);
            this.Controls.Add(this.pnClose);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmpoupupMessenging";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "poupupMessenging";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.frmpoupupMessenging_Load);
            this.pnClose.ResumeLayout(false);
            this.pnClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPoupup;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Label label1;
    }
}