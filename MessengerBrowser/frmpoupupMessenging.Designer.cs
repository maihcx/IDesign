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
            this.pnPoupup1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnClose1 = new System.Windows.Forms.Panel();
            this.pnClose1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPoupup1
            // 
            this.pnPoupup1.BackColor = System.Drawing.Color.White;
            this.pnPoupup1.BackgroundImage = global::MessengerBrowser.Properties.Resources.messengerIcon40x40;
            this.pnPoupup1.Location = new System.Drawing.Point(12, 12);
            this.pnPoupup1.Name = "pnPoupup1";
            this.pnPoupup1.Size = new System.Drawing.Size(50, 48);
            this.pnPoupup1.TabIndex = 0;
            this.pnPoupup1.Visible = false;
            this.pnPoupup1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseDown);
            this.pnPoupup1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseMove);
            this.pnPoupup1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnPoupup_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // pnClose1
            // 
            this.pnClose1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnClose1.BackColor = System.Drawing.Color.White;
            this.pnClose1.Controls.Add(this.label1);
            this.pnClose1.Location = new System.Drawing.Point(254, 242);
            this.pnClose1.Name = "pnClose1";
            this.pnClose1.Size = new System.Drawing.Size(72, 63);
            this.pnClose1.TabIndex = 1;
            this.pnClose1.Visible = false;
            // 
            // frmpoupupMessenging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(565, 317);
            this.Controls.Add(this.pnPoupup1);
            this.Controls.Add(this.pnClose1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmpoupupMessenging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "poupupMessenging";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.frmpoupupMessenging_Load);
            this.Click += new System.EventHandler(this.frmpoupupMessenging_Click);
            this.pnClose1.ResumeLayout(false);
            this.pnClose1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPoupup1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnClose1;
    }
}