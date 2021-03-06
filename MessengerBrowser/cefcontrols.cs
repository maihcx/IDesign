﻿using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MessengerBrowser
{

    public class DisplayHandler : IDisplayHandler
    {
        
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
            Library.setFullScreen(fullscreen);
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

            if (!Properties.Settings.Default.FIsOutApplication || request.Url.ToString().Contains("messenger.com") || request.Url.ToString().Contains("devtools://devtools/devtools_app.html"))
            {
                if (request.Url.ToString().Contains("facebook.com"))
                {
                    // Open Google in Default browser 
                    Library.EndFace = true;
                    Library.changeBrowser(1, request.Url.ToString());
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

    public class KeyboardHandler : IKeyboardHandler
    {
        bool IKeyboardHandler.OnKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            return false;
        }

        bool IKeyboardHandler.OnPreKeyEvent(IWebBrowser chromiumWebBrowser, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            if (type == KeyType.RawKeyDown)
            {
                //MessageBox.Show(windowsKeyCode.ToString());
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
                else if (modifiers == CefEventFlags.ControlDown && windowsKeyCode == 9)
                {
                    if (Library.int_windows == 0)
                    {
                        Library.sendHostKey(-2);
                        Library.changeBrowser(1, string.Empty);
                    }
                    else
                    {
                        Library.sendHostKey(-1);
                        Library.changeBrowser(0, string.Empty);
                    }

                    if (Library.is_PIP)
                        Library.stopPIP();
                }
                else if (windowsKeyCode == 122)
                {
                    Library.is_FullScreen = !Library.is_FullScreen;
                    if (Library.is_FullScreen)
                    {
                        Library.setFullScreen(true);
                    }
                    else
                    {
                        Library.setFullScreen(false);
                    }
                }
                else if (windowsKeyCode == 27)
                {
                    if (Library.is_FullScreen)
                    {
                        Library.setFullScreen(false);
                    }
                    else
                    {
                        Library.ShowOrHideForm();
                    }
                }
                else if (windowsKeyCode == 109)
                {
                    if (!Library.is_PIP)
                    {
                        if (Library.int_windows == 0)
                            Library.setZoomLeverMS(Library.dou_zoomvalueMS -= 0.1);
                        else if (Library.int_windows == 1)
                            Library.setZoomLeverFA(Library.dou_zoomvalueFA -= 0.1);
                        Library.sendHostKey(-3);
                        return true;
                    }
                }
                else if (windowsKeyCode == 107)
                {
                    if (!Library.is_PIP)
                    {
                        if (Library.int_windows == 0)
                            Library.setZoomLeverMS(Library.dou_zoomvalueMS += 0.1);
                        else if (Library.int_windows == 1)
                            Library.setZoomLeverFA(Library.dou_zoomvalueFA += 0.1);
                        Library.sendHostKey(-3);
                        return true;
                    }
                }
                else if (Library.int_windows == 0)
                {
                    if (modifiers == CefEventFlags.AltDown)
                    {
                        if (windowsKeyCode == 80)
                        {
                            if (!Library.is_PIP)
                            {
                                Library.startPIP();
                            }
                            else
                            {
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

                if (modifiers == CefEventFlags.ControlDown)
                {
                    if (windowsKeyCode == 189)
                    {
                        if (!Library.is_PIP)
                        {
                            if (Library.int_windows == 0)
                                Library.setZoomLeverMS(Library.dou_zoomvalueMS -= 0.1);
                            else if (Library.int_windows == 1)
                                Library.setZoomLeverFA(Library.dou_zoomvalueFA -= 0.1);
                            Library.sendHostKey(-3);
                        }
                    }
                    else if (windowsKeyCode == 187)
                    {
                        if (!Library.is_PIP)
                        {
                            if (Library.int_windows == 0)
                                Library.setZoomLeverMS(Library.dou_zoomvalueMS += 0.1);
                            else if (Library.int_windows == 1)
                                Library.setZoomLeverFA(Library.dou_zoomvalueFA += 0.1);
                            Library.sendHostKey(-3);
                        }
                    }
                    else if (windowsKeyCode == 68)
                    {
                        if (!Library.is_PIP)
                        {
                            if (Library.int_windows == 0)
                                Library.setZoomLeverMS(Library.dou_zoomvalueMS = 0);
                            else if (Library.int_windows == 1)
                                Library.setZoomLeverFA(Library.dou_zoomvalueFA = 0);
                            Library.sendHostKey(-3);
                        }
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
            model.AddItem((CefMenuCommand)ShowDevTools, "Công cụ nhà phát triển");
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

    public class ExtensionHandler : IExtensionHandler
    {
        public bool CanAccessBrowser(IExtension extension, IBrowser browser, bool includeIncognito, IBrowser targetBrowser)
        {
            return true;
        }

        public void Dispose()
        {
            
        }

        public IBrowser GetActiveBrowser(IExtension extension, IBrowser browser, bool includeIncognito)
        {
            throw new NotImplementedException();
        }

        public bool GetExtensionResource(IExtension extension, IBrowser browser, string file, IGetExtensionResourceCallback callback)
        {
            return true;
        }

        public bool OnBeforeBackgroundBrowser(IExtension extension, string url, IBrowserSettings settings)
        {
            return true;
        }

        public bool OnBeforeBrowser(IExtension extension, IBrowser browser, IBrowser activeBrowser, int index, string url, bool active, IWindowInfo windowInfo, IBrowserSettings settings)
        {
            return true;
        }

        public void OnExtensionLoaded(IExtension extension)
        {
            MessageBox.Show("Extension Loaded");
        }

        public void OnExtensionLoadFailed(CefErrorCode errorCode)
        {
            MessageBox.Show("Extension Failed");
        }

        public void OnExtensionUnloaded(IExtension extension)
        {
            
        }
    }
}
