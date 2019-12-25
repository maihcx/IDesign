using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;
using CefSharp.Internals;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Reflection;
using System.Net;
using System.IO;

namespace MessengerBrowser
{
    public partial class frmBrowserMessenger : Form
    {
        public frmBrowserMessenger()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            load();
        }

        #region
        public ChromiumWebBrowser browser;
        bool is_firstStart = false;
        #endregion

        public void load()
        {
            Library.int_windows = 0;
            Library.painPanels(0, System.Drawing.Color.DarkGray);
            new Thread(() =>
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Library.startLoading();
                    });
                }
                else
                {
                    Library.startLoading();
                }
            })
            { IsBackground = true }.Start();
            new Thread(() =>
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        loadchild();
                    });
                }
                else
                {
                    loadchild();
                }
            })
            { IsBackground = true }.Start();
        }

        private void loadchild()
        {
            DisplayHandler displayer = new DisplayHandler();
            browser = new ChromiumWebBrowser("https://www.messenger.com/t");
            browser.DownloadHandler = new DownloadHandler();
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            panel1.Controls.Add(browser);
            browser.DisplayHandler = displayer;
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            browser.LoadingStateChanged += browser_LoadingStateChanged;
            browser.MenuHandler = new MenuHandler();
            browser.RequestHandler = new RequestHandler();
            browser.KeyboardHandler = new KeyboardHandler();

        }

        public void setZoomLever(double value)
        {
            //ChromiumWebBrowser web = (ChromiumWebBrowser)sender;
            //if (!web.IsLoading)
            //{
            browser.SetZoomLevel(value);
            //}

        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (Properties.Settings.Default.FIsShowMessenger)
                {
                    Library.str_inputTitle = e.Title;
                    Library.NotificationShow();
                }
            }));
        }


        private void browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (e.IsLoading == true)
            {
                //
                //
            }
            else
            {
                //
                if (Properties.Settings.Default.FPIP)
                {
                    Library.startPIP();
                }
                if (Properties.Settings.Default.FAutoPIP)
                {
                    Library.startPIP();
                }
                Library.endLoading();
                Library.BrowserVisible();

                new Thread(new ThreadStart(() =>
                {
                    if (Properties.Settings.Default.FIsAutoUpdate)
                    {
                        if (!is_firstStart)
                        {
                            UpdateCheck();
                            is_firstStart = true;
                        }
                    }
                }))
                { IsBackground = true }.Start();
                //
            }
        }

        private void UpdateCheck()
        {
            //new Thread(() =>
            //{
            try
            {
                string thisver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                WebRequest wrsUpdate = WebRequest.Create("https://drive.google.com/uc?authuser=0&id=1Sr_CrZB6dEZVGjLx3KxAUvQzclwDsxGh&export=download");
                // 64bit: https://drive.google.com/uc?authuser=0&id=1Sr_CrZB6dEZVGjLx3KxAUvQzclwDsxGh&export=download
                // 32bit: https://drive.google.com/uc?authuser=0&id=1o1hX4BK6CU4TXkGefdaTyvVUMHHpwQCI&export=download
                // test: https://drive.google.com/uc?authuser=0&id=1hTH1a6sc0YitvYVbWZZBpqD61AUWZFqC&export=download
                WebResponse wrpUpdate = wrsUpdate.GetResponse();
                StreamReader srdUpdate = new StreamReader(wrpUpdate.GetResponseStream());

                string response = srdUpdate.ReadToEnd();
                var reponseStr = response.Split('\n');
                string newver = reponseStr[0].Trim();

                if (thisver != newver)
                {
                    if (Library.MessengerMain("Đã phát hiện cập nhật mới, Bạn có muốn cập nhật ?\nNew version: " + newver + " your curent version: " + thisver, "Update..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmUpdateDownload frmupdate = new frmUpdateDownload();
                        frmupdate.ShowDialog();
                    }
                }
            }
            catch
            {
                Library.MessengerMain("Có lỗi xảy ra khi kết nối đến server, vui lòng thử lại sau !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //})
            //{ IsBackground = false }.Start();
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            //this.Invoke(new MethodInvoker(() =>
            //{
            //    //Text = e.Address;
            //    //if (!(Text.Contains("checkpoint") || Text.Contains("messages") || Library.str_inputTitle.Contains("Đăng nhập")))
            //    //{
            //    //    browser.Load("https://www.messenger.com/t");
            //    //}
            //}));
            this.Invoke(new MethodInvoker(() =>
            {
                Text = e.Address;
                //MessageBox.Show(Text);
                if (!(Text.Contains("messenger.com")) && Properties.Settings.Default.FIsOutApplication)
                {
                    System.Diagnostics.Process.Start(Text);
                    browser.Back();
                }
                //browser.Forward();

            }));
        }

        public void ReloadWeb()
        {
            browser.Load("https://www.messenger.com/t");
        }

        public void RestartMessenger()
        {
            if (Library.is_PIP)
                Library.stopPIP();
            browser.GetBrowser().Reload(true);
        }
    }
}
