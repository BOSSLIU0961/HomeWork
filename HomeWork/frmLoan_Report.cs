using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    public partial class frmLoan_Report : Form
    {
        //參數傳入
        public frmLoan_Report(string txtTotalLoanMoney, string txtLoanPeriodYear, string txtInterestRateCount, string Ans01, string Ans02)
        {
            InitializeComponent();
            txtLoan.Text = txtTotalLoanMoney;
            txtLoanPeriod.Text = txtLoanPeriodYear;
            txtInterestRate.Text = txtInterestRateCount;
            txtTotalPayment.Text = Ans01;
            txtMonthPayment.Text = Ans02;
        }
    }
}
