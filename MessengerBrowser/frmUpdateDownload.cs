using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public partial class frmUpdateDownload : MetroForm
    {
        public frmUpdateDownload()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        //public ChromiumWebBrowser browser;
        private void frmUpdateDownload_Load(object sender, EventArgs e)
        {
            //DisplayHandler displayer = new DisplayHandler();
            //browser = new ChromiumWebBrowser();
            //browser.DownloadHandler = new DownloadHandler();
            //Controls.Add(browser);
            //browser.Dock = DockStyle.Fill;

            ////browser.AddressChanged += Browser_AddressChanged;

            //browser.DownloadHandler = new DownloadHandler();
            //
            new Thread(() =>
            {
                lblstatus.Text = "Stating..";
                progressWork.Value += 20;
                WebRequest wrsUpdate = WebRequest.Create("https://drive.google.com/uc?authuser=0&id=1Sr_CrZB6dEZVGjLx3KxAUvQzclwDsxGh&export=download");
                Thread.Sleep(200);

                lblstatus.Text = "Connecting..";
                progressWork.Value += 30;
                WebResponse wrpUpdate = wrsUpdate.GetResponse();

                lblstatus.Text = "Checking Update..";
                progressWork.Value += 30;
                StreamReader srdUpdate = new StreamReader(wrpUpdate.GetResponseStream());
                Thread.Sleep(300);

                Thread.Sleep(350);
                string Path_Location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6);
                string thisver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string response = srdUpdate.ReadToEnd();
                var reponseStr = response.Split('\n');
                string newver = reponseStr[0].Trim();
                if (thisver != newver)
                {
                    if (MetroMessageBox.Show(this, "Version: " + newver + " are ready for download, do you want continue ?", "Question ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string path = @"D:\Messenger_Update";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        for (int i = 1; i < reponseStr.Length; i++)
                        {
                            var var_in = reponseStr[i].Trim().Split(' ');
                            string filename = var_in[0].Trim();
                            string filelink = var_in[1].Trim();
                            lblstatus.Text = i + "/" + (reponseStr.Length - 1) + " Downloading file: " + filename;
                            downloadAPI.DownloadFileFromURLToPath(filelink, @"D:\Messenger_Update\" + filename);
                            lblstatus.Text = "Complete download file: " + filename;
                            Thread.Sleep(300);
                        }
                        lblstatus.Text = "Complete download all file. Waiting for instal!";
                        progressWork.Value += 20;
                        Thread.Sleep(800);
                        Process.Start(Path.Combine(AppDomain
                            .CurrentDomain.BaseDirectory
                            .SolutionFolder()
                            , Path_Location + @"\ModuleUpdate.exe"));
                        Library.EndProgram();
                    }
                    else
                    {
                        lblstatus.Text = "Download is cancel!";
                        progressWork.Value += 20;
                    }
                }
                else
                {
                    progressWork.Value += 20;
                    lblstatus.Text = "Your Application is release\nYour version: " + thisver;
                }
                Application.ExitThread();
            })
            { IsBackground = true }.Start();
            //th.Join();
            //if (is_end)
            //    Application.ExitThread();
            //using (WebClient wc = new WebClient())
            //{
            //    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            //    wc.DownloadFileAsync(
            //        // Param1 = Link of file
            //        new System.Uri("http://www.sayka.com/downloads/front_view.jpg"),
            //        // Param2 = Path to save
            //        "D:\\front_view.jpg"
            //    );
            //}
        }

        private void btnOKSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
