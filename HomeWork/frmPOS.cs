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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private int totalpayment;
        private int shoppinglist;
        private int clickcountbeer;
        private int clickcounttequila;
        private int clickcountwhisky;
        private int clickcountwine;

        public void CHECKCOUNT()
        {
            //先把TEXTBOX清空
            //檢查每種酒類的COUNT，是否大於零，是的話就輸出
            txtShoppingList.Clear();
            if(clickcountbeer > 0)
            {
                txtShoppingList.Text += ($"啤酒beer * {clickcountbeer},共NT${clickcountbeer * 120}\r\n");
            }
            if(clickcounttequila > 0)
            {
                txtShoppingList.Text += ($"龍舌蘭tequila * {clickcounttequila},共NT${clickcounttequila * 180}\r\n");
            }
            if(clickcountwhisky > 0)
            {
                txtShoppingList.Text += ($"威士忌whisky * {clickcountwhisky},共NT${clickcountwhisky * 350}\r\n");
            }
            if (clickcountwine > 0)
            {
                txtShoppingList.Text += ($"紅酒wine * {clickcountwine},共NT${clickcountwine * 320}\r\n");
            }
        }
        public void btnBeer_Click(object sender, EventArgs e)
        {
            totalpayment += 120;
            txtTotalPayment.Text = ($"NT${totalpayment.ToString()}");
            shoppinglist += 120;
            clickcountbeer++;
            CHECKCOUNT();
        }

        public void btnTequila_Click(object sender, EventArgs e)
        {
            totalpayment += 180;
            txtTotalPayment.Text = ($"NT${totalpayment.ToString()}");
            shoppinglist += 180;
            clickcounttequila++;
            CHECKCOUNT();
        }

        public void btnWhisky_Click(object sender, EventArgs e)
        {
            totalpayment += 350;
            txtTotalPayment.Text = ($"NT${totalpayment.ToString()}");
            shoppinglist += 350;
            clickcountwhisky++;
            CHECKCOUNT();
        }

        public void btnWine_Click(object sender, EventArgs e)
        {
            totalpayment += 320;
            txtTotalPayment.Text = ($"NT${totalpayment.ToString()}");
            shoppinglist += 320;
            clickcountwine++;
            CHECKCOUNT();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總共 : {totalpayment}元");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總共 : {totalpayment * 0.9}元");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShoppingList.Clear();
            txtTotalPayment.Text = "NT$";
        }
    }
}
