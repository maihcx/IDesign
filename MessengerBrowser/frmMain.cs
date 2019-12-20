using CefSharp;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;
using BlueformFramework;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;

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

        private void frmMain_Load(object sender, EventArgs e)
        {
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

            frmShow();

            if (!is_showicontray)
            {
                is_showicontray = true;
                frmIconTray frmicon = new frmIconTray();
                frmicon.Show();
            }

            new Thread(() =>
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
            })
            { IsBackground = true }.Start();
        }

        private void load()
        {
            this.TopLevel = true;
            changeControlIcon(0, string.Empty);
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
        }

        public void PanelCanVisible() => PanelMain.Visible = true;

        private void pnMess_Click(object sender, EventArgs e)
        {
            Library.int_windows = 0;
            painPanels(0, Color.DarkGray);
            changeControlIcon(0, string.Empty);
            //if (MetroMessageBox.Show(this, "Bạn có chắc muốn xóa ?\nViệc này sẽ xóa mọi mật khẩu đã lưu và sẽ tắt trình duyệt này, bạn có chắc muốn thực hiện ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    Cef.GetGlobalCookieManager().DeleteCookies("", "");
            //    Application.Exit();
            //}
        }

        public void ShowNotification(string str_Text)
        {
            Library.showNotification("Messenger", str_Text, 2000);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            frmShow();
            Library.str_TextShow = string.Empty;
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

        private void ntfCT_BalloonTipClosed(object sender, EventArgs e)
        {
            if (StateWindow)
            {
                Library.str_TextShow = string.Empty;
            }
        }

        private void ntfCT_BalloonTipShown(object sender, EventArgs e)
        {
            StateWindow = false;
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
        }

        public void hideMain_PIP()
        {
            BlueformFrameworkUse.Hide(this, 10);
            StateWindow = false;
            Library.is_openedwindows = false;
        }

        private void frmHide()
        {
            BlueformFrameworkUse.Hide(this, 10);
            StateWindow = false;
            Library.is_openedwindows = false;
        }

        private void frmShow()
        {
            this.Opacity = 0;
            this.Show();

            BlueformFrameworkUse.Show(this, 10);
            Library.str_TextShow = string.Empty;
            Library.is_openedwindows = true;
        }

        public void showMain_PIP()
        {
            this.Opacity = 0;
            this.Show();

            BlueformFrameworkUse.Show(this, 10);
            Library.str_TextShow = string.Empty;
        }

        private void frmClose()
        {
            this.Show();
            for (double i = 1; i > .0; i -= 0.03)
            {
                Thread.Sleep(1);
                this.Opacity = i;
            }
            Cef.Shutdown();
        }

        public void MessengerFirs()
        {
            //MetroMessageBox.Show(this,"Hệ thống đang trong quá trình phát triển, vì vậy có một số tính năng không ổn định, vui lòng đợi bản cập nhật trong tương lai", "Messenging", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void changeControlIcon(int int_inputNumIcon, string str_url)
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
            changeControlIcon(1, string.Empty);
        }

        private void pnPIP_Click(object sender, EventArgs e)
        {
            //Library.is_PIP = true;

            //Library.hideMain_PIP();
            //Library.frm.Show();
            //Library.frm = new frmPictureInPicture();
            if (Library.int_windows == 0)
            {
                startPIP();
            }
        }

        private void showPanels(bool k)
        {
            pnMess.Visible = k;
            pnFA.Visible = k;
            pnPIP.Visible = k;
            pnDF.Visible = k;
            pnEndprocess.Visible = k;
            pnAutoPIP.Visible = k;
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
            this.Hide();
            this.Width = Library.PIPWidth;
            this.Height = Library.PIPHeight;
            showPanels(false);
            //PanelMain.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            PanelMain.Width = Library.PIPPanelWidth; PanelMain.Height = Library.PIPPanelHeight;
            PanelMain.Location = new System.Drawing.Point(-70, -45);

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
            this.TopMost = false;
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

        public void previewPIPSize(int width, int height)
        {
            if (!Library.is_PIP)
                startPIP();
            this.Height = height;
            this.Width = width;
            Library.PIPPanelWidth = PanelMain.Width;
            Library.PIPPanelHeight = PanelMain.Height;
            //PanelMain.Location = new System.Drawing.Point(Library.int_controlLocationX, Library.int_controlLocationY);
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
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

        public void painPanels(int int_panelwindows, Color colorOfPanelTab)
        {
            defaultColorTabmenu();
            switch (int_panelwindows)
            {
                case 0:
                    pnMess.BackColor = colorOfPanelTab;
                    break;
                case 1:
                    pnFA.BackColor = colorOfPanelTab;
                    break;
            }
        }

        private void defaultColorTabmenu()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    foreach (Control crt in frm.Controls)
                    {
                        if (crt is Panel)
                        {
                            if (crt.Name != "pnDF")
                                crt.BackColor = Color.Transparent;
                        }
                    }
                }
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
    }
}
