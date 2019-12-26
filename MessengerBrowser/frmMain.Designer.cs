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
            this.pnDF = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.lblhostkey = new System.Windows.Forms.Label();
            this.pnReset = new System.Windows.Forms.Panel();
            this.pnMaximize = new System.Windows.Forms.Panel();
            this.pnClose = new System.Windows.Forms.Panel();
            this.pnAutoPIP = new System.Windows.Forms.Panel();
            this.pnEndprocess = new System.Windows.Forms.Panel();
            this.pnFA = new System.Windows.Forms.Panel();
            this.pnMess = new System.Windows.Forms.Panel();
            this.pnClose1 = new System.Windows.Forms.Panel();
            this.pnFA1 = new System.Windows.Forms.Panel();
            this.pnMess1 = new System.Windows.Forms.Panel();
            this.pnMaximize1 = new System.Windows.Forms.Panel();
            this.pnEndprocess1 = new System.Windows.Forms.Panel();
            this.pngrMSFA_1 = new System.Windows.Forms.Panel();
            this.pngrMSFA = new System.Windows.Forms.Panel();
            this.pngrMSFA_1.SuspendLayout();
            this.pngrMSFA.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPIP
            // 
            this.pnPIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPIP.BackColor = System.Drawing.Color.Transparent;
            this.pnPIP.Location = new System.Drawing.Point(567, 5);
            this.pnPIP.Name = "pnPIP";
            this.pnPIP.Size = new System.Drawing.Size(25, 18);
            this.pnPIP.TabIndex = 0;
            this.pnPIP.Click += new System.EventHandler(this.pnPIP_Click);
            // 
            // pnDF
            // 
            this.pnDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDF.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnDF.Location = new System.Drawing.Point(1, 23);
            this.pnDF.Name = "pnDF";
            this.pnDF.Size = new System.Drawing.Size(672, 9);
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
            // lblhostkey
            // 
            this.lblhostkey.AutoSize = true;
            this.lblhostkey.Location = new System.Drawing.Point(134, 7);
            this.lblhostkey.Name = "lblhostkey";
            this.lblhostkey.Size = new System.Drawing.Size(0, 13);
            this.lblhostkey.TabIndex = 19;
            // 
            // pnReset
            // 
            this.pnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnReset.BackColor = System.Drawing.Color.Transparent;
            this.pnReset.BackgroundImage = global::MessengerBrowser.Properties.Resources.bug_vector_png_1_300x200;
            this.pnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnReset.Location = new System.Drawing.Point(541, 4);
            this.pnReset.Name = "pnReset";
            this.pnReset.Size = new System.Drawing.Size(19, 19);
            this.pnReset.TabIndex = 4;
            this.pnReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnReset_MouseClick);
            // 
            // pnMaximize
            // 
            this.pnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.pnMaximize.BackgroundImage = global::MessengerBrowser.Properties.Resources.icon_mac_maximize2;
            this.pnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMaximize.Location = new System.Drawing.Point(25, 4);
            this.pnMaximize.Name = "pnMaximize";
            this.pnMaximize.Size = new System.Drawing.Size(19, 19);
            this.pnMaximize.TabIndex = 18;
            this.pnMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMaximize_MouseClick);
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = global::MessengerBrowser.Properties.Resources.mac_ico_close2;
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.Location = new System.Drawing.Point(1, 4);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(19, 19);
            this.pnClose.TabIndex = 17;
            this.pnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnClose_MouseClick);
            // 
            // pnAutoPIP
            // 
            this.pnAutoPIP.BackColor = System.Drawing.Color.Transparent;
            this.pnAutoPIP.BackgroundImage = global::MessengerBrowser.Properties.Resources.done;
            this.pnAutoPIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnAutoPIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAutoPIP.Location = new System.Drawing.Point(95, 3);
            this.pnAutoPIP.Name = "pnAutoPIP";
            this.pnAutoPIP.Size = new System.Drawing.Size(21, 21);
            this.pnAutoPIP.TabIndex = 3;
            this.pnAutoPIP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnAutoPIP_MouseClick);
            // 
            // pnEndprocess
            // 
            this.pnEndprocess.BackColor = System.Drawing.Color.Transparent;
            this.pnEndprocess.BackgroundImage = global::MessengerBrowser.Properties.Resources.close_red;
            this.pnEndprocess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnEndprocess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnEndprocess.Location = new System.Drawing.Point(48, 3);
            this.pnEndprocess.Name = "pnEndprocess";
            this.pnEndprocess.Size = new System.Drawing.Size(22, 22);
            this.pnEndprocess.TabIndex = 3;
            this.pnEndprocess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbEndprocess_MouseClick);
            // 
            // pnFA
            // 
            this.pnFA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFA.BackColor = System.Drawing.Color.Transparent;
            this.pnFA.BackgroundImage = global::MessengerBrowser.Properties.Resources.Sicons_Basic_Round_Social_Facebook;
            this.pnFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnFA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnFA.Location = new System.Drawing.Point(29, 0);
            this.pnFA.Name = "pnFA";
            this.pnFA.Size = new System.Drawing.Size(18, 18);
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
            this.pnMess.Location = new System.Drawing.Point(7, -1);
            this.pnMess.Name = "pnMess";
            this.pnMess.Size = new System.Drawing.Size(20, 20);
            this.pnMess.TabIndex = 0;
            this.pnMess.Click += new System.EventHandler(this.pnMess_Click);
            // 
            // pnClose1
            // 
            this.pnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnClose1.BackColor = System.Drawing.Color.Transparent;
            this.pnClose1.BackgroundImage = global::MessengerBrowser.Properties.Resources.mac_ico_close2;
            this.pnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose1.Location = new System.Drawing.Point(654, 4);
            this.pnClose1.Name = "pnClose1";
            this.pnClose1.Size = new System.Drawing.Size(19, 19);
            this.pnClose1.TabIndex = 18;
            this.pnClose1.Visible = false;
            this.pnClose1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnClose_MouseClick);
            // 
            // pnFA1
            // 
            this.pnFA1.BackColor = System.Drawing.Color.Transparent;
            this.pnFA1.BackgroundImage = global::MessengerBrowser.Properties.Resources.Sicons_Basic_Round_Social_Facebook;
            this.pnFA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFA1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnFA1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnFA1.Location = new System.Drawing.Point(24, 0);
            this.pnFA1.Name = "pnFA1";
            this.pnFA1.Size = new System.Drawing.Size(18, 18);
            this.pnFA1.TabIndex = 1;
            this.pnFA1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnFA_MouseClick);
            // 
            // pnMess1
            // 
            this.pnMess1.BackColor = System.Drawing.Color.Transparent;
            this.pnMess1.BackgroundImage = global::MessengerBrowser.Properties.Resources.messenger_app_icon_28;
            this.pnMess1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMess1.Location = new System.Drawing.Point(1, -1);
            this.pnMess1.Name = "pnMess1";
            this.pnMess1.Size = new System.Drawing.Size(20, 20);
            this.pnMess1.TabIndex = 1;
            this.pnMess1.Click += new System.EventHandler(this.pnMess_Click);
            // 
            // pnMaximize1
            // 
            this.pnMaximize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.pnMaximize1.BackgroundImage = global::MessengerBrowser.Properties.Resources.icon_mac_maximize2;
            this.pnMaximize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMaximize1.Location = new System.Drawing.Point(630, 4);
            this.pnMaximize1.Name = "pnMaximize1";
            this.pnMaximize1.Size = new System.Drawing.Size(19, 19);
            this.pnMaximize1.TabIndex = 19;
            this.pnMaximize1.Visible = false;
            this.pnMaximize1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnMaximize_MouseClick);
            // 
            // pnEndprocess1
            // 
            this.pnEndprocess1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnEndprocess1.BackColor = System.Drawing.Color.Transparent;
            this.pnEndprocess1.BackgroundImage = global::MessengerBrowser.Properties.Resources.close_red;
            this.pnEndprocess1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnEndprocess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnEndprocess1.Location = new System.Drawing.Point(606, 3);
            this.pnEndprocess1.Name = "pnEndprocess1";
            this.pnEndprocess1.Size = new System.Drawing.Size(21, 21);
            this.pnEndprocess1.TabIndex = 4;
            this.pnEndprocess1.Visible = false;
            this.pnEndprocess1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbEndprocess_MouseClick);
            // 
            // pngrMSFA_1
            // 
            this.pngrMSFA_1.Controls.Add(this.pnMess1);
            this.pngrMSFA_1.Controls.Add(this.pnFA1);
            this.pngrMSFA_1.Location = new System.Drawing.Point(21, 5);
            this.pngrMSFA_1.Name = "pngrMSFA_1";
            this.pngrMSFA_1.Size = new System.Drawing.Size(51, 19);
            this.pngrMSFA_1.TabIndex = 20;
            // 
            // pngrMSFA
            // 
            this.pngrMSFA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pngrMSFA.Controls.Add(this.pnFA);
            this.pngrMSFA.Controls.Add(this.pnMess);
            this.pngrMSFA.Location = new System.Drawing.Point(605, 5);
            this.pngrMSFA.Name = "pngrMSFA";
            this.pngrMSFA.Size = new System.Drawing.Size(48, 19);
            this.pngrMSFA.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(674, 524);
            this.ControlBox = false;
            this.Controls.Add(this.pnMaximize1);
            this.Controls.Add(this.pnClose1);
            this.Controls.Add(this.pnMaximize);
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.pnReset);
            this.Controls.Add(this.lblhostkey);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.pnDF);
            this.Controls.Add(this.pnAutoPIP);
            this.Controls.Add(this.pnPIP);
            this.Controls.Add(this.pngrMSFA_1);
            this.Controls.Add(this.pnEndprocess);
            this.Controls.Add(this.pngrMSFA);
            this.Controls.Add(this.pnEndprocess1);
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
            this.pngrMSFA_1.ResumeLayout(false);
            this.pngrMSFA.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnReset;
        private System.Windows.Forms.Panel pnClose1;
        private System.Windows.Forms.Panel pnFA1;
        private System.Windows.Forms.Panel pnMess1;
        private System.Windows.Forms.Panel pnMaximize1;
        private System.Windows.Forms.Panel pnEndprocess1;
        private System.Windows.Forms.Panel pngrMSFA_1;
        private System.Windows.Forms.Panel pngrMSFA;
    }
}

