using CefSharp;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading;
using System.Windows.Forms;
using BlueformFramework;
using System.Drawing;
using AeroLibrary;
using System.Drawing.Drawing2D;

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
            //cropElipPanel();
            checkIntStyleWinform();
            //Properties.Settings.Default.Reset();
            SaveSettingForm.IntializeForm(this);

            blureForm.SetLocations = this.Location;
            blureForm.SetSize = this.Size;
            blureForm.Intialization();
            Aero.EnableAcrylic(blureForm.frmBlueGone, Color.Transparent);

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
            disableAllPanel();
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

        private void cropElipPanel()
        {
            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 19, 19); //Add hình elip vào GraphicsPath
            pnClose.Region = new Region(p);
            pnClose1.Region = new Region(p);
            pnMaximize.Region = new Region(p);
            pnMaximize1.Region = new Region(p);
            p.Dispose();
        }

        private void disableAllPanel()
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
                        if (Library.is_Messenging_Start)
                        {
                            Library.Show_Close_PoupupMessenging(false);
                        }
                        try
                        {
                            if (this.InvokeRequired)
                            {
                                this.BeginInvoke((MethodInvoker)delegate ()
                                {
                                    frmClose();
                                    SaveSettingForm.SaveForm(this);
                                });
                            }
                            else
                            {
                                frmClose();
                                SaveSettingForm.SaveForm(this);
                            }
                        }
                        catch
                        {
                            Cef.Shutdown();
                            e.Cancel = false;
                        }
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
            Library.Show_Close_PoupupMessenging(true);
        }

        private void frmShow()
        {
            this.Opacity = 0;
            this.Show();

            BlueformFrameworkUse.Show(this, 10);
            Library.str_TextShow = string.Empty;
            Library.str_input_save = string.Empty;
            Library.is_openedwindows = true;
            Library.Show_Close_PoupupMessenging(false);
        }

        private void frmClose()
        {
            try
            {
                this.Show();
                for (double i = 1; i > .0; i -= 0.10)
                {
                    Thread.Sleep(20);
                    this.Opacity = i;
                }
                Application.ExitThread();
                Application.Exit();
                Cef.Shutdown();
            }
            catch
            {
                Application.ExitThread();
                Application.Exit();
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
            if (Library.int_windows != 1)
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
            disableAllPanel();

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
            foreach (Control crt in this.Controls)
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
            if (Library.int_windows != 0)
            {
                changeBrowserControl(0, string.Empty);
            }
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
                    Library.int_windows = 0;
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
                    painPanels(0, Color.DarkGray);
                    break;
                case 1:
                    Library.int_windows = 1;
                    hidebrowser(frmmes);
                    Library.str_url = str_url;
                    frmface.TopLevel = false;
                    frmface.Dock = DockStyle.Fill;

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
                    painPanels(1, Color.DarkGray);
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
        System.Windows.Forms.Timer tmrunPIP = new System.Windows.Forms.Timer();
        public void startPIP()
        {
            //BlueformFrameworkUse.Hide(this, 10);
            if (WindowState == FormWindowState.Maximized)
            {
                winstate = true;
                this.WindowState = FormWindowState.Normal;
            }
            PanelMain.Visible = false;
            Library.is_PIP = true;
            is_resize = false;
            Library.setZoomLeverMS(-1.3);
            showPanels(false);
            this.Width = Library.PIPWidth;
            this.Height = Library.PIPHeight;
            PanelMain.Width = Library.PIPPanelWidth; PanelMain.Height = Library.PIPPanelHeight;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = Properties.Settings.Default.FIsPIPTopMost;

            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            PanelMain.Location = Properties.Settings.Default.FPIPPanelLocation;
            this.Hide();
            int i_run = 0;
            tmrunPIP.Stop();
            tmrunPIP = new System.Windows.Forms.Timer();
            tmrunPIP.Interval = 200;
            tmrunPIP.Tick += new EventHandler((object obj, EventArgs e) =>
            {
                i_run++;
                if (i_run <= 1)
                {
                    tmrunPIP.Stop();
                    PanelMain.Visible = true;
                    BlueformFrameworkUse.Show(this, 10);
                }
            });
            tmrunPIP.Start();
        }

        public void stopPIP()
        {
            tmrunPIP.Stop();
            Library.is_PIP = false;

            PanelMain.Visible = false;
            Library.setZoomLeverMS(Library.dou_zoomvalueMS);
            this.Width = Library.int_formWidth;
            this.Height = Library.int_formHeight;
            showPanels(true);
            PanelMain.Width = Library.int_controlWidth; PanelMain.Height = Library.int_controlHeight;
            PanelMain.Location = new System.Drawing.Point(Library.int_controlLocationX, Library.int_controlLocationY);

            this.Location = new Point(Library.int_formLocationX, Library.int_formLocationY);
            this.TopMost = Properties.Settings.Default.FIsShowTop;
            is_resize = true;

            Properties.Settings.Default.FPIP = false;
            Properties.Settings.Default.Save();
            this.Hide();
            if (winstate)
            {
                WindowState = FormWindowState.Maximized;
                winstate = false;
            }

            int i_run = 0;
            tmrunPIP.Stop();
            tmrunPIP = new System.Windows.Forms.Timer();
            tmrunPIP.Interval = 200;
            tmrunPIP.Tick += new EventHandler((object obj, EventArgs e) =>
            {
                i_run++;
                if (i_run <= 1)
                {
                    tmrunPIP.Stop();
                    PanelMain.Visible = true;
                    BlueformFrameworkUse.Show(this, 10);
                }
            });
            tmrunPIP.Start();
        }

        public void previewPIPSize(int width, int height)
        {
            if (Library.int_windows != 0)
            {
                changeBrowserControl(0, string.Empty);
            }
            if (!Library.is_PIP)
                startPIP();
            this.Height = height;
            this.Width = width;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            Library.PIPPanelWidth = PanelMain.Width;
            Library.PIPPanelHeight = PanelMain.Height;
            Library.PIPPanelLocation = PanelMain.Location;
        }


        public void previewPIPPanelSize(int width, int height)
        {
            if (Library.int_windows != 0)
            {
                changeBrowserControl(0, string.Empty);
            }
            if (!Library.is_PIP)
                startPIP();
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
            tm.Stop();
            KeysConverter converter = new KeysConverter();
            string str_key = converter.ConvertToString(icontrolkey);
            string str_show = "";
            switch (icontrolkey)
            {
                case -3:
                    str_show = "Kích thước: " + (1 + ((Library.int_windows == 0) ? Library.dou_zoomvalueMS : Library.dou_zoomvalueFA)).ToString("#0.##%");
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
            disableAllPanel();
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

        public void focursMainForm()
        {
            this.Focus();
        }

        public void endAero()
        {
            Aero.DisabledAcrylic(blureForm.frmBlueGone);
            blureForm.DisponseForm();
        }
    }

    public class blureForm : Form
    {
        public static Form frmBlueGone;
        public static System.Drawing.Size SetSize;
        public static System.Drawing.Point SetLocations;
        public static void Intialization()
        {
            frmBlueGone = new Form();
            frmBlueGone.BackColor = frmBlueGone.TransparencyKey = Properties.Settings.Default.FColorControls;
            frmBlueGone.TopMost = true;
            frmBlueGone.StartPosition = FormStartPosition.Manual;
            frmBlueGone.FormBorderStyle = FormBorderStyle.None;
            frmBlueGone.Size = SetSize;
            frmBlueGone.Location = SetLocations;
            frmBlueGone.ShowIcon = false;
            frmBlueGone.ShowInTaskbar = false;
            //SaveSettingForm.IntializeForm(frmBlueGone);
            frmBlueGone.Show();
        }

        public static void DisponseForm()
        {
            frmBlueGone.Close();
            frmBlueGone.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
