namespace HomeWork
{
    partial class frmLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labTotalLoan = new System.Windows.Forms.Label();
            this.labLoanPeriod = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtTotalLoanMoney = new System.Windows.Forms.TextBox();
            this.txtLoanPeriodYear = new System.Windows.Forms.TextBox();
            this.txtInterestRateCount = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnTotalPayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTotalLoan
            // 
            this.labTotalLoan.AutoSize = true;
            this.labTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalLoan.Location = new System.Drawing.Point(254, 98);
            this.labTotalLoan.Name = "labTotalLoan";
            this.labTotalLoan.Size = new System.Drawing.Size(86, 24);
            this.labTotalLoan.TabIndex = 0;
            this.labTotalLoan.Text = "貸款金額";
            // 
            // labLoanPeriod
            // 
            this.labLoanPeriod.AutoSize = true;
            this.labLoanPeriod.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanPeriod.Location = new System.Drawing.Point(254, 135);
            this.labLoanPeriod.Name = "labLoanPeriod";
            this.labLoanPeriod.Size = new System.Drawing.Size(79, 24);
            this.labLoanPeriod.TabIndex = 1;
            this.labLoanPeriod.Text = "期限(年)";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.Location = new System.Drawing.Point(254, 171);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(48, 24);
            this.labInterestRate.TabIndex = 2;
            this.labInterestRate.Text = "利率";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(254, 206);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(67, 24);
            this.labDownPayment.TabIndex = 3;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtTotalLoanMoney
            // 
            this.txtTotalLoanMoney.Location = new System.Drawing.Point(362, 98);
            this.txtTotalLoanMoney.Name = "txtTotalLoanMoney";
            this.txtTotalLoanMoney.Size = new System.Drawing.Size(156, 22);
            this.txtTotalLoanMoney.TabIndex = 4;
            this.txtTotalLoanMoney.Text = "100000";
            // 
            // txtLoanPeriodYear
            // 
            this.txtLoanPeriodYear.Location = new System.Drawing.Point(362, 135);
            this.txtLoanPeriodYear.Name = "txtLoanPeriodYear";
            this.txtLoanPeriodYear.Size = new System.Drawing.Size(156, 22);
            this.txtLoanPeriodYear.TabIndex = 5;
            this.txtLoanPeriodYear.Text = "2";
            // 
            // txtInterestRateCount
            // 
            this.txtInterestRateCount.Location = new System.Drawing.Point(362, 171);
            this.txtInterestRateCount.Name = "txtInterestRateCount";
            this.txtInterestRateCount.Size = new System.Drawing.Size(156, 22);
            this.txtInterestRateCount.TabIndex = 6;
            this.txtInterestRateCount.Text = "10";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(362, 206);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(156, 22);
            this.txtDownPayment.TabIndex = 7;
            this.txtDownPayment.Text = "0";
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(203, 280);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(114, 41);
            this.btnMonth.TabIndex = 8;
            this.btnMonth.Text = "PMT(月付)";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnTotalPayment
            // 
            this.btnTotalPayment.Location = new System.Drawing.Point(362, 280);
            this.btnTotalPayment.Name = "btnTotalPayment";
            this.btnTotalPayment.Size = new System.Drawing.Size(114, 41);
            this.btnTotalPayment.TabIndex = 9;
            this.btnTotalPayment.Text = "總付額";
            this.btnTotalPayment.UseVisualStyleBackColor = true;
            this.btnTotalPayment.Click += new System.EventHandler(this.btnTotalPayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(519, 280);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(114, 41);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPayment);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtInterestRateCount);
            this.Controls.Add(this.txtLoanPeriodYear);
            this.Controls.Add(this.txtTotalLoanMoney);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labLoanPeriod);
            this.Controls.Add(this.labTotalLoan);
            this.Name = "frmLoan";
            this.Text = "frmLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotalLoan;
        private System.Windows.Forms.Label labLoanPeriod;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtTotalLoanMoney;
        private System.Windows.Forms.TextBox txtLoanPeriodYear;
        private System.Windows.Forms.TextBox txtInterestRateCount;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnTotalPayment;
        private System.Windows.Forms.Button btnReport;
    }
}