using BlueformFramework;
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
    public partial class frmpoupupMessenging : Form
    {
        public frmpoupupMessenging()
        {
            InitializeComponent();
        }

        int x = 0, y = 0;
        bool ismove = false;
        bool isfirsMove = false;
        bool isMoveTrue = false;
        Timer tmwait = new Timer();

        private void pnPoupup_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                pnPoupup.Location = new Point(pnPoupup.Location.X - (x - e.X), pnPoupup.Location.Y - (y - e.Y));
                int pnx = pnPoupup.Location.X;
                int pny = pnPoupup.Location.Y;
                if (checkInZoneClosed(pnx, pny))
                {
                    pnClose.BackColor = Color.IndianRed;
                }
                else
                {
                    pnClose.BackColor = Color.White;
                }
                ismoveControls();
                isfirsMove = true;
                isMoveTrue = true;
            }
        }

        private void pnPoupup_MouseUp(object sender, MouseEventArgs e)
        {
            int pnx = pnPoupup.Location.X;
            int pny = pnPoupup.Location.Y;
            ismove = false;
            isfirsMove = false;
            if (isMoveTrue)
            {
                if (checkInZoneClosed(pnx, pny))
                {
                    this.Hide();
                    pnPoupup.Location = new Point(12, 12);
                }
                else
                {
                    pnPoupup.Location = new Point((pnx < 12) ? 12 :
                        (pnx < this.Width / 2) ? 12 :
                        (pnx > this.Width / 2) ? (this.Width - pnPoupup.Width - 12) : pnx,
                        (pny < 12) ? 12 : 
                        (pny > (this.Height - pnPoupup.Height - 12)) ? (this.Height - pnPoupup.Height - 12) : pny);
                }
                ismoveControls();
            }
            else
            {
                if (!Library.is_openedwindows)
                {
                    Library.ShowOrHideForm();
                    this.Hide();
                }
            }
            isMoveTrue = false;
        }

        private void pnPoupup_MouseDown(object sender, MouseEventArgs e)
        {
            ismove = true;
            x = e.X;
            y = e.Y;
        }

        private void ismoveControls()
        {
            if (ismove)
            {
                if (!isfirsMove)
                {
                    pnClose.Visible = true;
                    //this.BackColor = Color.White;
                    //this.Opacity = 0;
                    //BlueformFrameworkUse.Show(this, 10);
                    //tmwait.Stop();
                    //tmwait = new Timer();
                    //tmwait.Interval = 200;
                    //tmwait.Tick += new EventHandler((object obj, EventArgs e) =>
                    //{
                    //    tmwait.Stop();
                    this.Opacity = 0.7;
                    //});
                    //tmwait.Start();
                }
            }
            else
            {
                pnClose.Visible = false;
                //BlueformFrameworkUse.Hide(this, 10);
                //tmwait.Stop();
                //tmwait = new Timer();
                //tmwait.Interval = 200;
                //tmwait.Tick += new EventHandler((object obj, EventArgs e) =>
                //{
                //    tmwait.Stop();
                //this.BackColor = SystemColors.ActiveCaption;
                this.Opacity = 1;
                //    this.Show();
                //});
                //tmwait.Start();
            }
        }

        private void frmpoupupMessenging_Load(object sender, EventArgs e)
        {
            int widthForm = Screen.PrimaryScreen.Bounds.Width;
            int heightForm = Screen.PrimaryScreen.Bounds.Height - 40;

            this.Width = widthForm;
            this.Height = heightForm;

            this.Location = new Point(0, 0);
            Library.is_Messenging_Start = true;
            pnClose.Location = new Point((this.Width / 2) - (pnClose.Width / 2), this.Height - pnClose.Height - 12);
        }

        public void Show_Hide(bool isShow)
        {
            if (isShow)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }

        private bool checkInZoneClosed(int x, int y)
        {
            if ((x >= ((this.Width / 2) - (pnClose.Width / 2)) - 25) &&
                        (x <= ((this.Width / 2) + (pnClose.Width / 2)) - 30) &&
                        (y >= this.Height - pnClose.Height - 12))
            {
                return true;
            }
            return false;
        }
    }
}
