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
    public partial class frmCalculate : Form
    {
        public frmCalculate()
        {
            InitializeComponent();
        }

        public int Num1()
        {
            return Convert.ToInt32(txtNum1.Text);
        }

        public int Num2()
        {
            return Convert.ToInt32(txtNum2.Text);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Num1();
                int b = Num2();
                int c = a + b;
                txtAnswer.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show($"請輸入數值");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Num1();
                int b = Num2();
                int c = a - b;
                txtAnswer.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show($"請輸入數值");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Num1();
                int b = Num2();
                int c = a * b;
                txtAnswer.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show($"請輸入數值");
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Num1();
                int b = Num2();
                int c = a / b;
                txtAnswer.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show($"請輸入數值");
            }
        }
    }
}
