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

                Aero.EnableAcrylic(blureForm.frmBlueGone, Color.Transparent);
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
                    //pnPoupup.Location = new Point((pnx < 12) ? 12 :
                    //    (pnx < this.Width / 2) ? 12 :
                    //    (pnx > this.Width / 2) ? (this.Width - pnPoupup.Width - 12) : pnx,
                    //    (pny < 12) ? 12 :
                    //    (pny > (this.Height - pnPoupup.Height - 12)) ? (this.Height - pnPoupup.Height - 12) : pny);

                    int int_x = pnx, int_y = pny;

                    if (pnx < 12 || pnx < this.Width / 2)
                    {
                        int_x = 12;
                    }
                    else if (pnx > this.Width / 2)
                    {
                        int_x = this.Width - pnPoupup.Width - 12;
                    }

                    if (pny < 12)
                    {
                        int_y = 12;
                    }
                    else if (pny > this.Height - pnPoupup.Height - 12)
                    {
                        int_y = this.Height - pnPoupup.Height - 12;
                    }

                    MovePanelPoupup(new Point(int_x, int_y));
                    //pnPoupup.Location = new Point(int_x, int_y);
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
                    blureForm.DisponseForm();
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
                    blureForm.SetSize = this.Size;
                    blureForm.SetLocations = this.Location;
                    blureForm.Intialization();
                    //blureForm.frmBlueGone.Hide();
                    this.Focus();

                    pnClose.Show();
                    this.Focus();
                    BlueformFrameworkUse.FormNormal(blureForm.frmBlueGone, 15);
                }
            }
            else
            {
                pnClose.Visible = false;
                BlueformFrameworkUse.FormBlure(blureForm.frmBlueGone, 10);
                tmwait.Stop();
                tmwait = new System.Windows.Forms.Timer();
                tmwait.Interval = 170;
                tmwait.Tick += new EventHandler((object obj, EventArgs e) =>
                {
                    tmwait.Stop();

                    Aero.DisabledAcrylic(blureForm.frmBlueGone);
                    blureForm.DisponseForm();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    if (isClosetForm)
                    {
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

            pnClose.Location = new Point((this.Width / 2) - (pnClose.Width / 2), this.Height - pnClose.Height - 12);
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
                        GC.WaitForPendingFinalizers();
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
                    GC.WaitForPendingFinalizers();
                    Library.is_Messenging_Start = false;
                }
            }
        }

        private void frmpoupupMessenging_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FColorControls == Color.Gainsboro)
            {
                Properties.Settings.Default.FColorControls = Color.White;
                this.BackColor = Color.White;
                this.TransparencyKey = Color.White;
                MessageBox.Show("Hệ thống gặp vấn đề về tương thích với Messenging, phần mềm đang cấu hình cài đặt khác !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Hệ thống không tương thích với Messenging, sẽ tắt Messenging !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Properties.Settings.Default.FIsMessenging = false;
                this.Dispose();
                Library.is_Messenging_Start = false;
            }
            Properties.Settings.Default.Save();
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

        private void MovePanelPoupup(Point Locations)
        {
            int pnx = Locations.X, pny = Locations.Y;
            int pn_x = pnPoupup.Location.X, pn_y = pnPoupup.Location.Y;
            Point locations = new Point(pnx, pny);

            new Thread(() =>
            {
                if (Math.Abs(pnx - pn_x) <= 40)
                {
                    pnPoupup.Location = new Point(pnx, pny);
                }
                else
                {
                    if (pnx - pn_x > 0)
                        for (int i = pn_x; i <= pnx; i += 40)
                        {
                            pnPoupup.Location = new Point(i, pny);
                            Thread.Sleep(5);
                        }
                    else
                        for (int i = pn_x; i >= pnx; i -= 40)
                        {
                            pnPoupup.Location = new Point(i, pny);
                            Thread.Sleep(5);
                        }

                    locations = CheckReLocations(pnx, pny);
                }
                Properties.Settings.Default.FLocationMessenging = locations;
            })
            { IsBackground = true }.Start();
        }

        private Point CheckReLocations(int pnx, int pny)
        {
            pnPoupup.Location = new Point((pnx < 12) ? 12 :
                (pnx < this.Width / 2) ? 12 :
                (pnx > this.Width / 2) ? (this.Width - pnPoupup.Width - 12) : pnx,
                (pny < 12) ? 12 :
                (pny > (this.Height - pnPoupup.Height - 12)) ? (this.Height - pnPoupup.Height - 12) : pny);
            return pnPoupup.Location;
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
            this.ForeColor = Color.White; //màu chữ
            this.BackColor = Color.White; //màu nền
            this.Size = new Size(70, 68);//Kích thước của khung chứa text
            this.AutoSize = false;

            Label lblCloset = new Label();
            lblCloset.Font = new Font(FontFamily.GenericSansSerif, 20);
            lblCloset.AutoSize = true;
            lblCloset.Text = "X";
            lblCloset.TextAlign = ContentAlignment.MiddleCenter;
            lblCloset.ForeColor = Color.DarkRed;
            this.Controls.Add(lblCloset);
            lblCloset.Show();
            lblCloset.Location = new Point((this.Width / 2) - (lblCloset.Width / 2) + 2, (this.Height / 2) - (lblCloset.Height / 2));

            GraphicsPath p = new GraphicsPath(); //Khởi tạo GraphicsPath
            p.AddEllipse(0, 0, 70, 68); //Add hình elip vào GraphicsPath
            this.Region = new Region(p); //Tạo region cho label theo elip vừa add
            p.Dispose();
        }
    }
}

