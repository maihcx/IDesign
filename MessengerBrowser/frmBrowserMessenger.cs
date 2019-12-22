﻿using CefSharp;
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
            //browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            browser.LoadingStateChanged += browser_LoadingStateChanged;
            browser.MenuHandler = new MenuHandler();
            browser.RequestHandler = new RequestHandler();
            browser.KeyboardHandler = new KeyboardHandler();


            //browser
            //thload = new Thread(showfrmload);
            //thload.IsBackground = true;
            //thload.Start();

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
                Library.str_inputTitle = e.Title;
                Library.NotificationShow();
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

                //new Thread(new ThreadStart(() => {
                if (!is_firstStart)
                {
                    UpdateCheck();
                    is_firstStart = true;
                }
                //})) { IsBackground = true }.Start();
                //
            }
        }

        private void UpdateCheck()
        {
            string thisver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            WebRequest wrsUpdate = WebRequest.Create("https://drive.google.com/uc?authuser=0&id=1Sr_CrZB6dEZVGjLx3KxAUvQzclwDsxGh&export=download");
            WebResponse wrpUpdate = wrsUpdate.GetResponse();
            StreamReader srdUpdate = new StreamReader(wrpUpdate.GetResponseStream());

            string response = srdUpdate.ReadToEnd();
            var reponseStr = response.Split('\n');
            string newver = reponseStr[0].Trim();

            if (thisver != newver)
            {
                if (MetroMessageBox.Show(this, "Đã phát hiện cập nhật mới, Bạn có muốn cập nhật ?\nNew version: " + newver + " your curent version: " + thisver, "Update..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //new Thread(() =>
                    //{
                    frmUpdateDownload frmupdate = new frmUpdateDownload();
                    frmupdate.Show();
                    //})
                    //{ IsBackground = false }.Start();
                }
            }
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
