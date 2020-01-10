using BlueformFramework;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AeroLibrary;
using System.Drawing.Drawing2D;

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
        bool isClosetForm = false;
        centreeControls pnPoupup = new centreeControls();
        centreeControls pnClose = new centreeControls();
        //Point locationFormPoupup;
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

                Aero.EnableAcrylic(this, Color.Transparent);
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
                    isClosetForm = true;
                    //this.Invoke((MethodInvoker)delegate
                    //{
                    //    new Thread(() => { pnPoupup.Location = locationFormPoupup; }) { IsBackground = true }.Start();
                    //});
                }
                else
                {
                    pnPoupup.Location = new Point((pnx < 12) ? 12 :
                        (pnx < this.Width / 2) ? 12 :
                        (pnx > this.Width / 2) ? (this.Width - pnPoupup.Width - 12) : pnx,
                        (pny < 12) ? 12 :
                        (pny > (this.Height - pnPoupup.Height - 12)) ? (this.Height - pnPoupup.Height - 12) : pny);

                    //locationFormPoupup = pnPoupup.Location;
                    Properties.Settings.Default.FLocationMessenging = pnPoupup.Location;
                    Properties.Settings.Default.Save();
                }
                ismoveControls();
            }
            else
            {
                if (!Library.is_openedwindows)
                {
                    Library.ShowOrHideForm();
                    Show_Close(false);
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
                    BlueformFrameworkUse.FormNormal(this, 15);
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
                    tmwait.Stop();
                    Aero.DisabledAcrylic(this);
                    if (isClosetForm)
                    {
                        tmwait.Stop();
                        Show_Close(false);

                    }
                });
                tmwait.Start();
            }
        }

        private void frmpoupupMessenging_Load(object sender, EventArgs e)
        {
            int widthForm = Screen.PrimaryScreen.Bounds.Width;
            int heightForm = Screen.PrimaryScreen.Bounds.Height - 1;

            this.Width = widthForm;
            this.Height = heightForm;

            this.Location = new Point(0, 0);
            Library.is_Messenging_Start = true;


            pnClose.Location = new Point((this.Width / 2) - 35, this.Height - pnClose.Height + 12);

            pnPoupup.PropertiesPanel();
            pnPoupup.Location = Properties.Settings.Default.FLocationMessenging;
            pnPoupup.MouseDown += new MouseEventHandler(pnPoupup_MouseDown);
            pnPoupup.MouseMove += new MouseEventHandler(pnPoupup_MouseMove);
            pnPoupup.MouseUp += new MouseEventHandler(pnPoupup_MouseUp);

            pnClose.PropertiesPanelClose();
            pnClose.BackColor = Color.White;
            pnClose.Visible = false;

            this.Controls.Add(pnPoupup);
            this.Controls.Add(pnClose);
            pnPoupup.BringToFront();
            //locationFormPoupup = pnPoupup.Location;
        }

        /// <summary>
        /// Set Form Messenging is Show or Hide
        /// </summary>
        /// <param name="isShow">True = Show</param>
        public void Show_Close(bool isShow)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (isShow)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Dispose();
                        GC.Collect();
                        Library.is_Messenging_Start = false;
                    }
                });
            }
            else
            {
                if (isShow)
                {
                    this.Show();
                }
                else
                {
                    this.Dispose();
                    GC.Collect();
                    Library.is_Messenging_Start = false;
                }
            }
        }

        private void frmpoupupMessenging_Click(object sender, EventArgs e)
        {
            MessageBox.Show("XX");
        }

        private bool checkInZoneClosed(int x, int y)
        {
            if ((x >= ((this.Width / 2) - (pnClose.Width / 2)) - 25) &&
                        (x <= ((this.Width / 2) + (pnClose.Width / 2)) - 30) &&
                        (y >= this.Height - pnClose.Height - 35))
            {
                return true;
            }
            return false;
        }
    }
    class centreeControls : Panel
    {
        public void PropertiesPanel()
        {
            //base.Text = value.ToString();
            this.ForeColor = Color.White; //màu chữ
            //this.TextAlign = ContentAlignment.MiddleCenter; //canh vị trí label
            this.BackColor = Color.White; //màu nền
            this.Size = new Size(59, 58);//Kích thước của khung chứa text
            //this.FlatStyle = FlatStyle.Flat;
            this.AutoSize = false;
            this.BackgroundImage = Properties.Resources.messengerIconfixResize;
            this.BackgroundImageLayout = ImageLayout.Center;
            //this.Height += 10;
            //this.Width += 10;

            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 59, 58); //Add hình elip vào GraphicsPath
            this.Region = new Region(p); //Tạo region cho label theo elip vừa add
            p.Dispose();
        }

        public void PropertiesPanelClose()
        {
            //base.Text = value.ToString();
            this.ForeColor = Color.White; //màu chữ
            //this.TextAlign = ContentAlignment.MiddleCenter; //canh vị trí label
            this.BackColor = Color.White; //màu nền
            this.Size = new Size(70, 68);//Kích thước của khung chứa text
            //this.FlatStyle = FlatStyle.Flat;
            this.AutoSize = false;
            //this.Height += 10;
            //this.Width += 10;

            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 70, 68); //Add hình elip vào GraphicsPath
            this.Region = new Region(p); //Tạo region cho label theo elip vừa add
            p.Dispose();
        }
    }
}

