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
    public partial class frmScreenSaver : Form
    {
        public frmScreenSaver()
        {
            InitializeComponent();
        }

        private void frmScreenSaver_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            pbNiceBoat.Left -= -5;
            if(pbNiceBoat.Right < 0)
            {
                pbNiceBoat.Left = this.ClientSize.Width;
            }
            pbNiceBoat.Top -= -5;
            if(pbNiceBoat.Bottom < 0)
            {
                pbNiceBoat.Top = this.ClientSize.Height;
            }
        }
    }
}
