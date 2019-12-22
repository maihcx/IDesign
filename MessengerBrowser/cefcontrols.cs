using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerBrowser
{
    
    public class DisplayHandler : IDisplayHandler
    {
        private Control parent;
        private Form fullScreenForm;
        void IDisplayHandler.OnAddressChanged(IWebBrowser browserControl, AddressChangedEventArgs addressChangedArgs)
        {
        }
        void IDisplayHandler.OnTitleChanged(IWebBrowser browserControl, TitleChangedEventArgs titleChangedArgs)
        {
        }
        void IDisplayHandler.OnFaviconUrlChange(IWebBrowser browserControl, IBrowser browser, IList<string> urls)
        {
        }
        void IDisplayHandler.OnFullscreenModeChange(IWebBrowser browserControl, IBrowser browser, bool fullscreen)
        {
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            chromiumWebBrowser.InvokeOnUiThreadIfRequired(() =>
            {
                if (fullscreen)
                {
                    parent = chromiumWebBrowser.Parent;
                    parent.Controls.Remove(chromiumWebBrowser);
                    fullScreenForm = new Form();
                    fullScreenForm.FormBorderStyle = FormBorderStyle.None;
                    fullScreenForm.WindowState = FormWindowState.Maximized;
                    fullScreenForm.Controls.Add(chromiumWebBrowser);
                    fullScreenForm.ShowDialog(parent.FindForm());
                }
                else
                {
                    fullScreenForm.Controls.Remove(chromiumWebBrowser);
                    parent.Controls.Add(chromiumWebBrowser);
                    fullScreenForm.Close();
                    fullScreenForm.Dispose();
                    fullScreenForm = null;
                }
            });
        }
        bool IDisplayHandler.OnTooltipChanged(IWebBrowser chromiumWebBrowser, ref string text)
        {
            return false;
        }
        void IDisplayHandler.OnStatusMessage(IWebBrowser browserControl, StatusMessageEventArgs statusMessageArgs)
        {
        }
        bool IDisplayHandler.OnConsoleMessage(IWebBrowser browserControl, ConsoleMessageEventArgs consoleMessageArgs)
        {
            return false;
        }
        public bool OnAutoResize(IWebBrowser chromiumWebBrowser, IBrowser browser, CefSharp.Structs.Size newSize)
        {
            throw new NotImplementedException();
        }
        void IDisplayHandler.OnLoadingProgressChange(IWebBrowser chromiumWebBrowser, IBrowser browser, double progress)
        {
        }
    }

    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;
        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            var handler = OnBeforeDownloadFired;

            if (handler != null)
            {
                handler(this, downloadItem);
            }

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    callback.Continue(downloadItem.SuggestedFileName, showDialog: true);
                }
            }
        }
        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            var handler = OnDownloadUpdatedFired;
            if (handler != null)
            {
                handler(this, downloadItem);
            }
        }
    }

    public class RequestHandler : IRequestHandler
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
            if (request.Url.ToString().Contains("facebook.com"))
            {
                // Open Google in Default browser 
                Library.EndFace = true;
                Library.changeBrowser(1, request.Url.ToString());
                Library.painPanels(1, Color.DarkGray);
                browser.CloseBrowser(true);
                Library.stopPIP();
                return true;
            }
            else
            {
                // Url except open in CefSharp's Chromium browser
                return false;
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

    public class KeyboardHandler : IKeyboardHandler
    {
        bool IKeyboardHandler.OnKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            return false;
        }

        bool IKeyboardHandler.OnPreKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            //MessageBox.Show(windowsKeyCode.ToString());

            //if (Library.int_keyClick == 18 && windowsKeyCode == 88)
            //{
            //    if (!Library.is_visibleMain)
            //    {
            //        Library.is_visibleMain = true;
            //        Library.visibleMain(false);
            //    }
            //    else
            //    {
            //        Library.is_visibleMain = false;
            //        Library.visibleMain(false);
            //    }
            //}
            //MessageBox.Show(windowsKeyCode.ToString());
            //MessageBox.Show(windowsKeyCode.ToString());
            if (type == KeyType.RawKeyDown)
            {
                if (windowsKeyCode == 116)
                {
                    if (Library.int_windows == 0)
                    {
                        Library.RestartMessenger();
                    }
                    else
                    {
                        Library.RestartFacebook();
                    }
                }
                if (modifiers == CefEventFlags.ControlDown && windowsKeyCode == 9)
                {
                    if (Library.int_windows == 0)
                    {
                        Library.sendHostKey(-2);
                        Library.int_windows = 1;
                        Library.painPanels(1, Color.DarkGray);
                        Library.changeBrowser(1, "http://www.facebook.com");
                    }
                    else
                    {
                        Library.sendHostKey(-1);
                        Library.int_windows = 0;
                        Library.painPanels(0, Color.DarkGray);
                        Library.changeBrowser(0, string.Empty);
                    }
                }

                if (windowsKeyCode == 27)
                {
                    Library.ShowOrHideForm();
                    return false;
                }
                if (Library.int_windows == 0)
                {
                    if (modifiers == CefEventFlags.AltDown && windowsKeyCode == 80)
                    {
                        if (!Library.is_PIP)
                        {
                            //Library.setZoomLever(-0.43);
                            //Library.hideMain_PIP();
                            //Library.frm.ShowDialog();
                            Library.startPIP();
                        }
                        else
                        {
                            //Library.showMain_PIP();
                            //Library.frm.Close();
                            //Library.frm = new frmPictureInPicture();
                            //Library.setZoomLever(0);
                            Library.stopPIP();
                        }
                        Library.sendHostKey(0);
                    }
                    else if (windowsKeyCode >= 16 && windowsKeyCode <= 18)
                    {
                        Library.sendHostKey(windowsKeyCode);
                    }
                }
            }
            return false;
        }
    }

    internal class MenuHandler : IContextMenuHandler
    {
        private const int ShowDevTools = 26501;
        private const int CloseDevTools = 26502;
        private const int S_TPIP = 26503;
        private const int ShowSetting = 26504;

        void IContextMenuHandler.OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            //To disable the menu then call clear
            // model.Clear();

            //Removing existing menu item
            //bool removed = model.Remove(CefMenuCommand.ViewSource); // Remove "View Source" option
            model.Remove(CefMenuCommand.ViewSource);

            //Add new custom menu items
            model.AddItem((CefMenuCommand)ShowDevTools, "Show DevTools");
            model.Remove((CefMenuCommand)S_TPIP);
            model.AddItem((CefMenuCommand)S_TPIP, (Library.is_PIP) ? "Close PIP" : "Start PIP");
            //model.AddItem((CefMenuCommand)ShowSetting, "Mở cài đặt");
            //model.AddItem((CefMenuCommand)CloseDevTools, "Close DevTools");
        }

        bool IContextMenuHandler.OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if ((int)commandId == ShowDevTools)
            {
                browser.ShowDevTools();
            }
            if ((int)commandId == CloseDevTools)
            {
                browser.CloseDevTools();
            }
            if ((int)commandId == S_TPIP)
            {
                if (Library.is_PIP)
                    Library.stopPIP();
                else
                    Library.startPIP();
            }
            //if ((int)commandId == ShowSetting)
            //{
            //    frmSetting frm = new frmSetting();
            //    frm.ShowDialog();
            //}
            return false;
        }

        void IContextMenuHandler.OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        bool IContextMenuHandler.RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }

    //    public class RenderProcessMessageHandler : IRenderProcessMessageHandler
    //    {
    //        public void OnContextReleased(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
    //        {
    //        }

    //        public void OnFocusedNodeChanged(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IDomNode node)
    //        {
    //        }

    //        public void OnUncaughtException(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, JavascriptException exception)
    //        {
    //        }

    //        // Wait for the underlying JavaScript Context to be created. This is only called for the main frame.
    //        // If the page has no JavaScript, no context will be created.
    //        void IRenderProcessMessageHandler.OnContextCreated(IWebBrowser browserControl, IBrowser browser, IFrame frame)
    //        {
    //            const string script = "document.addEventListener('DOMContentLoaded', function(){ alert('DomLoaded'); });";

    //            frame.ExecuteJavaScriptAsync(script);
    //        }
    //    }
}
