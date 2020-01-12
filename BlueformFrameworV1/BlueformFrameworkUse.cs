using System;
//using System.Threading;
using System.Windows.Forms;

namespace BlueformFramework
{
    public class BlueformFrameworkUse
    {
        static Timer timego_show = new Timer();
        static Timer timego_hide = new Timer();
        static Timer timego_normal = new Timer();
        static Timer timego_blure = new Timer();
        static Timer timego_close = new Timer();
        static Timer timego_dispose = new Timer();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void Show(Form frm, int valueInterval)
        {
            frm.Show();
            timego_show.Stop();
            //frm.Opacity = 0;
            timego_show = new Timer();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 0;

            timego_show.Enabled = true;
            timego_show.Interval = 1;
            timego_show.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse += valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse >= value)
                    timego_show.Stop();
            });
            timego_show.Start();
        }


        //frm.Opacity = 1;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void Hide(Form frm, int valueInterval)
        {
            frm.Show();
            timego_hide.Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego_hide = new Timer();
            timego_hide.Enabled = true;
            timego_hide.Interval = 1;
            timego_hide.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    frm.Hide();
                    timego_hide.Stop();
                }
            });
            timego_hide.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void FormNormal(Form frm, int valueInterval)
        {
            //frm.Opacity = 0;
            timego_normal.Stop();
            timego_normal = new Timer();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 0;

            timego_normal.Enabled = true;
            timego_normal.Interval = 1;
            timego_normal.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse += valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse >= value)
                    timego_normal.Stop();
            });
            timego_normal.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void FormBlure(Form frm, int valueInterval)
        {
            timego_blure.Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego_blure = new Timer();
            timego_blure.Enabled = true;
            timego_blure.Interval = 1;
            timego_blure.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    timego_blure.Stop();
                    frm.Opacity = 1;
                }
            });
            timego_blure.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void Close(Form frm, int valueInterval)
        {
            frm.Show();
            timego_close.Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego_close = new Timer();
            timego_close.Enabled = true;
            timego_close.Interval = 1;
            timego_close.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    frm.Close();
                    timego_close.Stop();
                }
            });
            timego_close.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void Dispose(Form frm, int valueInterval)
        {
            frm.Show();
            timego_dispose.Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego_dispose = new Timer();
            timego_dispose.Enabled = true;
            timego_dispose.Interval = 1;
            timego_dispose.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                //ChangeOpacity(frm, valueUse);
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    frm.Dispose();
                    timego_dispose.Stop();
                }
            });
            timego_dispose.Start();
        }

        private delegate void ChangeOpacityDelegate(Form frm, double value);
        //private static void ChangeOpacity(Form frm, double value)
        //{
        //    try
        //    {
        //        if (frm.InvokeRequired)
        //        {
        //            ChangeOpacityDelegate del = new ChangeOpacityDelegate(ChangeOpacity);
        //            object[] parameters = { value };

        //            frm.Invoke(del, value);
        //        }
        //        else
        //        {
        //            //Your code goes here, in this case:
        //            frm.Opacity = value;
        //        }
        //    }
        //    catch
        //    {
        //        frm.Opacity = value;
        //    }
        //}

        //public static void End(Form frm, int valueInterval)
        //{
        //    System.Threading.Thread th = new System.Threading.Thread(() =>
        //    {
        //        frm.Show();
        //        Stop();
        //        double value = 1;
        //        double valuePlus = value / valueInterval;
        //        double valueUse = 1;
        //        timego = new Timer();
        //        timego.Enabled = true;
        //        timego.Interval = 1;
        //        timego.Tick += new EventHandler((object sender, EventArgs e) =>
        //        {
        //            valueUse -= valuePlus;
        //            frm.Opacity = valueUse;

        //            if (valueUse <= 0)
        //            {
        //                //frm.Close();
        //                timego.Stop();
        //            }
        //        });
        //        timego.Start();
        //    });
        //    th.Start();
        //    th.Join();
        //}
    }
}
