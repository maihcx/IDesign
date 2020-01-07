using System;
//using System.Threading;
using System.Windows.Forms;

namespace BlueformFramework
{
    public class BlueformFrameworkUse
    {
        static Timer timego = new Timer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void Show(Form frm, int valueInterval)
        {
            frm.Show();
            Stop();
            //frm.Opacity = 0;
            timego = new Timer();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 0;

            timego.Enabled = true;
            timego.Interval = 1;
            timego.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse += valuePlus;
                frm.Opacity = valueUse;

                if (valueUse >= value)
                    timego.Stop();
            });
            timego.Start();
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
            Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego = new Timer();
            timego.Enabled = true;
            timego.Interval = 1;
            timego.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    frm.Hide();
                    timego.Stop();
                }
            });
            timego.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm">Your Form</param>
        /// <param name="valueInterval">Interval Of time</param>
        public static void FormBlure(Form frm, int valueInterval)
        {
            frm.Show();
            Stop();
            double value = 1;
            double valuePlus = value / valueInterval;
            double valueUse = 1;
            timego = new Timer();
            timego.Enabled = true;
            timego.Interval = 1;
            timego.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                valueUse -= valuePlus;
                frm.Opacity = valueUse;

                if (valueUse <= 0)
                {
                    timego.Stop();
                    frm.Opacity = 1;
                }
            });
            timego.Start();
        }

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

        private static void Stop()
        {
            timego.Stop();
        }
    }
}
