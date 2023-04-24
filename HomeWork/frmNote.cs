using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeWork
{
    public partial class frmNote : Form
    {
        public frmNote()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                txtNote.Text = File.ReadAllText(ofdOpen.FileName, Encoding.Default); 
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(ofdSave.FileName,txtNote.Text,Encoding.Default);
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdOpen.FileName == "")
            {
                if(ofdSave.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(ofdSave.FileName,txtNote.Text,Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(ofdOpen.FileName,txtNote.Text,Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdOpen.FileName = "";
            txtNote.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdChange.ShowDialog();
            txtNote.ForeColor = cdChange.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdChange.ShowDialog();
            txtNote.Font = fdChange.Font;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.ForeColor = Color.Black;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.ForeColor = Color.Green;
        }

        private void tmrCurrentTime_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("hh.mm.ss");
        }
    }
}
