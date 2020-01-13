using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public partial class frmIconTray : Form
    {
        public frmIconTray()
        {
            InitializeComponent();
        }

        private void frmIconTray_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void IconTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Library.ShowOrHideForm();
            }
        }

        private void exitMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library.endProcessMain();
        }

        private void IconTray_BalloonTipClosed(object sender, EventArgs e)
        {
            //Library.balloonClosed();
        }

        private void IconTray_BalloonTipShown(object sender, EventArgs e)
        {
            Library.balloonShown();
        }

        private void IconTray_BalloonTipClicked(object sender, EventArgs e)
        {
            Library.balloonClicked();
        }

        public void ShowNotification(string text, string title)
        {
            //IconTray.BalloonTipText = text;
            //IconTray.BalloonTipTitle = title;
            //IconTray.ShowBalloonTip(time);

            popupNoty.ContentText = text;
            popupNoty.TitleText = title;
            popupNoty.Popup();
        }
        System.Windows.Forms.Timer tmruner = new System.Windows.Forms.Timer();
        frmSetting frmst = new frmSetting();
        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Library.is_openedwindows)
            {
                Library.ShowOrHideForm();
                int int_time_stack = 0;
                tmruner.Stop();
                tmruner = new System.Windows.Forms.Timer();
                tmruner.Interval = 250;
                tmruner.Tick += new EventHandler((object obj, EventArgs ev) =>
                {
                    int_time_stack++;
                    if (int_time_stack > 0)
                    {
                        tmruner.Stop();
                        runformSetting();
                    }
                });
                tmruner.Start();
            }
            else
            {
                try
                {
                    runformSetting();
                }
                catch
                { }
            }
        }

        private void runformSetting()
        {
            frmst.Dispose();
            if (string.IsNullOrEmpty(frmst.Text) || frmst.IsDisposed)
            {
                frmst = new frmSetting();
            }
            this.Invoke((MethodInvoker)delegate
            {
                frmst.ShowDialog();
            });
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void popupNoty_Click(object sender, EventArgs e)
        {
            Library.balloonClicked();
            popupNoty.Hide();
        }
    }
}
