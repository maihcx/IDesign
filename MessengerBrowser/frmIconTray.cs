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
            Library.balloonClosed();
        }

        private void IconTray_BalloonTipShown(object sender, EventArgs e)
        {
            Library.balloonShown();
        }

        private void IconTray_BalloonTipClicked(object sender, EventArgs e)
        {
            Library.balloonClicked();
        }

        public void ShowNotification(string text, string title, int time)
        {
            IconTray.BalloonTipText = text;
            IconTray.BalloonTipTitle = title;
            IconTray.ShowBalloonTip(time);
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting frmst = new frmSetting();
            frmst.ShowDialog();
        }
    }
}
