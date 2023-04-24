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
    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
        }
        private int x = 5;
        private int y = 5;
        private void tmrScreen_Tick(object sender, EventArgs e)
        {
           pbScreen.Location = new Point(pbScreen.Location.X + x,pbScreen.Location.Y + y);
            if(pbScreen.Location.X < 0||pbScreen.Location.X + pbScreen.Width > this.Width)
            {
                x = -x;
            }
            if (pbScreen.Location.Y < 0 || pbScreen.Location.Y + pbScreen.Height >this.Height)
            {
                y = -y;
            }
            this.Invalidate();
        }
        //&& pbScreen.Top == this.ClientSize.Height
        //&& pbScreen.Left == this.ClientSize.Width
        private void pbScreen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
