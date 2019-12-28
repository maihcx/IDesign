namespace MessengerBrowser
{
    partial class frmIconTray
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIconTray));
            this.IconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupNoty = new Tulpep.NotificationWindow.PopupNotifier();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconTray
            // 
            this.IconTray.BalloonTipTitle = "Messenger";
            this.IconTray.ContextMenuStrip = this.contextMenu;
            this.IconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("IconTray.Icon")));
            this.IconTray.Text = "Messenger";
            this.IconTray.Visible = true;
            this.IconTray.BalloonTipClicked += new System.EventHandler(this.IconTray_BalloonTipClicked);
            this.IconTray.BalloonTipClosed += new System.EventHandler(this.IconTray_BalloonTipClosed);
            this.IconTray.BalloonTipShown += new System.EventHandler(this.IconTray_BalloonTipShown);
            this.IconTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IconTray_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMessengerToolStripMenuItem,
            this.càiĐặtToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(154, 48);
            // 
            // exitMessengerToolStripMenuItem
            // 
            this.exitMessengerToolStripMenuItem.Name = "exitMessengerToolStripMenuItem";
            this.exitMessengerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitMessengerToolStripMenuItem.Text = "Exit messenger";
            this.exitMessengerToolStripMenuItem.Click += new System.EventHandler(this.exitMessengerToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            this.càiĐặtToolStripMenuItem.Click += new System.EventHandler(this.càiĐặtToolStripMenuItem_Click);
            // 
            // popupNoty
            // 
            this.popupNoty.ContentFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNoty.ContentText = null;
            this.popupNoty.Image = global::MessengerBrowser.Properties.Resources.messenger_app_icon_28;
            this.popupNoty.ImageSize = new System.Drawing.Size(20, 20);
            this.popupNoty.IsRightToLeft = false;
            this.popupNoty.OptionsMenu = null;
            this.popupNoty.Size = new System.Drawing.Size(400, 100);
            this.popupNoty.TitleFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popupNoty.TitleText = null;
            this.popupNoty.Click += new System.EventHandler(this.popupNoty_Click);
            // 
            // frmIconTray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 179);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIconTray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmIconTray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmIconTray_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon IconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMessengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private Tulpep.NotificationWindow.PopupNotifier popupNoty;
    }
}