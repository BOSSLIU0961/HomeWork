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
    public partial class frmPictureView : Form
    {
        public frmPictureView()
        {
            InitializeComponent();
        }

        private void ShowImage (Image image)
        {
            var f = new Form ();
            var pb = new PictureBox ();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            pb.Image = image;
            f.Controls.Add (pb);
            f.ClientSize = image.Size;
            f.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowImage (pictureBox1.Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox2.Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox3.Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox4.Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox5.Image);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox6.Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox7.Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ShowImage(pictureBox8.Image);
        }
    }
}
