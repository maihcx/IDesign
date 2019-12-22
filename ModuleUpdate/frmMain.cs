using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using RunThread;

namespace ModuleUpdate
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                lblstatus.Text = "Stating..";
                progressWork.Value += 20;
                WebRequest wrsUpdate = WebRequest.Create("https://drive.google.com/uc?authuser=0&id=1Sr_CrZB6dEZVGjLx3KxAUvQzclwDsxGh&export=download");
                Thread.Sleep(200);

                lblstatus.Text = "Checking file..";
                progressWork.Value += 20;
                WebResponse wrpUpdate = wrsUpdate.GetResponse();

                lblstatus.Text = "Ready..";
                progressWork.Value += 20;
                StreamReader srdUpdate = new StreamReader(wrpUpdate.GetResponseStream());
                Thread.Sleep(300);

                Thread.Sleep(350);
                string Path_Location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6);
                string thisver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string response = srdUpdate.ReadToEnd();
                var reponseStr = response.Split('\n');

                string path = @"D:\Messenger_Update";
                if (!Directory.Exists(path))
                {
                    Application.Exit();
                    //Directory.CreateDirectory(path);
                }
                for (int i = 1; i < reponseStr.Length; i++)
                {
                    var var_in = reponseStr[i].Trim().Split(' ');
                    string filename = var_in[0].Trim();
                    //string filelink = var_in[1].Trim();
                    lblstatus.Text = i + "/" + (reponseStr.Length - 1) + " Installing file: " + filename;

                    string sourceFile = path + @"\" + filename;
                    string destinationFile = Path_Location + @"\" + filename;

                    try
                    {
                        File.Copy(sourceFile, destinationFile, true);
                        File.Delete(sourceFile);
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Some error on update, plese try again later!", "Messenger !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // To move an entire directory. To programmatically modify or combine
                    // path strings, use the System.IO.Path class.
                    //System.IO.Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");
                    try
                    {
                        System.IO.Directory.Delete(destinationFile, true);

                    }
                    catch
                    {
                        //MetroMessageBox.Show(this, "Error File!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lblstatus.Text = "Complete install file: " + filename;
                    Thread.Sleep(300);
                }
                lblstatus.Text = "Complete update. Starting program..";
                progressWork.Value += 40;
                Thread.Sleep(800);
                Process.Start(Path.Combine(AppDomain
                    .CurrentDomain.BaseDirectory
                    .SolutionFolder()
                    , Path_Location + @"\MessengerBrowser.exe"));
                this.Close();
            })
            { IsBackground = true }.Start();
        }
    }
}
