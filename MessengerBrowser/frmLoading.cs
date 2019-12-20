using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerBrowser
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        int w = -50;
        private void frmLoading_Load(object sender, EventArgs e)
        {
            //new Thread(() =>
            //{
            //    LoadForText();
            //})
            //{ IsBackground = true }.Start();

        }

        void LoadForText()
        {
            int w = -50;
            for (;;)
            {
                Thread.Sleep(3);
                lblText.Left = w;
                w++;
                if (w >= panel1.Width)
                {
                    w = -50;
                }
            }
        }
        
        public void disponLoading()
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblText.Left = w;
            w+=4;
            if (w >= panel1.Width)
            {
                w = -50;
            }
        }
    }
}
