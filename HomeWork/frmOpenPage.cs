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
    public partial class frmOpenPage : Form
    {
        public frmOpenPage()
        {
            InitializeComponent();
        }

        private void btnHello_Click_1(object sender, EventArgs e)
        {
            frmHello frm = new frmHello();
            frm.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            frmLoan fl = new frmLoan();
            fl.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            frmCalculate fc = new frmCalculate();
            fc.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS fp = new frmPOS();
            fp.Show();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            frmClock fc = new frmClock();
            fc.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            frmMethod fm = new frmMethod();
            fm.Show();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            frmNote fn = new frmNote();
            fn.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            frmScreen fsn = new frmScreen();
            fsn.Show();
        }

        private void btnPictureView_Click(object sender, EventArgs e)
        {
            frmPictureView fpv = new frmPictureView();
            fpv.Show();
        }
    }
}
