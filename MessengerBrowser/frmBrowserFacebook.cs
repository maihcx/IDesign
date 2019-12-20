using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public partial class frmBrowserFacebook : Form
    {
        public frmBrowserFacebook()
        {
            InitializeComponent();
        }

        private void frmBrowserFacebook_Load(object sender, EventArgs e)
        {
            load();
        }

        #region
        public ChromiumWebBrowser browser;
        #endregion

        public void load()
        {
            Library.int_windows = 1;
            Library.painPanels(1, Color.DarkGray);
            //Library.is_FaceOpened = true;
            //new Thread(() =>
            //{
            //    if (this.InvokeRequired)
            //    {
            //        this.BeginInvoke((MethodInvoker)delegate ()
            //        {
            //            Library.startLoading();
            //        });
            //    }
            //    else
            //    {
            //        Library.startLoading();
            //    }
            //})
            //{ IsBackground = true }.Start();
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
            browser = new ChromiumWebBrowser((string.IsNullOrEmpty(Library.str_url)) ? "http://www.facebook.com" : Library.str_url);
            browser.DownloadHandler = new DownloadHandler();
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
            browser.DisplayHandler = displayer;
            browser.KeyboardHandler = new KeyboardHandler();
            //browser.LoadingStateChanged += browser_LoadingStateChanged;

            //thload = new Thread(showfrmload);
            //thload.IsBackground = true;
            //thload.Start();
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
                Library.BrowserVisible();
                //
            }
        }

        public void ChangeUrl(string str_url)
        {
            if (!string.IsNullOrEmpty(str_url))
                browser.Load(str_url);
        }

        public void FacebookShutdow()
        {
            this.Close();
        }

        public void RestartFacebook()
        {
            browser.GetBrowser().Reload(true);
        }
    }
}
