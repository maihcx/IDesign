using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public partial class frmPictureInPicture : Form
    {
        public frmPictureInPicture()
        {
            InitializeComponent();
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }
        public ChromiumWebBrowser browser;
        private void frmPictureInPicture_Load(object sender, EventArgs e)
        {
            loadchild();
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
            //browser.TitleChanged += Browser_TitleChanged;
            //browser.LoadingStateChanged += browser_LoadingStateChanged;
            browser.MenuHandler = new MenuHandler();
            browser.RequestHandler = new RequestHandler();
            browser.KeyboardHandler = new KeyboardHandler();
            //browser.MouseClick += Click;
            //browser.KeyUp += Browser_KeyUp;

            //browser
            //thload = new Thread(showfrmload);
            //thload.IsBackground = true;
            //thload.Start();
            //browser.LoadingStateChanged += WebBrowserOnLoadingStateChanged;
        }
        private void WebBrowserOnLoadingStateChanged(object sender, LoadingStateChangedEventArgs loadingStateChangedEventArgs)
        {
            ChromiumWebBrowser web = (ChromiumWebBrowser)sender;
            if (!web.IsLoading)
            {
                web.SetZoomLevel(-5);
            }
        }
    }
}
