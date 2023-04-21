using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeWork
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show($"Hello,我是{Name} \n,英文名字是 {EnglishName} \n,性別是 {Gender} \n,星座是 {Constellation} \n,很高興認識你。");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Gender = txtGender.Text;
            string Constellation = txtConstellation.Text;
            MessageBox.Show($"Hi,我是 {Name} \n,英文名字是 {EnglishName} \n,性別是 {Gender} \n,星座是 {Constellation} \n,很高興認識你。");
        }
    }
}
