using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using BlueformFramework;
using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;

namespace MessengerBrowser
{
    static class Program
    {
        static frmMain frm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CefSharpSettings.SubprocessExitIfParentProcessClosed = true;
            Cef.EnableHighDPISupport();
            var settings = new CefSettings()
            {
                CachePath = Path
                .Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MessengerFB\\Cache")
            };
            settings.CefCommandLineArgs.Add("debug-plugin-loading", "1");
            settings.CefCommandLineArgs.Add("allow-outdated-plugins", "1");
            settings.CefCommandLineArgs.Add("always-authorize-plugins", "1");
            settings.CefCommandLineArgs.Add("disable-web-security", "1");
            settings.CefCommandLineArgs.Add("enable-npapi", "1");
            settings.CefCommandLineArgs.Add("enable-media-stream", "1");
            settings.CefCommandLineArgs.Add("enable_spellchecking", "0");
            settings.WindowlessRenderingEnabled = true;
            settings.EnableNetSecurityExpiration = true;
            settings.BackgroundColor = Cef.ColorSetARGB(255, 85, 85, 85);
            if (Properties.Settings.Default.FStopGPU)
            {
                settings.SetOffScreenRenderingBestPerformanceArgs();
                settings.DisableGpuAcceleration();
            }
            settings.Locale = "vi";
            settings.AcceptLanguageList = "en_US";
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);

            //Application.Run(new frmMain());

            frm = new frmMain();
            SingleInstanceApplication.Run(frm, NewInstanceHandler);
            //frm1 = new frmIconTray();
            //SingleInstanceApplication.Run(frm1, NewInstanceHandlerNone);
            //Application.Run(new frmIconTray());
        }

        public static void NewInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            // Kích hoạt cửa sổ của instance đang chạy
            // Bạn có thể thay thế bằng 1 hành động khác
            if (!Library.is_openedwindows)
            {
                Library.is_openedwindows = true;
                frm.Show();
                BlueformFrameworkUse.Show(frm, 10);
            }
        }

        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {
            private SingleInstanceApplication()
            {
                base.IsSingleInstance = true;
            }

            public static void Run(Form f, StartupNextInstanceEventHandler startupHandler)
            {
                SingleInstanceApplication app = new SingleInstanceApplication();
                app.MainForm = f;
                app.StartupNextInstance += startupHandler;
                app.Run(Environment.GetCommandLineArgs());
            }
        }
    }
}
