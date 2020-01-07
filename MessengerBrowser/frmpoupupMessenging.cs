using BlueformFramework;
using System;
using System.Drawing;
using System.Threading;
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
        Point locationFormPoupup;
        System.Windows.Forms.Timer tmwait = new System.Windows.Forms.Timer();

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    e.Graphics.Clear(Color.Transparent);
        //}

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    // Use e.g. Color.FromArgb(128, Color.Lime) for a 50% opacity green tint.
        //    WindowUtils.EnableAcrylic(this, Color.Transparent);

        //    base.OnHandleCreated(e);
        //}

        private void pnPoupup_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                this.BackColor = Color.Gainsboro;
                this.TransparencyKey = Color.Gainsboro;

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

                WindowUtils.EnableAcrylic(this, Color.Transparent);
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
                    Show_Hide(false);
                    this.Invoke((MethodInvoker)delegate
                    {
                        new Thread(() => { pnPoupup.Location = locationFormPoupup; }) { IsBackground = true }.Start();
                    });
                }
                else
                {
                    pnPoupup.Location = new Point((pnx < 12) ? 12 :
                        (pnx < this.Width / 2) ? 12 :
                        (pnx > this.Width / 2) ? (this.Width - pnPoupup.Width - 12) : pnx,
                        (pny < 12) ? 12 : 
                        (pny > (this.Height - pnPoupup.Height - 12)) ? (this.Height - pnPoupup.Height - 12) : pny);

                    locationFormPoupup = pnPoupup.Location;
                }
                ismoveControls();
            }
            else
            {
                if (!Library.is_openedwindows)
                {
                    Show_Hide(false);
                }
            }
            isMoveTrue = false;

            

            //this.BackColor = Color.Gainsboro;
            //this.TransparencyKey = Color.Gainsboro;
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
                    BlueformFrameworkUse.Show(this, 15);
                    //this.BackColor = Color.White;
                    //this.Opacity = 0;
                    //BlueformFrameworkUse.Show(this, 10);
                    //tmwait.Stop();
                    //tmwait = new Timer();
                    //tmwait.Interval = 200;
                    //tmwait.Tick += new EventHandler((object obj, EventArgs e) =>
                    //{
                    //    tmwait.Stop();
                    //this.Opacity = 0.7;
                    //});
                    //tmwait.Start();
                }
            }
            else
            {
                pnClose.Visible = false;
                BlueformFrameworkUse.FormBlure(this, 10);
                tmwait.Stop();
                tmwait = new System.Windows.Forms.Timer();
                tmwait.Interval = 170;
                tmwait.Tick += new EventHandler((object obj, EventArgs e) =>
                {
                    WindowUtils.DisabledAcrylic(this);
                    tmwait.Stop();
                });
                tmwait.Start();
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

            pnPoupup.Location = Properties.Settings.Default.FLocationMessenging;
            pnClose.Location = new Point((this.Width / 2) - (pnClose.Width / 2), this.Height - pnClose.Height - 12);

            locationFormPoupup = pnPoupup.Location;
        }

        /// <summary>
        /// Set Form Messenging is Show or Hide
        /// </summary>
        /// <param name="isShow">True = Show</param>
        public void Show_Hide(bool isShow)
        {
            if (isShow)
            {
                this.Show();
            }
            else
            {
                Properties.Settings.Default.FLocationMessenging = this.Location;
                Properties.Settings.Default.Save();
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
