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
    }
}
