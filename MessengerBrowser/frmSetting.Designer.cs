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
            this.cbDisableGPU = new MetroFramework.Controls.MetroCheckBox();
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
            this.rdbHideName = new MetroFramework.Controls.MetroRadioButton();
            this.rdbShowName = new MetroFramework.Controls.MetroRadioButton();
            this.trackPIPPanelWidth = new MetroFramework.Controls.MetroTrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackPIPPanelHeight = new MetroFramework.Controls.MetroTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackHeight = new MetroFramework.Controls.MetroTrackBar();
            this.trackWidth = new MetroFramework.Controls.MetroTrackBar();
            this.btnOKPIP = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.multiThread = new MetroFramework.Controls.MetroTabPage();
            this.btnOKMulti = new MetroFramework.Controls.MetroButton();
            this.cbFA = new MetroFramework.Controls.MetroCheckBox();
            this.pnClose = new System.Windows.Forms.Panel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.PanelControls.SuspendLayout();
            this.system.SuspendLayout();
            this.theme.SuspendLayout();
            this.pipSetting.SuspendLayout();
            this.multiThread.SuspendLayout();
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
            this.PanelControls.Controls.Add(this.multiThread);
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
            this.pipSetting.Controls.Add(this.rdbHideName);
            this.pipSetting.Controls.Add(this.rdbShowName);
            this.pipSetting.Controls.Add(this.trackPIPPanelWidth);
            this.pipSetting.Controls.Add(this.label4);
            this.pipSetting.Controls.Add(this.trackPIPPanelHeight);
            this.pipSetting.Controls.Add(this.label3);
            this.pipSetting.Controls.Add(this.trackHeight);
            this.pipSetting.Controls.Add(this.trackWidth);
            this.pipSetting.Controls.Add(this.btnOKPIP);
            this.pipSetting.Controls.Add(this.label2);
            this.pipSetting.Controls.Add(this.label1);
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
            // rdbHideName
            // 
            this.rdbHideName.AutoSize = true;
            this.rdbHideName.Location = new System.Drawing.Point(218, 121);
            this.rdbHideName.Name = "rdbHideName";
            this.rdbHideName.Size = new System.Drawing.Size(73, 15);
            this.rdbHideName.TabIndex = 15;
            this.rdbHideName.Text = "Ẩn Name";
            this.rdbHideName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbHideName.UseSelectable = true;
            this.rdbHideName.CheckedChanged += new System.EventHandler(this.rdbHideName_CheckedChanged);
            // 
            // rdbShowName
            // 
            this.rdbShowName.AutoSize = true;
            this.rdbShowName.Location = new System.Drawing.Point(82, 121);
            this.rdbShowName.Name = "rdbShowName";
            this.rdbShowName.Size = new System.Drawing.Size(100, 15);
            this.rdbShowName.TabIndex = 14;
            this.rdbShowName.Text = "Hiển thị Name";
            this.rdbShowName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbShowName.UseSelectable = true;
            this.rdbShowName.CheckedChanged += new System.EventHandler(this.rdbShowName_CheckedChanged);
            // 
            // trackPIPPanelWidth
            // 
            this.trackPIPPanelWidth.BackColor = System.Drawing.Color.Transparent;
            this.trackPIPPanelWidth.Location = new System.Drawing.Point(115, 239);
            this.trackPIPPanelWidth.Maximum = 600;
            this.trackPIPPanelWidth.Minimum = 400;
            this.trackPIPPanelWidth.Name = "trackPIPPanelWidth";
            this.trackPIPPanelWidth.Size = new System.Drawing.Size(240, 23);
            this.trackPIPPanelWidth.TabIndex = 13;
            this.trackPIPPanelWidth.Text = "Width";
            this.trackPIPPanelWidth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackPIPPanelWidth.Value = 400;
            this.trackPIPPanelWidth.Visible = false;
            this.trackPIPPanelWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackPIPPanelWidth_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chiều rộng PIP:";
            this.label4.Visible = false;
            // 
            // trackPIPPanelHeight
            // 
            this.trackPIPPanelHeight.BackColor = System.Drawing.Color.Transparent;
            this.trackPIPPanelHeight.Location = new System.Drawing.Point(115, 210);
            this.trackPIPPanelHeight.Maximum = 600;
            this.trackPIPPanelHeight.Minimum = 200;
            this.trackPIPPanelHeight.Name = "trackPIPPanelHeight";
            this.trackPIPPanelHeight.Size = new System.Drawing.Size(240, 23);
            this.trackPIPPanelHeight.TabIndex = 11;
            this.trackPIPPanelHeight.Text = "Height";
            this.trackPIPPanelHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackPIPPanelHeight.Value = 200;
            this.trackPIPPanelHeight.Visible = false;
            this.trackPIPPanelHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackPIPPanelHeight_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chiều dài PIP:";
            this.label3.Visible = false;
            // 
            // trackHeight
            // 
            this.trackHeight.BackColor = System.Drawing.Color.Transparent;
            this.trackHeight.Location = new System.Drawing.Point(101, 66);
            this.trackHeight.Maximum = 500;
            this.trackHeight.Minimum = 320;
            this.trackHeight.Name = "trackHeight";
            this.trackHeight.Size = new System.Drawing.Size(269, 23);
            this.trackHeight.TabIndex = 9;
            this.trackHeight.Text = "Width";
            this.trackHeight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackHeight.Value = 320;
            this.trackHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackHeight_Scroll);
            // 
            // trackWidth
            // 
            this.trackWidth.BackColor = System.Drawing.Color.Transparent;
            this.trackWidth.Location = new System.Drawing.Point(101, 37);
            this.trackWidth.Maximum = 550;
            this.trackWidth.Minimum = 325;
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(269, 23);
            this.trackWidth.TabIndex = 8;
            this.trackWidth.Text = "Width";
            this.trackWidth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.trackWidth.Value = 325;
            this.trackWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackWidth_Scroll);
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
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chiều rộng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiều dài:";
            // 
            // multiThread
            // 
            this.multiThread.Controls.Add(this.btnOKMulti);
            this.multiThread.Controls.Add(this.cbFA);
            this.multiThread.HorizontalScrollbarBarColor = true;
            this.multiThread.HorizontalScrollbarHighlightOnWheel = false;
            this.multiThread.HorizontalScrollbarSize = 10;
            this.multiThread.Location = new System.Drawing.Point(4, 38);
            this.multiThread.Name = "multiThread";
            this.multiThread.Size = new System.Drawing.Size(395, 255);
            this.multiThread.TabIndex = 3;
            this.multiThread.Text = "Đa nhiệm trang";
            this.multiThread.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.multiThread.VerticalScrollbarBarColor = true;
            this.multiThread.VerticalScrollbarHighlightOnWheel = false;
            this.multiThread.VerticalScrollbarSize = 10;
            // 
            // btnOKMulti
            // 
            this.btnOKMulti.Location = new System.Drawing.Point(151, 185);
            this.btnOKMulti.Name = "btnOKMulti";
            this.btnOKMulti.Size = new System.Drawing.Size(101, 42);
            this.btnOKMulti.TabIndex = 8;
            this.btnOKMulti.Text = "Xác nhận";
            this.btnOKMulti.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKMulti.UseSelectable = true;
            this.btnOKMulti.Click += new System.EventHandler(this.btnOKMulti_Click);
            // 
            // cbFA
            // 
            this.cbFA.AutoSize = true;
            this.cbFA.Location = new System.Drawing.Point(36, 27);
            this.cbFA.Name = "cbFA";
            this.cbFA.Size = new System.Drawing.Size(74, 15);
            this.cbFA.TabIndex = 2;
            this.cbFA.Text = "Facebook";
            this.cbFA.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbFA.UseSelectable = true;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(309, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Check update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 369);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpdate);
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
            this.multiThread.ResumeLayout(false);
            this.multiThread.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnOKPIP;
        private System.Windows.Forms.Panel pnClose;
        private MetroFramework.Controls.MetroCheckBox cbDisableGPU;
        private MetroFramework.Controls.MetroTrackBar trackWidth;
        private MetroFramework.Controls.MetroTrackBar trackHeight;
        private MetroFramework.Controls.MetroTabPage multiThread;
        private MetroFramework.Controls.MetroCheckBox cbFA;
        private MetroFramework.Controls.MetroButton btnOKMulti;
        private MetroFramework.Controls.MetroTrackBar trackPIPPanelHeight;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTrackBar trackPIPPanelWidth;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroRadioButton rdbHideName;
        private MetroFramework.Controls.MetroRadioButton rdbShowName;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}