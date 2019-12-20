namespace MessengerBrowser
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
            this.pnPIP = new System.Windows.Forms.Panel();
            this.pnAutoPIP = new System.Windows.Forms.Panel();
            this.pnEndprocess = new System.Windows.Forms.Panel();
            this.pnFA = new System.Windows.Forms.Panel();
            this.pnMess = new System.Windows.Forms.Panel();
            this.pnDF = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.pnClose = new System.Windows.Forms.Panel();
            this.pnMaximize = new System.Windows.Forms.Panel();
            this.lblhostkey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnPIP
            // 
            this.pnPIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPIP.BackColor = System.Drawing.Color.Transparent;
            this.pnPIP.Location = new System.Drawing.Point(567, 6);
            this.pnPIP.Name = "pnPIP";
            this.pnPIP.Size = new System.Drawing.Size(25, 18);
            this.pnPIP.TabIndex = 0;
            this.pnPIP.Click += new System.EventHandler(this.pnPIP_Click);
            // 
            // pnAutoPIP
            // 
            this.pnAutoPIP.BackColor = System.Drawing.Color.Transparent;
            this.pnAutoPIP.BackgroundImage = global::MessengerBrowser.Properties.Resources.done;
            this.pnAutoPIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnAutoPIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAutoPIP.Location = new System.Drawing.Point(95, 3);
            this.pnAutoPIP.Name = "pnAutoPIP";
            this.pnAutoPIP.Size = new System.Drawing.Size(23, 23);
            this.pnAutoPIP.TabIndex = 3;
            this.pnAutoPIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnAutoPIP_MouseClick);
            // 
            // pnEndprocess
            // 
            this.pnEndprocess.BackColor = System.Drawing.Color.Transparent;
            this.pnEndprocess.BackgroundImage = global::MessengerBrowser.Properties.Resources.close_red;
            this.pnEndprocess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnEndprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnEndprocess.Location = new System.Drawing.Point(51, 2);
            this.pnEndprocess.Name = "pnEndprocess";
            this.pnEndprocess.Size = new System.Drawing.Size(24, 24);
            this.pnEndprocess.TabIndex = 3;
            this.pnEndprocess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbEndprocess_MouseClick);
            // 
            // pnFA
            // 
            this.pnFA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFA.BackColor = System.Drawing.Color.Transparent;
            this.pnFA.BackgroundImage = global::MessengerBrowser.Properties.Resources.facebook_new1;
            this.pnFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnFA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnFA.Location = new System.Drawing.Point(635, 4);
            this.pnFA.Name = "pnFA";
            this.pnFA.Size = new System.Drawing.Size(26, 22);
            this.pnFA.TabIndex = 0;
            this.pnFA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnFA_MouseClick);
            // 
            // pnMess
            // 
            this.pnMess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMess.BackColor = System.Drawing.Color.Transparent;
            this.pnMess.BackgroundImage = global::MessengerBrowser.Properties.Resources.messenger_app_icon_28;
            this.pnMess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMess.Location = new System.Drawing.Point(613, 4);
            this.pnMess.Name = "pnMess";
            this.pnMess.Size = new System.Drawing.Size(22, 22);
            this.pnMess.TabIndex = 0;
            this.pnMess.Click += new System.EventHandler(this.pnMess_Click);
            // 
            // pnDF
            // 
            this.pnDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDF.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnDF.Location = new System.Drawing.Point(1, 24);
            this.pnDF.Name = "pnDF";
            this.pnDF.Size = new System.Drawing.Size(674, 9);
            this.pnDF.TabIndex = 10;
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.BackColor = System.Drawing.SystemColors.Control;
            this.PanelMain.Location = new System.Drawing.Point(1, 29);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(672, 493);
            this.PanelMain.TabIndex = 16;
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = global::MessengerBrowser.Properties.Resources.mac_ico_close2;
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.Location = new System.Drawing.Point(3, 4);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(20, 20);
            this.pnClose.TabIndex = 17;
            this.pnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnClose_MouseClick);
            // 
            // pnMaximize
            // 
            this.pnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.pnMaximize.BackgroundImage = global::MessengerBrowser.Properties.Resources.icon_mac_maximize2;
            this.pnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMaximize.Location = new System.Drawing.Point(27, 4);
            this.pnMaximize.Name = "pnMaximize";
            this.pnMaximize.Size = new System.Drawing.Size(20, 20);
            this.pnMaximize.TabIndex = 18;
            this.pnMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMaximize_MouseClick);
            // 
            // lblhostkey
            // 
            this.lblhostkey.AutoSize = true;
            this.lblhostkey.Location = new System.Drawing.Point(148, 8);
            this.lblhostkey.Name = "lblhostkey";
            this.lblhostkey.Size = new System.Drawing.Size(0, 13);
            this.lblhostkey.TabIndex = 19;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(674, 524);
            this.ControlBox = false;
            this.Controls.Add(this.lblhostkey);
            this.Controls.Add(this.pnMaximize);
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.pnDF);
            this.Controls.Add(this.pnAutoPIP);
            this.Controls.Add(this.pnEndprocess);
            this.Controls.Add(this.pnPIP);
            this.Controls.Add(this.pnFA);
            this.Controls.Add(this.pnMess);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Messenger - Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Move += new System.EventHandler(this.frmMain_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnMess;
        private System.Windows.Forms.Panel pnFA;
        private System.Windows.Forms.Panel pnPIP;
        private System.Windows.Forms.Panel pnEndprocess;
        private System.Windows.Forms.Panel pnAutoPIP;
        private System.Windows.Forms.Panel pnDF;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Panel pnMaximize;
        private System.Windows.Forms.Label lblhostkey;
    }
}

