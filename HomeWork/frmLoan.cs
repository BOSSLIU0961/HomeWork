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
    public partial class frmLoan : Form
    {
        public frmLoan()
        {
            InitializeComponent();
        }

        public decimal TotalLoanMoney()
        {
            return Convert.ToDecimal(txtTotalLoanMoney.Text);
        }

        public decimal LoanPeriodYear()
        {
            return Convert.ToDecimal(txtLoanPeriodYear.Text);
        }

        public decimal InterestRateCount()
        {
            return Convert.ToDecimal(txtInterestRateCount.Text);
        }

        public decimal DownPayment()
        {
            return Convert.ToDecimal(txtDownPayment.Text);
        }

        public decimal MonthPayment()
        {
            decimal TL = TotalLoanMoney();
            decimal LP = LoanPeriodYear() * 12;
            decimal IR = InterestRateCount() / 1200;
            decimal DP = DownPayment();
            //{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1} 攤還率
            double AR = (Math.Pow(1 + (double)IR, (double)LP) * (double)IR) 
                / (Math.Pow(1 + (double)IR, (double)LP) - 1);
            //總金額 - 頭期款 * 攤還率
            return (TL - DP) * (decimal)AR;
        }

        public decimal TotalPayment()
        {
            return LoanPeriodYear() * MonthPayment() * 12;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"月付款 : {MonthPayment():C0} 元");
            //mp = MonthPayment().ToString();
        }

        private void btnTotalPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總付款 : {TotalPayment():C0} 元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string Ans01 = TotalPayment().ToString("C0");
            string Ans02 = MonthPayment().ToString("C0");
            frmLoan_Report flr = new frmLoan_Report(txtTotalLoanMoney.Text,txtLoanPeriodYear.Text, txtInterestRateCount.Text, (string)Ans01, (string)Ans02);
            flr.Show();
    
        }
        //string mp;
        //int Ans01 = Convert.ToInt32(MonthPayment());
        
        //frmLoan_Report flr = new frmLoan_Report(txtTotalLoan.Text, txtLoanPeriod.Text, txtInterestRate,);
    }
}
