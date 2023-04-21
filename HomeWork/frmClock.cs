using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class frmClock : Form
    {
        public frmClock()
        {
            InitializeComponent();
        }

        private void tmrCurrentTime_Tick(object sender, EventArgs e)
        {
            labCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss");
            DateTime dt = dtpCurrentTime.Value;
            if (cbCheck.Checked && dt.Hour == DateTime.Now.Hour && dt.Minute == DateTime.Now.Minute && dt.Second == DateTime.Now.Second)
            {
                MessageBox.Show("你好，早安");
            }
        }
    }
}
