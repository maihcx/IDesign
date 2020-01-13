using System.Drawing;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public class SaveSettingForm
    {
        public static void SaveForm(Form frm)
        {
            Properties.Settings.Default.FState = frm.WindowState;
            Properties.Settings.Default.FPIP = Library.is_PIP;
            if (frm.WindowState == FormWindowState.Normal && !Library.is_PIP)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.FLocation = frm.Location;
                Properties.Settings.Default.FSize = frm.Size;
                // don't forget to save the settings
            }
            else if (Library.is_PIP)
            {
                System.Drawing.Point locationsPIPfrm = new Point(Library.int_formLocationX, Library.int_formLocationY);
                System.Drawing.Size sizePIPfrm = new Size(Library.int_formWidth, Library.int_formHeight);

                Properties.Settings.Default.FLocation = locationsPIPfrm;
                Properties.Settings.Default.FSize = sizePIPfrm;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.FLocation = frm.RestoreBounds.Location;
                Properties.Settings.Default.FSize = frm.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }

        public static void IntializeForm(Form frm)
        {
            if (Properties.Settings.Default.FSize.Width != 0 && Properties.Settings.Default.FSize.Height != 0)
            {
                frm.WindowState = Properties.Settings.Default.FState;

                // we don't want a minimized window at startup
                if (frm.WindowState == FormWindowState.Minimized) frm.WindowState = FormWindowState.Normal;

                frm.Location = Properties.Settings.Default.FLocation;
                frm.Size = Properties.Settings.Default.FSize;
            }
        }
    }
}
