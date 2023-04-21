namespace HomeWork
{
    partial class frmLoan_Report
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
            this.labLoan = new System.Windows.Forms.Label();
            this.labLoanPeriod = new System.Windows.Forms.Label();
            this.labInterstRate = new System.Windows.Forms.Label();
            this.labMonthPayment = new System.Windows.Forms.Label();
            this.labTotalPayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtLoanPeriod = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtMonthPayment = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Location = new System.Drawing.Point(279, 109);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(53, 12);
            this.labLoan.TabIndex = 0;
            this.labLoan.Text = "貸款金額";
            // 
            // labLoanPeriod
            // 
            this.labLoanPeriod.AutoSize = true;
            this.labLoanPeriod.Location = new System.Drawing.Point(279, 137);
            this.labLoanPeriod.Name = "labLoanPeriod";
            this.labLoanPeriod.Size = new System.Drawing.Size(49, 12);
            this.labLoanPeriod.TabIndex = 1;
            this.labLoanPeriod.Text = "期限(年)";
            // 
            // labInterstRate
            // 
            this.labInterstRate.AutoSize = true;
            this.labInterstRate.Location = new System.Drawing.Point(279, 170);
            this.labInterstRate.Name = "labInterstRate";
            this.labInterstRate.Size = new System.Drawing.Size(46, 12);
            this.labInterstRate.TabIndex = 2;
            this.labInterstRate.Text = "利率(%)";
            // 
            // labMonthPayment
            // 
            this.labMonthPayment.AutoSize = true;
            this.labMonthPayment.Location = new System.Drawing.Point(279, 204);
            this.labMonthPayment.Name = "labMonthPayment";
            this.labMonthPayment.Size = new System.Drawing.Size(41, 12);
            this.labMonthPayment.TabIndex = 3;
            this.labMonthPayment.Text = "月付款";
            // 
            // labTotalPayment
            // 
            this.labTotalPayment.AutoSize = true;
            this.labTotalPayment.Location = new System.Drawing.Point(279, 231);
            this.labTotalPayment.Name = "labTotalPayment";
            this.labTotalPayment.Size = new System.Drawing.Size(41, 12);
            this.labTotalPayment.TabIndex = 4;
            this.labTotalPayment.Text = "總付款";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(341, 106);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.ReadOnly = true;
            this.txtLoan.Size = new System.Drawing.Size(166, 22);
            this.txtLoan.TabIndex = 5;
            // 
            // txtLoanPeriod
            // 
            this.txtLoanPeriod.Location = new System.Drawing.Point(341, 134);
            this.txtLoanPeriod.Name = "txtLoanPeriod";
            this.txtLoanPeriod.ReadOnly = true;
            this.txtLoanPeriod.Size = new System.Drawing.Size(166, 22);
            this.txtLoanPeriod.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(341, 167);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(166, 22);
            this.txtInterestRate.TabIndex = 7;
            // 
            // txtMonthPayment
            // 
            this.txtMonthPayment.Location = new System.Drawing.Point(341, 200);
            this.txtMonthPayment.Name = "txtMonthPayment";
            this.txtMonthPayment.ReadOnly = true;
            this.txtMonthPayment.Size = new System.Drawing.Size(166, 22);
            this.txtMonthPayment.TabIndex = 8;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(341, 228);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(166, 22);
            this.txtTotalPayment.TabIndex = 9;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(572, 304);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(120, 56);
            this.btnEmail.TabIndex = 10;
            this.btnEmail.Text = "E-MAIL";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // frmLoan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.txtMonthPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanPeriod);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labTotalPayment);
            this.Controls.Add(this.labMonthPayment);
            this.Controls.Add(this.labInterstRate);
            this.Controls.Add(this.labLoanPeriod);
            this.Controls.Add(this.labLoan);
            this.Name = "frmLoan_Report";
            this.Text = "frmLoan_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labLoanPeriod;
        private System.Windows.Forms.Label labInterstRate;
        private System.Windows.Forms.Label labMonthPayment;
        private System.Windows.Forms.Label labTotalPayment;
        private System.Windows.Forms.Button btnEmail;
        public System.Windows.Forms.TextBox txtLoan;
        public System.Windows.Forms.TextBox txtLoanPeriod;
        public System.Windows.Forms.TextBox txtInterestRate;
        public System.Windows.Forms.TextBox txtMonthPayment;
        public System.Windows.Forms.TextBox txtTotalPayment;
    }
}