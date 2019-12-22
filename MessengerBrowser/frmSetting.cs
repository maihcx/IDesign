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
using System.Threading;
using BlueformFramework;

namespace MessengerBrowser
{
    public partial class frmSetting : MetroForm
    {
        public frmSetting()
        {
            InitializeComponent();
        }
        bool PIPNameFirstStart = true;
        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            BlueformFrameworkUse.Show(this, 10);
            //string[] arrStrColor = { "Default", "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow" };
            //for (int i = 0; i < arrStrColor.Length; i++)
            //{
            //    cbbColor.Items.Add(arrStrColor[i]);
            //    cbbColor.Items.IndexOf(i);
            //}
            //this.Theme = MetroThemeStyle.Dark;
            new Thread(() =>
            {
                if (!Library.is_openedwindows)
                {
                    Library.ShowOrHideForm();
                }
                cbDisableGPU.Checked = Properties.Settings.Default.FStopGPU;
                trackWidth.Value = Properties.Settings.Default.FPIPWidth;
                trackHeight.Value = Properties.Settings.Default.FPIPHeight;
                cbFA.Checked = Properties.Settings.Default.FEnableFA;
                trackPIPPanelHeight.Value = Properties.Settings.Default.FPIPPanelHeight;
                trackPIPPanelWidth.Value = Properties.Settings.Default.FPIPPanelWidth;
                if (Properties.Settings.Default.FPIPIsShowName)
                {
                    rdbShowName.Checked = true;
                }
                else
                {
                    rdbHideName.Checked = true;
                }
                cbHead.Checked = Properties.Settings.Default.FIsShowTop;
                cbOffUpdate.Checked = Properties.Settings.Default.FIsAutoUpdate;
                cbOffNotifi.Checked = Properties.Settings.Default.FIsShowMessenger;
                cbOffSystem.Checked = !Properties.Settings.Default.FIsRunbackground;
            })
            { IsBackground = true }.Start();
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
                Properties.Settings.Default.FPIPPanelLocation = Library.PIPPanelLocation;
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

                if (rdbHideName.Checked)
                {
                    Properties.Settings.Default.FPIPIsShowName = false;
                }
                else
                {
                    Properties.Settings.Default.FPIPIsShowName = true;
                }

                if (Properties.Settings.Default.FIsShowTop != cbHead.Checked)
                {
                    is_restartThread = true;
                }

                Properties.Settings.Default.FIsRunbackground = !cbOffSystem.Checked;

                Properties.Settings.Default.FIsShowMessenger = cbOffNotifi.Checked;

                Properties.Settings.Default.FIsShowTop = cbHead.Checked;

                Properties.Settings.Default.FPIPPanelLocation = Library.PIPPanelLocation;

                Properties.Settings.Default.FIsAutoUpdate = cbOffUpdate.Checked;

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

        private void trackPIPPanelHeight_Scroll(object sender, ScrollEventArgs e)
        {
            Library.previewPIPPanelSize(trackPIPPanelWidth.Value, trackPIPPanelHeight.Value);
        }

        private void trackPIPPanelWidth_Scroll(object sender, ScrollEventArgs e)
        {
            Library.previewPIPPanelSize(trackPIPPanelWidth.Value, trackPIPPanelHeight.Value);
        }

        private void rdbHideName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHideName.Checked && !PIPNameFirstStart)
            {
                Library.previewPIPPanelSize(trackPIPPanelWidth.Value, -60);
            }
            PIPNameFirstStart = false;
        }

        private void rdbShowName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowName.Checked && !PIPNameFirstStart)
            {
                Library.previewPIPPanelSize(trackPIPPanelWidth.Value, 60);
            }
            PIPNameFirstStart = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateDownload frm = new frmUpdateDownload();
            frm.Show();
            this.Close();
        }

        private void btnOKUpdate_Click(object sender, EventArgs e)
        {
            OKBTN();
        }

        private void frmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
            //    Library.RunTopMost(cbHead.Checked);
            //});

            //Thread.Sleep(500);
        }
    }
}
