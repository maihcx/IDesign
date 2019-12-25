using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public class Library
    {
        internal static string systemversion = "1.0.5.1";
        internal static string str_inputTitle;
        internal static string str_TextShow;
        internal static int int_ChangeIconUrl = 0;
        internal static string str_url = "http://www.messenger.com";
        internal static bool EndFace = false;
        //internal static bool is_FaceOpened = false;
        internal static int int_keyClick = 0;
        internal static bool is_PIP = false;
        internal static frmPictureInPicture frm = new frmPictureInPicture();
        internal static int int_formWidth = 0;
        internal static int int_formHeight = 0;
        internal static int int_formLocationX = 0;
        internal static int int_formLocationY = 0;
        internal static int int_controlWidth = 0;
        internal static int int_controlHeight = 0;
        internal static int int_controlLocationX = 0;
        internal static int int_controlLocationY = 0;
        internal static bool is_visibleMain = false;
        internal static int int_windows = 0;
        internal static bool is_openedwindows = true;
        internal static int PIPWidth = Properties.Settings.Default.FPIPWidth;
        internal static int PIPHeight = Properties.Settings.Default.FPIPHeight;
        internal static int PIPPanelWidth = Properties.Settings.Default.FPIPPanelWidth;
        internal static int PIPPanelHeight = Properties.Settings.Default.FPIPPanelHeight;
        internal static System.Drawing.Point PIPPanelLocation = Properties.Settings.Default.FPIPPanelLocation;
        //varible in the application privited
        static string str_messenging = "";
        static string str_messenging_e = "";
        static string str_title_save = "";
        public static string str_input_save = "";
        internal static void NotificationShow()
        {
            if (str_inputTitle.Contains("("))
            {
                if (str_inputTitle.Trim() != str_title_save)
                {
                    str_messenging = "";
                    for (int i = 0; i < str_inputTitle.Length; i++)
                    {
                        str_title_save = str_inputTitle.Trim();
                        try
                        {
                            str_messenging += int.Parse(str_inputTitle.Substring(i, 1)).ToString();
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            if (!(str_inputTitle.Contains("(") || str_inputTitle.Contains("Messenger") || str_inputTitle.Contains("Đăng nhập")))
            {
                if (str_inputTitle != str_input_save || str_messenging != str_messenging_e)
                {
                    str_messenging_e = str_messenging;
                    str_input_save = str_inputTitle;
                    str_TextShow = str_inputTitle;
                    if (int.Parse(str_messenging) > 1)
                    {
                        string str_messenging_c = (int.Parse(str_messenging) - 1).ToString();
                        int int_calculator = str_TextShow.Length - 20;
                        str_TextShow = str_inputTitle.Substring(0, int_calculator) + " và " + str_messenging_c + " người khác đã nhắn tin cho bạn";
                        ShowNoty(str_messenging);
                    }
                    else
                    {
                        ShowNoty(str_messenging);
                    }
                }
            }

        }

        public static void ShowOrHideForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).ShowOfHideMain();
                    break;
                }
            }
        }

        public static void ShowNoty(string str_messenging_in)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmIconTray)
                {
                    ((frmIconTray)frm).ShowNotification(str_TextShow, "Bạn có (" + str_messenging_in + ") tin nhắn mới");
                    break;
                }
            }
        }
        public static DialogResult MessengerMain(string strtext, string strtitle, MessageBoxButtons btn, MessageBoxIcon ico)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    return ((frmMain)frm).MessengerMain(strtext, strtitle, btn, ico);
                    break;
                }
            }
            return DialogResult.No;
        }

        public static void Reload()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserMessenger)
                {
                    ((frmBrowserMessenger)frm).ReloadWeb();
                    break;
                }
            }
        }

        public static void endLoading()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmLoading)
                {
                    ((frmLoading)frm).disponLoading();
                    break;
                }
            }
        }

        public static void startLoading()
        {
            frmLoading frm = new frmLoading();
            frm.ShowDialog();
        }

        public static void BrowserVisible()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).PanelCanVisible();
                    break;
                }
            }
        }

        public static void endProcessMain()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).EndMain();
                    break;
                }
            }
        }

        public static void balloonClosed()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).balloonClosed();
                    break;
                }
            }
        }

        public static void balloonShown()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).balloonShown();
                    break;
                }
            }
        }

        public static void balloonClicked()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    str_input_save = "";
                    ((frmMain)frm).balloonClicked();
                    break;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">The messenger you want for user know</param>
        /// <param name="title">Title for your messenger</param>
        /// <param name="time">Time to closed</param>
        //public static void showNotification(string text, string title, int time)
        //{
        //    foreach (Form frm in Application.OpenForms)
        //    {
        //        if (frm is frmIconTray)
        //        {
        //            ((frmIconTray)frm).ShowNotification(text, title, time);
        //            break;
        //        }
        //    }
        //}

        public static void changeBrowser(int int_BrowserChange, string str_url)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).changeBrowserControl(int_BrowserChange, str_url);
                    break;
                }
            }
        }

        public static void ChangeUrlFace(string str_url)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserFacebook)
                {
                    ((frmBrowserFacebook)frm).ChangeUrl(str_url);
                    break;
                }
            }
        }

        public static void FacebookCefShutdow()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserFacebook)
                {
                    ((frmBrowserFacebook)frm).FacebookShutdow();
                    break;
                }
            }
        }
        public static void hideMain_PIP()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).hideMain_PIP();
                    break;
                }
            }
        }

        public static void showMain_PIP()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).showMain_PIP();
                    break;
                }
            }
        }

        public static void setZoomLever(double value)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserMessenger)
                {
                    ((frmBrowserMessenger)frm).setZoomLever(value);
                    break;
                }
            }
        }

        public static void startPIP()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).startPIP();
                    break;
                }
            }
        }

        public static void stopPIP()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).stopPIP();
                    break;
                }
            }
        }

        public static void visibleMain(bool is_visisble)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).visibleMain(is_visisble);
                    break;
                }
            }
        }

        public static void sendHostKey(int ihostkey)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).SendHostKey(ihostkey);
                    break;
                }
            }
        }

        public static void painPanels(int int_windows, Color colorOfPanelTab)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).painPanels(int_windows, colorOfPanelTab);
                    break;
                }
            }
        }

        public static void RestartMessenger()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserMessenger)
                {
                    ((frmBrowserMessenger)frm).RestartMessenger();
                    break;
                }
            }
        }

        public static void RestartFacebook()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmBrowserFacebook)
                {
                    ((frmBrowserFacebook)frm).RestartFacebook();
                    break;
                }
            }
        }

        public static void previewPIPSize(int width, int height)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).previewPIPSize(width, height);
                    break;
                }
            }
        }
        public static void previewPIPPanelSize(int width, int height)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).previewPIPPanelSize(width, height);
                    break;
                }
            }
        }

        public static void EndProgram()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).EndProgram();
                    break;
                }
            }
        }

        public static void RunTopMost(bool istop)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).RunTopMost(istop);
                    break;
                }
            }
        }

        public static void previewWindowsStyle(int int_style)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmMain)
                {
                    ((frmMain)frm).previewWindowsStyle(int_style);
                    break;
                }
            }
        }
    }
}
