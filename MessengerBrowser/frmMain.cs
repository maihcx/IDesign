using CefSharp;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;
using BlueformFramework;
using System.Drawing;
using System.Reflection;
using System.Net;
using System.IO;

namespace MessengerBrowser
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            // Create a material theme manager and add the form to manage (this)
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue50, Primary.Brown600,
            //    Primary.Blue500, Accent.LightBlue200,
            //    TextShade.WHITE
            //);
        }

        bool isNotExit = true;
        static bool StateWindow = true;
        bool is_showicontray = false;
        bool is_resize = true;
        frmBrowserMessenger frmmes = new frmBrowserMessenger();
        frmBrowserFacebook frmface = new frmBrowserFacebook();
        System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
        bool winstate = false;
        bool isEndProcess = false;

        private void frmMain_Load(object sender, EventArgs e)
        {
            checkIntStyleWinform();
            //Properties.Settings.Default.Reset();
            SaveSettingForm.IntializeForm(this);

            //pnAutoPIP.BackgroundImage = (Properties.Settings.Default.FAutoPIP) ? Properties.Resources.done_red : Properties.Resources.done;
            if (Properties.Settings.Default.FAutoPIP)
            {
                pnAutoPIP.BackgroundImage = Properties.Resources.done_red;
                pnDF.BackColor = Color.IndianRed;
            }
            else
            {
                pnAutoPIP.BackgroundImage = Properties.Resources.done;
                pnDF.BackColor = Color.MediumSeaGreen;
            }

            toolTipText();

            Library.is_openedwindows = true;

            this.TopMost = Properties.Settings.Default.FIsShowTop;

            frmShow();

            if (!is_showicontray)
            {
                is_showicontray = true;
                frmIconTray frmicon = new frmIconTray();
                frmicon.Show();
            }

            Thread thload = new Thread(new ThreadStart((() =>
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        load();
                    });
                }
                else
                {
                    load();
                }
            })));
            thload.Start();
        }

        private void checkIntStyleWinform()
        {
            disebleAllPanel();
            switch (Properties.Settings.Default.FIntWinStyle)
            {
                case 0:
                    pnClose.Visible = true;
                    pnMaximize.Visible = true;
                    pnEndprocess.Visible = true;
                    pngrMSFA.Visible = true;
                    break;
                case 1:
                    pnClose1.Visible = true;
                    pnEndprocess1.Visible = true;
                    pnMaximize1.Visible = true;
                    pngrMSFA_1.Visible = true;
                    break;
            }
        }

        private void disebleAllPanel()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    foreach (Control crt in frm.Controls)
                    {
                        if (crt is Panel)
                        {
                            if (crt.Name != "pnDF" && crt.Name != "PanelMain" && crt.Name != "pnAutoPIP" && crt.Name != "pnReset" && crt.Name != "pnPIP")
                                crt.Visible = false;
                        }
                    }
                }
            }
        }

        private void load()
        {
            this.TopLevel = true;
            changeBrowserControl(0, string.Empty);
        }

        private void toolTipText()
        {
            ToolTip textTool = new ToolTip();
            textTool.ShowAlways = true;
            textTool.SetToolTip(pnAutoPIP, "Tự động P-I-P");
            textTool.SetToolTip(pnClose, "Đóng giao diện(Vẫn chạy ngầm)");
            textTool.SetToolTip(pnMaximize, "Phóng to/Thu Nhỏ/Tắt PIP");
            textTool.SetToolTip(pnEndprocess, "Đóng hoàn toàn chương trình");
            textTool.SetToolTip(pnMess, "Truy cập nhanh vào Messenger");
            textTool.SetToolTip(pnFA, "Truy cập nhanh vào Facebook");
            textTool.SetToolTip(pnReset, "Khôi phục cài đặt gốc");
            textTool.SetToolTip(pnClose1, "Đóng giao diện(Vẫn chạy ngầm)");
            textTool.SetToolTip(pnMaximize1, "Phóng to/Thu Nhỏ/Tắt PIP");
            textTool.SetToolTip(pnEndprocess1, "Đóng hoàn toàn chương trình");
            textTool.SetToolTip(pnMess1, "Truy cập nhanh vào Messenger");
            textTool.SetToolTip(pnFA1, "Truy cập nhanh vào Facebook");
        }

        private void pnMess_Click(object sender, EventArgs e)
        {
            Library.int_windows = 0;
            painPanels(0, Color.DarkGray);
            changeBrowserControl(0, string.Empty);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isEndProcess && Properties.Settings.Default.FIsRunbackground)
            {
                if (isNotExit)
                {
                    e.Cancel = isNotExit;
                    frmHide();
                }
                else
                {
                    if (MetroMessageBox.Show(this, "Bạn có muốn thoát ?", "Alert !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SaveSettingForm.SaveForm(this);
                        frmClose();
                    }
                    else
                    {
                        isNotExit = true;
                        e.Cancel = true;
                    }
                }
            }
        }

        private void exitMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNotExit = false;
            this.Close();
        }

        private void ntfCT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (checkTrue_False())
                {
                    frmShow();
                    StateWindow = true;
                }
                else
                {
                    frmHide();
                }
            }
        }

        private bool checkTrue_False()
        {
            return Library.is_openedwindows = !Library.is_openedwindows;
        }

        private void frmHide()
        {
            BlueformFrameworkUse.Hide(this, 10);
            StateWindow = false;
            Library.is_openedwindows = false;
            Library.str_input_save = string.Empty;
        }

        private void frmShow()
        {
            this.Opacity = 0;
            this.Show();

            BlueformFrameworkUse.Show(this, 10);
            Library.str_TextShow = string.Empty;
            Library.str_input_save = string.Empty;
            Library.is_openedwindows = true;
        }

        private void frmClose()
        {
            try
            {
                this.Show();
                for (double i = 1; i > .0; i -= 0.03)
                {
                    Thread.Sleep(1);
                    this.Opacity = i;
                }
                Cef.Shutdown();
            }
            catch
            {
                Application.ExitThread();
            }

        }

        private void hidebrowser(Form form_input)
        {
            PanelMain.Controls.Remove(form_input);
            if (!Properties.Settings.Default.FEnableFA)
            {
                frmface = new frmBrowserFacebook();
                Library.FacebookCefShutdow();
            }
        }

        private void pnFA_MouseClick(object sender, MouseEventArgs e)
        {
            Library.int_windows = 1;
            painPanels(1, Color.DarkGray);
            changeBrowserControl(1, string.Empty);
        }

        private void pnPIP_Click(object sender, EventArgs e)
        {
            if (Library.int_windows == 0)
            {
                startPIP();
            }
        }

        private void showPanels(bool k)
        {
            disebleAllPanel();

            pnPIP.Visible = k;
            pnDF.Visible = k;
            pnAutoPIP.Visible = k;
            pnReset.Visible = k;

            switch (Properties.Settings.Default.FIntWinStyle)
            {
                case 0:
                    pnClose.Visible = true;
                    pnMaximize.Visible = true;
                    pnEndprocess.Visible = k;
                    pngrMSFA.Visible = k;
                    break;
                case 1:
                    pnClose1.Visible = true;
                    pnMaximize1.Visible = true;
                    pnEndprocess1.Visible = k;
                    pngrMSFA_1.Visible = k;
                    break;
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (is_resize && WindowState == FormWindowState.Normal)
            {
                Library.int_formWidth = this.Width;
                Library.int_formHeight = this.Height;
                Library.int_formLocationX = this.Location.X;
                Library.int_formLocationY = this.Location.Y;

                Library.int_controlWidth = PanelMain.Width;
                Library.int_controlHeight = PanelMain.Height;
                Library.int_controlLocationX = PanelMain.Location.X;
                Library.int_controlLocationY = PanelMain.Location.Y;
            }
        }

        private void frmMain_Move(object sender, EventArgs e)
        {
            if (is_resize)
            {
                Library.int_formLocationX = this.Location.X;
                Library.int_formLocationY = this.Location.Y;
            }
        }

        private void pnClose_MouseHover(object sender, EventArgs e)
        {
            pnClose.BackgroundImage = Properties.Resources.mac_ico_close2;
        }

        private void pnClose_MouseLeave(object sender, EventArgs e)
        {
            pnClose.BackgroundImage = Properties.Resources.mac_ico_close1;
        }

        private void pnMaximize_MouseHover(object sender, EventArgs e)
        {
            pnMaximize.BackgroundImage = Properties.Resources.icon_mac_maximize2;
        }

        private void pnMaximize_MouseLeave(object sender, EventArgs e)
        {
            pnMaximize.BackgroundImage = Properties.Resources.icon_mac_maximize1;
        }

        private void pnClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Close();
        }

        private void pnMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Library.is_PIP)
                {
                    stopPIP();
                }
                else
                {
                    this.WindowState = (this.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;

                }
            }
        }

        private void pbEndprocess_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isNotExit = false;
                this.Close();
            }
        }

        private void defaultColorTabmenu()
        {
            foreach (Form frm in Application.OpenForms)
                if (frm is frmMain)
                    foreach (Control crt in frm.Controls)
                        if (crt is Panel)
                            if (crt.Name == "pngrMSFA" || crt.Name == "pngrMSFA_1")
                                foreach (Control crtc in crt.Controls)
                                    if (crtc is Panel)
                                        crtc.BackColor = Color.Transparent;
        }

        public void PanelCanVisible() => PanelMain.Visible = true;

        public void ShowOfHideMain()
        {
            if (checkTrue_False())
            {
                frmShow();
                StateWindow = true;
            }
            else
            {
                frmHide();
            }
        }

        public void balloonClosed()
        {
            if (StateWindow)
            {
                Library.str_TextShow = string.Empty;
            }
        }

        public void balloonShown()
        {
            StateWindow = false;
        }

        public void balloonClicked()
        {
            frmShow();
            Library.str_TextShow = string.Empty;
            Library.str_input_save = string.Empty;
        }

        public void hideMain_PIP()
        {
            BlueformFrameworkUse.Hide(this, 10);
            StateWindow = false;
            Library.is_openedwindows = false;
        }

        public void showMain_PIP()
        {
            this.Opacity = 0;
            this.Show();

            BlueformFrameworkUse.Show(this, 10);
            Library.str_TextShow = string.Empty;
        }

        public DialogResult MessengerMain(string strtext, string strtitle, MessageBoxButtons button, MessageBoxIcon icon)
        {
            //MetroMessageBox.Show(this,"Hệ thống đang trong quá trình phát triển, vì vậy có một số tính năng không ổn định, vui lòng đợi bản cập nhật trong tương lai", "Messenging", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return MetroMessageBox.Show(this, strtext, strtitle, button, icon);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Library.Reload();
        }

        public void EndMain()
        {
            isNotExit = false;
            this.Close();
        }

        public void changeBrowserControl(int int_inputNumIcon, string str_url)
        {
            switch (int_inputNumIcon)
            {
                case 0:
                    Library.EndFace = false;
                    hidebrowser(frmface);
                    Library.str_url = string.Empty;
                    frmmes.TopLevel = false;
                    frmmes.Dock = DockStyle.Fill;
                    this.Invoke((MethodInvoker)delegate
                    {
                        //perform on the UI thread
                        PanelMain.Controls.Add(frmmes);
                    });
                    frmmes.Show();
                    break;
                case 1:
                    hidebrowser(frmmes);

                    Library.str_url = str_url;
                    frmface.TopLevel = false;
                    frmface.Dock = DockStyle.Fill;
                    //if (Library.is_FaceOpened)
                    //{
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            try
                            {
                                PanelMain.Controls.Add(frmface);
                                frmface.Show();
                                if (!string.IsNullOrEmpty(str_url))
                                {
                                    Library.ChangeUrlFace(str_url);
                                }
                            }
                            catch
                            {
                                frmface.Close();
                                frmface = new frmBrowserFacebook();
                                frmface.TopLevel = false;
                                frmface.Dock = DockStyle.Fill;
                                PanelMain.Controls.Add(frmface);
                                frmface.Show();
                            }
                        });
                    }
                    else
                    {
                        try
                        {
                            PanelMain.Controls.Add(frmface);
                            frmface.Show();
                            if (!string.IsNullOrEmpty(str_url))
                            {
                                Library.ChangeUrlFace(str_url);
                            }
                        }
                        catch
                        {
                            frmface.Close();
                            frmface = new frmBrowserFacebook();
                            frmface.TopLevel = false;
                            frmface.Dock = DockStyle.Fill;
                            PanelMain.Controls.Add(frmface);
                            frmface.Show();
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void pnAutoPIP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Properties.Settings.Default.FAutoPIP = !Properties.Settings.Default.FAutoPIP;
                Properties.Settings.Default.Save();

                //pnAutoPIP.BackgroundImage = (Properties.Settings.Default.FAutoPIP) ? Properties.Resources.done_red : Properties.Resources.done;

                if (Properties.Settings.Default.FAutoPIP)
                {
                    pnAutoPIP.BackgroundImage = Properties.Resources.done_red;
                    pnDF.BackColor = Color.IndianRed;
                }
                else
                {
                    pnAutoPIP.BackgroundImage = Properties.Resources.done;
                    pnDF.BackColor = Color.MediumSeaGreen;
                }
            }
        }

        public void startPIP()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                winstate = true;
                this.WindowState = FormWindowState.Normal;
            }
            Library.is_PIP = true;
            is_resize = false;
            //BlueformFrameworkUse.Hide(this, 10);
            BlueformFrameworkUse.Hide(this, 10);
            //PanelMain.Visible = false;

            Library.setZoomLever(-1.3);
            this.Width = Library.PIPWidth;
            this.Height = Library.PIPHeight;
            showPanels(false);
            //PanelMain.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            PanelMain.Width = Library.PIPPanelWidth; PanelMain.Height = Library.PIPPanelHeight;
            PanelMain.Location = Properties.Settings.Default.FPIPPanelLocation;

            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.TopMost = true;
            //Thread.Sleep(1000);
            //BlueformFrameworkUse.Hide(this, 10);
            //Thread.Sleep(100);
            BlueformFrameworkUse.Show(this, 10);
            //PanelMain.Visible = true;
        }

        public void stopPIP()
        {
            Library.is_PIP = false;
            BlueformFrameworkUse.Hide(this, 10);
            //Thread.Sleep(300);
            Library.setZoomLever(0);
            this.Width = Library.int_formWidth;
            this.Height = Library.int_formHeight;
            showPanels(true);
            //PanelMain.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            PanelMain.Width = Library.int_controlWidth; PanelMain.Height = Library.int_controlHeight;
            PanelMain.Location = new System.Drawing.Point(Library.int_controlLocationX, Library.int_controlLocationY);

            this.Location = new Point(Library.int_formLocationX, Library.int_formLocationY);
            this.TopMost = Properties.Settings.Default.FIsShowTop;
            is_resize = true;
            //Thread.Sleep(100);
            BlueformFrameworkUse.Show(this, 10);
            Properties.Settings.Default.FPIP = false;
            Properties.Settings.Default.Save();

            if (winstate)
            {
                WindowState = FormWindowState.Maximized;
                winstate = false;
            }
            //this.Show();

        }
        int PENWIDTH = 0, PENHEIGHT = 0;
        int PENX = 0, PENY = 0;
        public void previewPIPSize(int width, int height)
        {
            if (!Library.is_PIP)
                startPIP();
            this.Height = height;
            this.Width = width;
            //PanelMain.Location = new System.Drawing.Point(Library.int_controlLocationX, Library.int_controlLocationY);
            //int x = Properties.Settings.Default.FPIPPanelLocation.X;
            //int y = Properties.Settings.Default.FPIPPanelLocation.Y;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            Library.PIPPanelWidth = PENWIDTH = PanelMain.Width;
            Library.PIPPanelHeight = PENHEIGHT = PanelMain.Height;
            Library.PIPPanelLocation = PanelMain.Location;
            PENX = PanelMain.Location.X;
            PENY = PanelMain.Location.Y;
            //PanelMain.Location = new System.Drawing.Point(x, y);
        }


        public void previewPIPPanelSize(int width, int height)
        {
            //MessageBox.Show(PENX.ToString());
            if (!Library.is_PIP)
                startPIP();
            //Library.PIPPanelWidth = PanelMain.Width = width;
            //Library.PIPPanelHeight = PanelMain.Height = height;
            //PanelMain.Location = new System.Drawing.Point(Library.int_controlLocationX, Library.int_controlLocationY);
            //this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            //int int_WIDTH = (PENWIDTH == 0) ? Properties.Settings.Default.FPIPPanelWidth : PENWIDTH;
            //int int_HEIGHT = (PENHEIGHT == 0) ? Properties.Settings.Default.FPIPPanelHeight : PENHEIGHT;
            //int int_X = (PENX == 0) ? Library.PIPPanelLocation.X : PENX;
            //int int_y = (PENY == 0) ? Library.PIPPanelLocation.Y : PENY;
            //int x = Properties.Settings.Default.FPIPPanelLocation.X;
            //int y = Properties.Settings.Default.FPIPPanelLocation.Y;
            //MessageBox.Show((Library.PIPPanelHeight - (Library.PIPPanelHeight - height)).ToString());
            PanelMain.Height = (PanelMain.Height - height);
            PanelMain.Location = new Point(PanelMain.Location.X, PanelMain.Location.Y + ((Library.PIPPanelHeight - (Library.PIPPanelHeight - height))));
            Library.PIPPanelLocation = PanelMain.Location;
            Library.PIPPanelHeight = PanelMain.Height;
        }

        public void visibleMain(bool is_show)
        {
            this.Visible = is_show;
        }

        public void SendHostKey(int icontrolkey)
        {
            //if (icontrolkey != 0)
            //{
            tm.Stop();
            KeysConverter converter = new KeysConverter();
            string str_key = converter.ConvertToString(icontrolkey);
            string str_show = "";
            switch (icontrolkey)
            {
                case -3:
                    str_show = "Kích thước: " + (1 + Library.dou_zoomvalue).ToString("#0.##%");
                    break;
                case -2:
                    str_show = "Jum Tab Facebook";
                    break;
                case -1:
                    str_show = "Jum Tab Messenger";
                    break;
                case 0:
                    str_show = "Start/Stop PIP";
                    break;
                default:
                    str_show = "Key hover: " + str_key;
                    break;
            }
            lblhostkey.Text = str_show;
            int it = 0;
            tm = new System.Windows.Forms.Timer();
            tm.Interval = 1000;
            tm.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                if (it >= 1)
                {
                    lblhostkey.Text = "";
                    tm.Stop();
                }
                it++;
            });
            tm.Start();
            //}
        }

        public void painPanels(int int_panelwindows, Color colorOfPanelTab)
        {
            defaultColorTabmenu();
            switch (int_panelwindows)
            {
                case 0:
                    pnMess.BackColor = colorOfPanelTab;
                    pnMess1.BackColor = colorOfPanelTab;
                    break;
                case 1:
                    pnFA.BackColor = colorOfPanelTab;
                    pnFA1.BackColor = colorOfPanelTab;
                    break;
            }
        }

        private void pnReset_MouseClick(object sender, MouseEventArgs e)
        {
            if (MetroMessageBox.Show(this, "Khi hệ thống gặp lỗi, bạn nên khôi phục bằng tùy chọn này.\nBạn có muốn tiếp tục ? Việc này sẽ khôi phục lại toàn bộ cài đặt của bạn !", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Application.ExitThread();
                Application.Restart();
            }
        }

        public void EndProgram()
        {
            isEndProcess = true;
            this.Close();
            Application.ExitThread();
        }

        public void RunTopMost(bool istop)
        {
            this.TopMost = istop;
        }

        public void previewWindowsStyle(int int_style)
        {
            disebleAllPanel();
            switch (int_style)
            {
                case 0:

                    if (Library.is_PIP)
                    {
                        pnClose.Visible = true;
                        pnMaximize.Visible = true;
                    }
                    else
                    {
                        pnClose.Visible = true;
                        pnMaximize.Visible = true;
                        pnEndprocess.Visible = true;
                        pngrMSFA.Visible = true;
                    }
                    break;
                case 1:
                    if (Library.is_PIP)
                    {
                        pnClose1.Visible = true;
                        pnMaximize1.Visible = true;
                    }
                    else
                    {
                        pnClose1.Visible = true;
                        pnEndprocess1.Visible = true;
                        pnMaximize1.Visible = true;
                        pngrMSFA_1.Visible = true;
                    }
                    break;
            }
        }
    }
}
