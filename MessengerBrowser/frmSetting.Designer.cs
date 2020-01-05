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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.PanelControls = new MetroFramework.Controls.MetroTabControl();
            this.system = new MetroFramework.Controls.MetroTabPage();
            this.cbStartup = new MetroFramework.Controls.MetroCheckBox();
            this.cbDisableGPU = new MetroFramework.Controls.MetroCheckBox();
            this.cbClear = new MetroFramework.Controls.MetroCheckBox();
            this.btnOKSystem = new MetroFramework.Controls.MetroButton();
            this.cbHead = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffNotifi = new MetroFramework.Controls.MetroCheckBox();
            this.cbOffSystem = new MetroFramework.Controls.MetroCheckBox();
            this.pipSetting = new MetroFramework.Controls.MetroTabPage();
            this.cbbPIPTopMost = new MetroFramework.Controls.MetroCheckBox();
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
            this.theme = new MetroFramework.Controls.MetroTabPage();
            this.cbMessenging = new MetroFramework.Controls.MetroCheckBox();
            this.cbbStyleWin = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.btnOKTheme = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.multiThread = new MetroFramework.Controls.MetroTabPage();
            this.cbOutApplication = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFA = new MetroFramework.Controls.MetroCheckBox();
            this.btnOKMulti = new MetroFramework.Controls.MetroButton();
            this.UpdateClone = new MetroFramework.Controls.MetroTabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOKUpdate = new MetroFramework.Controls.MetroButton();
            this.cbOffUpdate = new MetroFramework.Controls.MetroCheckBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.pnClose = new System.Windows.Forms.Panel();
            this.PanelControls.SuspendLayout();
            this.system.SuspendLayout();
            this.pipSetting.SuspendLayout();
            this.theme.SuspendLayout();
            this.multiThread.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.UpdateClone.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControls
            // 
            this.PanelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelControls.Controls.Add(this.system);
            this.PanelControls.Controls.Add(this.pipSetting);
            this.PanelControls.Controls.Add(this.theme);
            this.PanelControls.Controls.Add(this.multiThread);
            this.PanelControls.Controls.Add(this.UpdateClone);
            this.PanelControls.Location = new System.Drawing.Point(11, 63);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.SelectedIndex = 0;
            this.PanelControls.Size = new System.Drawing.Size(492, 308);
            this.PanelControls.TabIndex = 0;
            this.PanelControls.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PanelControls.UseSelectable = true;
            // 
            // system
            // 
            this.system.BackColor = System.Drawing.SystemColors.Control;
            this.system.Controls.Add(this.cbStartup);
            this.system.Controls.Add(this.cbDisableGPU);
            this.system.Controls.Add(this.cbClear);
            this.system.Controls.Add(this.btnOKSystem);
            this.system.Controls.Add(this.cbHead);
            this.system.Controls.Add(this.cbOffNotifi);
            this.system.Controls.Add(this.cbOffSystem);
            this.system.HorizontalScrollbar = true;
            this.system.HorizontalScrollbarBarColor = true;
            this.system.HorizontalScrollbarHighlightOnWheel = false;
            this.system.HorizontalScrollbarSize = 10;
            this.system.Location = new System.Drawing.Point(4, 38);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(484, 266);
            this.system.TabIndex = 0;
            this.system.Text = "Hệ thống";
            this.system.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.system.VerticalScrollbar = true;
            this.system.VerticalScrollbarBarColor = true;
            this.system.VerticalScrollbarHighlightOnWheel = false;
            this.system.VerticalScrollbarSize = 10;
            // 
            // cbStartup
            // 
            this.cbStartup.AutoSize = true;
            this.cbStartup.Location = new System.Drawing.Point(126, 144);
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.Size = new System.Drawing.Size(156, 15);
            this.cbStartup.TabIndex = 8;
            this.cbStartup.Text = "Khởi chạy cùng hệ thống";
            this.cbStartup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbStartup.UseSelectable = true;
            this.cbStartup.Visible = false;
            // 
            // cbDisableGPU
            // 
            this.cbDisableGPU.AutoSize = true;
            this.cbDisableGPU.Location = new System.Drawing.Point(126, 123);
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
            this.cbClear.Location = new System.Drawing.Point(126, 102);
            this.cbClear.Name = "cbClear";
            this.cbClear.Size = new System.Drawing.Size(120, 15);
            this.cbClear.TabIndex = 6;
            this.cbClear.Text = "Xóa Cookie, cache";
            this.cbClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbClear.UseSelectable = true;
            // 
            // btnOKSystem
            // 
            this.btnOKSystem.Location = new System.Drawing.Point(197, 200);
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
            this.cbHead.Location = new System.Drawing.Point(126, 81);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(305, 15);
            this.cbHead.TabIndex = 4;
            this.cbHead.Text = "Luôn hiện phía trên cùng (Luôn hiện trên mọi cửa sổ)";
            this.cbHead.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbHead.UseSelectable = true;
            // 
            // cbOffNotifi
            // 
            this.cbOffNotifi.AutoSize = true;
            this.cbOffNotifi.Location = new System.Drawing.Point(126, 60);
            this.cbOffNotifi.Name = "cbOffNotifi";
            this.cbOffNotifi.Size = new System.Drawing.Size(215, 15);
            this.cbOffNotifi.TabIndex = 3;
            this.cbOffNotifi.Text = "Thông báo nổi (Thông báo tin nhắn)";
            this.cbOffNotifi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOffNotifi.UseSelectable = true;
            // 
            // cbOffSystem
            // 
            this.cbOffSystem.AutoSize = true;
            this.cbOffSystem.Location = new System.Drawing.Point(126, 39);
            this.cbOffSystem.Name = "cbOffSystem";
            this.cbOffSystem.Size = new System.Drawing.Size(216, 15);
            this.cbOffSystem.TabIndex = 2;
            this.cbOffSystem.Text = "Tắt chạy ngầm (Không khuyến nghị)";
            this.cbOffSystem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOffSystem.UseSelectable = true;
            // 
            // pipSetting
            // 
            this.pipSetting.Controls.Add(this.cbbPIPTopMost);
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
            this.pipSetting.Size = new System.Drawing.Size(484, 266);
            this.pipSetting.TabIndex = 2;
            this.pipSetting.Text = "Tùy chỉnh PIP";
            this.pipSetting.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pipSetting.VerticalScrollbarBarColor = true;
            this.pipSetting.VerticalScrollbarHighlightOnWheel = false;
            this.pipSetting.VerticalScrollbarSize = 10;
            // 
            // cbbPIPTopMost
            // 
            this.cbbPIPTopMost.AutoSize = true;
            this.cbbPIPTopMost.Location = new System.Drawing.Point(162, 104);
            this.cbbPIPTopMost.Name = "cbbPIPTopMost";
            this.cbbPIPTopMost.Size = new System.Drawing.Size(175, 15);
            this.cbbPIPTopMost.TabIndex = 16;
            this.cbbPIPTopMost.Text = "Cho phép PIP hiện trên cùng";
            this.cbbPIPTopMost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbbPIPTopMost.UseSelectable = true;
            this.cbbPIPTopMost.CheckedChanged += new System.EventHandler(this.cbbPIPTopMost_CheckedChanged);
            // 
            // rdbHideName
            // 
            this.rdbHideName.AutoSize = true;
            this.rdbHideName.Location = new System.Drawing.Point(274, 148);
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
            this.rdbShowName.Location = new System.Drawing.Point(138, 148);
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
            this.trackHeight.Location = new System.Drawing.Point(138, 66);
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
            this.trackWidth.Location = new System.Drawing.Point(138, 37);
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
            this.btnOKPIP.Location = new System.Drawing.Point(197, 200);
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
            this.label2.Location = new System.Drawing.Point(60, 70);
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
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiều dài:";
            // 
            // theme
            // 
            this.theme.Controls.Add(this.cbMessenging);
            this.theme.Controls.Add(this.cbbStyleWin);
            this.theme.Controls.Add(this.metroLabel1);
            this.theme.Controls.Add(this.metroRadioButton3);
            this.theme.Controls.Add(this.btnOKTheme);
            this.theme.Controls.Add(this.metroRadioButton2);
            this.theme.Controls.Add(this.metroRadioButton1);
            this.theme.HorizontalScrollbarBarColor = true;
            this.theme.HorizontalScrollbarHighlightOnWheel = false;
            this.theme.HorizontalScrollbarSize = 10;
            this.theme.Location = new System.Drawing.Point(4, 38);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(484, 266);
            this.theme.TabIndex = 1;
            this.theme.Text = "Giao diện";
            this.theme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.theme.VerticalScrollbarBarColor = true;
            this.theme.VerticalScrollbarHighlightOnWheel = false;
            this.theme.VerticalScrollbarSize = 10;
            // 
            // cbMessenging
            // 
            this.cbMessenging.AutoSize = true;
            this.cbMessenging.Location = new System.Drawing.Point(144, 122);
            this.cbMessenging.Name = "cbMessenging";
            this.cbMessenging.Size = new System.Drawing.Size(188, 15);
            this.cbMessenging.TabIndex = 17;
            this.cbMessenging.Text = "Cho phép sử dụng Messenging";
            this.cbMessenging.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbMessenging.UseSelectable = true;
            // 
            // cbbStyleWin
            // 
            this.cbbStyleWin.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cbbStyleWin.FormattingEnabled = true;
            this.cbbStyleWin.ItemHeight = 19;
            this.cbbStyleWin.Items.AddRange(new object[] {
            "Trái",
            "Phải"});
            this.cbbStyleWin.Location = new System.Drawing.Point(250, 69);
            this.cbbStyleWin.Name = "cbbStyleWin";
            this.cbbStyleWin.Size = new System.Drawing.Size(108, 25);
            this.cbbStyleWin.TabIndex = 8;
            this.cbbStyleWin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbbStyleWin.UseSelectable = true;
            this.cbbStyleWin.SelectedIndexChanged += new System.EventHandler(this.cbbStyleWin_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(97, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 15);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Chiều của các nút điều khiển: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(370, 242);
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
            this.btnOKTheme.Location = new System.Drawing.Point(197, 200);
            this.btnOKTheme.Name = "btnOKTheme";
            this.btnOKTheme.Size = new System.Drawing.Size(101, 42);
            this.btnOKTheme.TabIndex = 6;
            this.btnOKTheme.Text = "Xác nhận";
            this.btnOKTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKTheme.UseSelectable = true;
            this.btnOKTheme.Click += new System.EventHandler(this.btnOKTheme_Click);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(370, 221);
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
            this.metroRadioButton1.Location = new System.Drawing.Point(370, 200);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(105, 15);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "Chế độ tối màu";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.Visible = false;
            // 
            // multiThread
            // 
            this.multiThread.Controls.Add(this.cbOutApplication);
            this.multiThread.Controls.Add(this.groupBox1);
            this.multiThread.Controls.Add(this.btnOKMulti);
            this.multiThread.HorizontalScrollbarBarColor = true;
            this.multiThread.HorizontalScrollbarHighlightOnWheel = false;
            this.multiThread.HorizontalScrollbarSize = 10;
            this.multiThread.Location = new System.Drawing.Point(4, 38);
            this.multiThread.Name = "multiThread";
            this.multiThread.Size = new System.Drawing.Size(484, 266);
            this.multiThread.TabIndex = 3;
            this.multiThread.Text = "Đa nhiệm - Trang";
            this.multiThread.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.multiThread.VerticalScrollbarBarColor = true;
            this.multiThread.VerticalScrollbarHighlightOnWheel = false;
            this.multiThread.VerticalScrollbarSize = 10;
            // 
            // cbOutApplication
            // 
            this.cbOutApplication.AutoSize = true;
            this.cbOutApplication.Location = new System.Drawing.Point(143, 176);
            this.cbOutApplication.Name = "cbOutApplication";
            this.cbOutApplication.Size = new System.Drawing.Size(209, 15);
            this.cbOutApplication.TabIndex = 10;
            this.cbOutApplication.Text = "Cho phép truy cập ngoài ứng dụng";
            this.cbOutApplication.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOutApplication.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.cbFA);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 153);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giữ cho ứng dụng đa nhiệm";
            // 
            // cbFA
            // 
            this.cbFA.AutoSize = true;
            this.cbFA.Location = new System.Drawing.Point(18, 32);
            this.cbFA.Name = "cbFA";
            this.cbFA.Size = new System.Drawing.Size(74, 15);
            this.cbFA.TabIndex = 2;
            this.cbFA.Text = "Facebook";
            this.cbFA.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbFA.UseSelectable = true;
            // 
            // btnOKMulti
            // 
            this.btnOKMulti.Location = new System.Drawing.Point(197, 200);
            this.btnOKMulti.Name = "btnOKMulti";
            this.btnOKMulti.Size = new System.Drawing.Size(101, 42);
            this.btnOKMulti.TabIndex = 8;
            this.btnOKMulti.Text = "Xác nhận";
            this.btnOKMulti.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKMulti.UseSelectable = true;
            this.btnOKMulti.Click += new System.EventHandler(this.btnOKMulti_Click);
            // 
            // UpdateClone
            // 
            this.UpdateClone.Controls.Add(this.listBox1);
            this.UpdateClone.Controls.Add(this.btnOKUpdate);
            this.UpdateClone.Controls.Add(this.cbOffUpdate);
            this.UpdateClone.Controls.Add(this.btnUpdate);
            this.UpdateClone.HorizontalScrollbarBarColor = true;
            this.UpdateClone.HorizontalScrollbarHighlightOnWheel = false;
            this.UpdateClone.HorizontalScrollbarSize = 10;
            this.UpdateClone.Location = new System.Drawing.Point(4, 38);
            this.UpdateClone.Name = "UpdateClone";
            this.UpdateClone.Size = new System.Drawing.Size(484, 266);
            this.UpdateClone.TabIndex = 4;
            this.UpdateClone.Text = "Update Clone";
            this.UpdateClone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateClone.VerticalScrollbarBarColor = true;
            this.UpdateClone.VerticalScrollbarHighlightOnWheel = false;
            this.UpdateClone.VerticalScrollbarSize = 10;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Change Log:",
            "<Date: [5/1/2020] | [15:00]> //Thêm tính năng//",
            "</1.0.5.6/>",
            "   1) Thêm cửa sổ messenging: \"Khi đóng ứng dụng sẽ để lại biểu tượng messenger t" +
                "rên màn hình\".",
            "   2) Thêm tắt messenging khi kéo thả vào ô X.",
            "   3) Thêm cho phép tắt mở messenging trong cài đặt - giao diện.",
            "<Date: [30/12/2019] | [19:00]> //Vá lỗi - Thêm tính năng//",
            "</1.0.5.5/>",
            "   1) Sửa lỗi cài đặt khi còn ở Tab facebook.",
            "   2) Tối ưu mã hệ thống.",
            "   3) Đã thêm module hỗ trợ thêm tab cho sau này.",
            "   4) Thêm tính năng nhà phát triển trên tab facebook.",
            "   5) Fix lỗi out tab khi ấn vào deverlop tools ở tab messenger.",
            "<Date: [28/12/2019] | [11:00]> //Vá lỗi//",
            "</1.0.5.4/>",
            "   1) Thêm tính năng cho phép PIP bên dưới ứng dụng khác.",
            "   2) Tối ưu ram.",
            "   3) Thiết kế lại mã của tính năng PIP.",
            "   4) Fix một số thông báo bị ẩn.",
            "<Date: [27/12/2019] | [15:20]> //Vá lỗi//",
            "</1.0.5.3/>",
            "   1) Sửa đổi mã nguồn nhân hệ thống.",
            "   2) Thêm phím tắt crtl + D để đưa chế độ Zoom về 100%.",
            "   3) Tách chế độ Zoom của Messenger và Facebook.",
            "   4) Sửa lỗi luồn chính sử dụng quá nhiều ram.",
            "<Date: [26/12/2019] | [18:20]> //Khẩn cấp//",
            "</1.0.5.2/>",
            "   1) Fix lỗi UI hoạt động không chuẩn xác với tính năng chuyển chiều điều kiển",
            "   2) Thêm phóng to, phu nhỏ bằng dấu: +, - và crtl -, crtl =",
            "   3) Sửa lỗi notification không hoạt động chuẩn xác.",
            "<Date: [25/12/2019] | [17:50]> //Khẩn cấp//",
            "</1.0.5.1/>",
            "   1) Fix lỗi báo tin nhắn không hoạt động.",
            "   2) Thêm tùy chọn chuyển nút về bên trái - phải trong phần cài đặt.",
            "   3) Fix lỗi crash ứng dụng khi đang áp dụng cài đặt.",
            "   4) Lưu lại cài đặt ứng dụng sau khi nâng cấp.",
            "<Date: [25/12/2019] | [10:00]>",
            "</1.0.5.0/>",
            "   1) Fix lỗi crash ứng dụng khi vào cài đặt.",
            "   2) Viết lại thanh báo tin nhắn mới.",
            "   3) Ổn định lại hệ thống.",
            "   4) Hỗ trợ cho máy tính 32bit(x86).",
            "   5) Thêm nút khôi phục cài đặt gốc.",
            "<Date: [23/12/2019] | [18:10]>",
            "</1.0.4.9/>",
            "   1) Fix lỗi đa nhiệm khi sử sụng crtl + tab.",
            "   2) Thêm cho phép truy cập vào link bên ngoài ứng dụng (Trong phần cài đặt).",
            "<Date: [22/12/2019] | [15:00]>",
            "</1.0.4.8/>",
            "   1) Fix lag khi chuyển chat message.",
            "   2) Fix lỗi văng app khi không thể kết nối đến server để cập nhật.",
            "   3) Thay đổi tab cài đặt:",
            "     3.1) Thêm Tab Update Clone trong cài đặt.",
            "     3.2) Thêm cho phép tắt tự động cập nhật.",
            "     3.3) Thêm cho phép tắt chạy ngầm.",
            "     3.4) Thêm cho phép tắt thông báo nổi khi có thư đến.",
            "     3.5) Thêm luôn xuất hiện trên cùng."});
            this.listBox1.Location = new System.Drawing.Point(0, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 244);
            this.listBox1.TabIndex = 11;
            // 
            // btnOKUpdate
            // 
            this.btnOKUpdate.Location = new System.Drawing.Point(355, 173);
            this.btnOKUpdate.Name = "btnOKUpdate";
            this.btnOKUpdate.Size = new System.Drawing.Size(129, 42);
            this.btnOKUpdate.TabIndex = 10;
            this.btnOKUpdate.Text = "Xác nhận";
            this.btnOKUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOKUpdate.UseSelectable = true;
            this.btnOKUpdate.Click += new System.EventHandler(this.btnOKUpdate_Click);
            // 
            // cbOffUpdate
            // 
            this.cbOffUpdate.AutoSize = true;
            this.cbOffUpdate.Location = new System.Drawing.Point(359, 129);
            this.cbOffUpdate.Name = "cbOffUpdate";
            this.cbOffUpdate.Size = new System.Drawing.Size(116, 15);
            this.cbOffUpdate.TabIndex = 9;
            this.cbOffUpdate.Text = "Tự động cập nhật";
            this.cbOffUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbOffUpdate.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(355, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Check update";
            this.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = global::MessengerBrowser.Properties.Resources.mac_ico_close2;
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.Location = new System.Drawing.Point(492, 6);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(20, 20);
            this.pnClose.TabIndex = 2;
            this.pnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnClose_MouseClick);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 380);
            this.ControlBox = false;
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.PanelControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetting";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cài đặt";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.PanelControls.ResumeLayout(false);
            this.system.ResumeLayout(false);
            this.system.PerformLayout();
            this.pipSetting.ResumeLayout(false);
            this.pipSetting.PerformLayout();
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            this.multiThread.ResumeLayout(false);
            this.multiThread.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UpdateClone.ResumeLayout(false);
            this.UpdateClone.PerformLayout();
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
        private MetroFramework.Controls.MetroTabPage UpdateClone;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton btnOKUpdate;
        private MetroFramework.Controls.MetroCheckBox cbOffUpdate;
        private MetroFramework.Controls.MetroCheckBox cbStartup;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox cbOutApplication;
        private MetroFramework.Controls.MetroComboBox cbbStyleWin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox cbbPIPTopMost;
        private MetroFramework.Controls.MetroCheckBox cbMessenging;
    }
}