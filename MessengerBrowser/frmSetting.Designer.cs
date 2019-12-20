namespace MessengerBrowser
{
    partial class frmSetting
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
            this.PanelControls = new MetroFramework.Controls.MetroTabControl();
            this.system = new MetroFramework.Controls.MetroTabPage();
            this.cbClear = new MetroFramework.Controls.MetroCheckBox();
            this.btnOKSystem = new MetroFramework.Controls.MetroButton();
            this.cbHead = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffNotifi = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffSystem = new MetroFramework.Controls.MetroCheckBox();
            this.theme = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.btnOKTheme = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.pipSetting = new MetroFramework.Controls.MetroTabPage();
            this.btnOKPIP = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trackHeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackWidth = new System.Windows.Forms.TrackBar();
            this.pnClose = new System.Windows.Forms.Panel();
            this.cbDisableGPU = new MetroFramework.Controls.MetroCheckBox();
            this.PanelControls.SuspendLayout();
            this.system.SuspendLayout();
            this.theme.SuspendLayout();
            this.pipSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelControls
            // 
            this.PanelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControls.Controls.Add(this.system);
            this.PanelControls.Controls.Add(this.theme);
            this.PanelControls.Controls.Add(this.pipSetting);
            this.PanelControls.Location = new System.Drawing.Point(11, 63);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.SelectedIndex = 0;
            this.PanelControls.Size = new System.Drawing.Size(403, 297);
            this.PanelControls.TabIndex = 0;
            this.PanelControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PanelControls.UseSelectable = true;
            // 
            // system
            // 
            this.system.BackColor = System.Drawing.SystemColors.Control;
            this.system.Controls.Add(this.cbDisableGPU);
            this.system.Controls.Add(this.cbClear);
            this.system.Controls.Add(this.btnOKSystem);
            this.system.Controls.Add(this.cbHead);
            this.system.Controls.Add(this.cbOffNotifi);
            this.system.Controls.Add(this.cbOffSystem);
            this.system.HorizontalScrollbarBarColor = true;
            this.system.HorizontalScrollbarHighlightOnWheel = false;
            this.system.HorizontalScrollbarSize = 10;
            this.system.Location = new System.Drawing.Point(4, 38);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(395, 255);
            this.system.TabIndex = 0;
            this.system.Text = "Hệ thống";
            this.system.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.system.VerticalScrollbarBarColor = true;
            this.system.VerticalScrollbarHighlightOnWheel = false;
            this.system.VerticalScrollbarSize = 10;
            // 
            // cbClear
            // 
            this.cbClear.AutoSize = true;
            this.cbClear.Location = new System.Drawing.Point(85, 102);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(120, 15);
            this.cbClear.TabIndex = 6;
            this.cbClear.Text = "Xóa Cookie, cache";
            this.cbClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbClear.UseSelectable = true;
            // 
            // btnOKSystem
            // 
            this.btnOKSystem.Location = new System.Drawing.Point(148, 166);
            this.btnOKSystem.Name = "btnOKSystem";
            this.btnOKSystem.Size = new System.Drawing.Size(101, 42);
            this.btnOKSystem.TabIndex = 5;
            this.btnOKSystem.Text = "Xác nhận";
            this.btnOKSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKSystem.UseSelectable = true;
            this.btnOKSystem.Click += new System.EventHandler(this.btnOKSystem_Click);
            // 
            // cbHead
            // 
            this.cbHead.AutoSize = true;
            this.cbHead.Location = new System.Drawing.Point(85, 81);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(156, 15);
            this.cbHead.TabIndex = 4;
            this.cbHead.Text = "Luôn hiện phía trên cùng";
            this.cbHead.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbHead.UseSelectable = true;
            this.cbHead.Visible = false;
            // 
            // cbOffNotifi
            // 
            this.cbOffNotifi.AutoSize = true;
            this.cbOffNotifi.Location = new System.Drawing.Point(85, 60);
            this.cbOffNotifi.Name = "cbOffNotifi";
            this.cbOffNotifi.Size = new System.Drawing.Size(117, 15);
            this.cbOffNotifi.TabIndex = 3;
            this.cbOffNotifi.Text = "Tắt thông báo nổi";
            this.cbOffNotifi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOffNotifi.UseSelectable = true;
            this.cbOffNotifi.Visible = false;
            // 
            // cbOffSystem
            // 
            this.cbOffSystem.AutoSize = true;
            this.cbOffSystem.Location = new System.Drawing.Point(85, 39);
            this.cbOffSystem.Name = "cbOffSystem";
            this.cbOffSystem.Size = new System.Drawing.Size(216, 15);
            this.cbOffSystem.TabIndex = 2;
            this.cbOffSystem.Text = "Tắt chạy ngầm (Không khuyến nghị)";
            this.cbOffSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOffSystem.UseSelectable = true;
            this.cbOffSystem.Visible = false;
            // 
            // theme
            // 
            this.theme.Controls.Add(this.metroRadioButton3);
            this.theme.Controls.Add(this.btnOKTheme);
            this.theme.Controls.Add(this.metroRadioButton2);
            this.theme.Controls.Add(this.metroRadioButton1);
            this.theme.HorizontalScrollbarBarColor = true;
            this.theme.HorizontalScrollbarHighlightOnWheel = false;
            this.theme.HorizontalScrollbarSize = 10;
            this.theme.Location = new System.Drawing.Point(4, 38);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(395, 255);
            this.theme.TabIndex = 1;
            this.theme.Text = "Giao diện";
            this.theme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.theme.VerticalScrollbarBarColor = true;
            this.theme.VerticalScrollbarHighlightOnWheel = false;
            this.theme.VerticalScrollbarSize = 10;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(44, 93);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(112, 15);
            this.metroRadioButton3.TabIndex = 2;
            this.metroRadioButton3.Text = "Chế độ mật định";
            this.metroRadioButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.Visible = false;
            // 
            // btnOKTheme
            // 
            this.btnOKTheme.Location = new System.Drawing.Point(148, 166);
            this.btnOKTheme.Name = "btnOKTheme";
            this.btnOKTheme.Size = new System.Drawing.Size(101, 42);
            this.btnOKTheme.TabIndex = 6;
            this.btnOKTheme.Text = "Xác nhận";
            this.btnOKTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKTheme.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(44, 72);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(116, 15);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.Text = "Chế độ sáng màu";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.Visible = false;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(44, 51);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(105, 15);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "Chế độ tối màu";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.Visible = false;
            // 
            // pipSetting
            // 
            this.pipSetting.Controls.Add(this.btnOKPIP);
            this.pipSetting.Controls.Add(this.label2);
            this.pipSetting.Controls.Add(this.trackHeight);
            this.pipSetting.Controls.Add(this.label1);
            this.pipSetting.Controls.Add(this.trackWidth);
            this.pipSetting.HorizontalScrollbarBarColor = true;
            this.pipSetting.HorizontalScrollbarHighlightOnWheel = false;
            this.pipSetting.HorizontalScrollbarSize = 10;
            this.pipSetting.Location = new System.Drawing.Point(4, 38);
            this.pipSetting.Name = "pipSetting";
            this.pipSetting.Size = new System.Drawing.Size(395, 255);
            this.pipSetting.TabIndex = 2;
            this.pipSetting.Text = "Tùy chỉnh PIP";
            this.pipSetting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pipSetting.VerticalScrollbarBarColor = true;
            this.pipSetting.VerticalScrollbarHighlightOnWheel = false;
            this.pipSetting.VerticalScrollbarSize = 10;
            // 
            // btnOKPIP
            // 
            this.btnOKPIP.Location = new System.Drawing.Point(151, 185);
            this.btnOKPIP.Name = "btnOKPIP";
            this.btnOKPIP.Size = new System.Drawing.Size(101, 42);
            this.btnOKPIP.TabIndex = 7;
            this.btnOKPIP.Text = "Xác nhận";
            this.btnOKPIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKPIP.UseSelectable = true;
            this.btnOKPIP.Click += new System.EventHandler(this.btnOKPIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chiều rộng:";
            // 
            // trackHeight
            // 
            this.trackHeight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackHeight.Location = new System.Drawing.Point(101, 113);
            this.trackHeight.Maximum = 500;
            this.trackHeight.Minimum = 320;
            this.trackHeight.Name = "trackHeight";
            this.trackHeight.Size = new System.Drawing.Size(269, 45);
            this.trackHeight.TabIndex = 4;
            this.trackHeight.Value = 320;
            this.trackHeight.Scroll += new System.EventHandler(this.trackHeight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiều dài:";
            // 
            // trackWidth
            // 
            this.trackWidth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackWidth.Location = new System.Drawing.Point(101, 56);
            this.trackWidth.Maximum = 500;
            this.trackWidth.Minimum = 325;
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(269, 45);
            this.trackWidth.TabIndex = 2;
            this.trackWidth.Value = 325;
            this.trackWidth.Scroll += new System.EventHandler(this.trackWidth_Scroll);
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = global::MessengerBrowser.Properties.Resources.mac_ico_close1;
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.Location = new System.Drawing.Point(1, 6);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(20, 20);
            this.pnClose.TabIndex = 2;
            this.pnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnClose_MouseClick);
            this.pnClose.MouseLeave += new System.EventHandler(this.pnClose_MouseLeave);
            this.pnClose.MouseHover += new System.EventHandler(this.pnClose_MouseHover);
            // 
            // cbDisableGPU
            // 
            this.cbDisableGPU.AutoSize = true;
            this.cbDisableGPU.Location = new System.Drawing.Point(85, 123);
            this.cbDisableGPU.Name = "cbDisableGPU";
            this.cbDisableGPU.Size = new System.Drawing.Size(251, 15);
            this.cbDisableGPU.TabIndex = 7;
            this.cbDisableGPU.Text = "Vô hiệu hóa tiến trình GPU để tiết kiệm ram";
            this.cbDisableGPU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbDisableGPU.UseSelectable = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 369);
            this.ControlBox = false;
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.PanelControls);
            this.Name = "frmSetting";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cài đặt";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.PanelControls.ResumeLayout(false);
            this.system.ResumeLayout(false);
            this.system.PerformLayout();
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            this.pipSetting.ResumeLayout(false);
            this.pipSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl PanelControls;
        private MetroFramework.Controls.MetroTabPage system;
        private MetroFramework.Controls.MetroButton btnOKSystem;
        private MetroFramework.Controls.MetroCheckBox cbHead;
        private MetroFramework.Controls.MetroCheckBox cbOffNotifi;
        private MetroFramework.Controls.MetroCheckBox cbOffSystem;
        private MetroFramework.Controls.MetroTabPage theme;
        private MetroFramework.Controls.MetroButton btnOKTheme;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroCheckBox cbClear;
        private MetroFramework.Controls.MetroTabPage pipSetting;
        private System.Windows.Forms.TrackBar trackWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackHeight;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnOKPIP;
        private System.Windows.Forms.Panel pnClose;
        private MetroFramework.Controls.MetroCheckBox cbDisableGPU;
    }
}