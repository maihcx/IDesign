using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using MetroFramework;
using MetroFramework.Forms;

namespace MessengerBrowser
{
    public partial class frmSetting : MetroForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            //string[] arrStrColor = { "Default", "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow" };
            //for (int i = 0; i < arrStrColor.Length; i++)
            //{
            //    cbbColor.Items.Add(arrStrColor[i]);
            //    cbbColor.Items.IndexOf(i);
            //}
            //this.Theme = MetroThemeStyle.Dark;
            if (!Library.is_openedwindows)
            {
                Library.ShowOrHideForm();
            }
            cbDisableGPU.Checked = Properties.Settings.Default.FStopGPU;
            trackWidth.Value = Properties.Settings.Default.FPIPWidth;
            trackHeight.Value = Properties.Settings.Default.FPIPHeight;
            cbFA.Checked = Properties.Settings.Default.FEnableFA;

        }

        private void btnOKSystem_Click(object sender, EventArgs e)
        {
            OKBTN();
        }

        private void pipSetting_Click(object sender, EventArgs e)
        {

        }

        private void trackWidth_Scroll(object sender, EventArgs e)
        {
            Library.previewPIPSize(trackWidth.Value, trackHeight.Value);
        }

        private void trackHeight_Scroll(object sender, EventArgs e)
        {
            Library.previewPIPSize(trackWidth.Value, trackHeight.Value);
        }

        private void btnOKPIP_Click(object sender, EventArgs e)
        {
            OKBTN();
        }

        private void pnClose_MouseHover(object sender, EventArgs e)
        {
            pnClose.BackgroundImage = Properties.Resources.mac_ico_close2;
        }

        private void pnClose_MouseLeave(object sender, EventArgs e)
        {
            pnClose.BackgroundImage = Properties.Resources.mac_ico_close1;
        }

        private void pnClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void OKBTN()
        {
            bool is_restartThread = false;
            if (MetroMessageBox.Show(this, "Bạn có chắc muốn thực hiện hành động này ?, Có thể bạn sẽ phải đóng ứng dụng để áp dụng thiết lập này!", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Properties.Settings.Default.FPIPWidth = trackWidth.Value;
                Properties.Settings.Default.FPIPHeight = trackHeight.Value;
                Properties.Settings.Default.FPIPPanelWidth = Library.PIPPanelWidth;
                Properties.Settings.Default.FPIPPanelHeight = Library.PIPPanelHeight;
                Properties.Settings.Default.FEnableFA = cbFA.Checked;
                Library.PIPWidth = trackWidth.Value;
                Library.PIPHeight = trackHeight.Value;
                this.Close();

                if (cbClear.Checked)
                {
                    Cef.GetGlobalCookieManager().DeleteCookies("", "");
                    Library.RestartMessenger();
                }

                if (Properties.Settings.Default.FStopGPU != cbDisableGPU.Checked)
                {
                    Properties.Settings.Default.FStopGPU = cbDisableGPU.Checked;
                    is_restartThread = true;
                }

                Properties.Settings.Default.Save();

                if (is_restartThread)
                {
                    Application.ExitThread();
                    Application.Restart();
                }

                this.Close();
            }
        }

        private void trackWidth_Scroll(object sender, ScrollEventArgs e)
        {
            Library.previewPIPSize(trackWidth.Value, trackHeight.Value);
        }

        private void trackHeight_Scroll(object sender, ScrollEventArgs e)
        {
            Library.previewPIPSize(trackWidth.Value, trackHeight.Value);
        }

        private void btnOKMulti_Click(object sender, EventArgs e)
        {
            OKBTN();
        }
    }
}
