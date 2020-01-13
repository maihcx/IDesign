using CefSharp;
using CefSharp.WinForms;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
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
            browser.RequestHandler = new RequestHandlerfb();
            browser.MenuHandler = new MenuHandler();
            browser.AddressChanged += Browser_AddressChanged;
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

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                Text = e.Address;
                //MessageBox.Show(Text);
                if (!(Text.Contains("facebook.com")) && Properties.Settings.Default.FIsOutApplication)
                {
                    System.Diagnostics.Process.Start(Text);
                    browser.Back();
                }
            }));
        }

        public void ChangeUrl(string str_url)
        {
            if (!string.IsNullOrEmpty(str_url))
                browser.Load(str_url);
        }

        public void FacebookShutdow()
        {
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void RestartFacebook()
        {
            browser.GetBrowser().Reload(true);
        }

        public void setZoomLever(double value)
        {
            browser.SetZoomLevel(value);
        }
    }

    public class RequestHandlerfb : IRequestHandler
    {
        bool IRequestHandler.GetAuthCredentials(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, bool isProxy, string host, int port, string realm, string scheme, IAuthCallback callback)
        {
            return true;
        }

        IResourceRequestHandler IRequestHandler.GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return null;
        }

        bool IRequestHandler.OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {
            // If the url

            if (!Properties.Settings.Default.FIsOutApplication || request.Url.ToString().Contains("facebook.com") || request.Url.ToString().Contains("devtools://devtools/devtools_app.html"))
            {
                // Url except open in CefSharp's Chromium browser
                return false;
            }
            else
            {
                System.Diagnostics.Process.Start(request.Url);
                browser.CloseBrowser(true);
                return true;
            }
        }

        bool IRequestHandler.OnCertificateError(IWebBrowser chromiumWebBrowser, IBrowser browser, CefErrorCode errorCode, string requestUrl, ISslInfo sslInfo, IRequestCallback callback)
        {
            return true;
        }

        bool IRequestHandler.OnOpenUrlFromTab(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, WindowOpenDisposition targetDisposition, bool userGesture)
        {
            return true;
        }

        void IRequestHandler.OnPluginCrashed(IWebBrowser chromiumWebBrowser, IBrowser browser, string pluginPath)
        {
        }

        bool IRequestHandler.OnQuotaRequest(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, long newSize, IRequestCallback callback)
        {
            return true;
        }

        void IRequestHandler.OnRenderProcessTerminated(IWebBrowser chromiumWebBrowser, IBrowser browser, CefTerminationStatus status)
        {
        }

        void IRequestHandler.OnRenderViewReady(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
        }

        bool IRequestHandler.OnSelectClientCertificate(IWebBrowser chromiumWebBrowser, IBrowser browser, bool isProxy, string host, int port, X509Certificate2Collection certificates, ISelectClientCertificateCallback callback)
        {
            return true;
        }
    }
}
