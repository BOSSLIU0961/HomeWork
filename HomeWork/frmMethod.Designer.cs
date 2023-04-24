namespace HomeWork
{
    partial class frmMethod
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
            this.txtOddNumber = new System.Windows.Forms.TextBox();
            this.btnOddNumber = new System.Windows.Forms.Button();
            this.labOddNumber = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.btnArrayOdd = new System.Windows.Forms.Button();
            this.btnBigSmall = new System.Windows.Forms.Button();
            this.btnTheLongestName = new System.Windows.Forms.Button();
            this.btnNameWithLove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnArrayBoarderOne = new System.Windows.Forms.Button();
            this.btnArrayBoarderZero = new System.Windows.Forms.Button();
            this.btnOneZeroCross = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOddNumber
            // 
            this.txtOddNumber.Location = new System.Drawing.Point(73, 12);
            this.txtOddNumber.Name = "txtOddNumber";
            this.txtOddNumber.Size = new System.Drawing.Size(96, 22);
            this.txtOddNumber.TabIndex = 0;
            // 
            // btnOddNumber
            // 
            this.btnOddNumber.Location = new System.Drawing.Point(193, 12);
            this.btnOddNumber.Name = "btnOddNumber";
            this.btnOddNumber.Size = new System.Drawing.Size(138, 22);
            this.btnOddNumber.TabIndex = 1;
            this.btnOddNumber.Text = "輸入的數為基數或偶數?";
            this.btnOddNumber.UseVisualStyleBackColor = true;
            this.btnOddNumber.Click += new System.EventHandler(this.btnOddNumber_Click);
            // 
            // labOddNumber
            // 
            this.labOddNumber.AutoSize = true;
            this.labOddNumber.Location = new System.Drawing.Point(12, 17);
            this.labOddNumber.Name = "labOddNumber";
            this.labOddNumber.Size = new System.Drawing.Size(44, 12);
            this.labOddNumber.TabIndex = 2;
            this.labOddNumber.Text = "number:";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(191, 313);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(43, 12);
            this.labTitle.TabIndex = 3;
            this.labTitle.Text = "Result : ";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labResult.ForeColor = System.Drawing.SystemColors.Window;
            this.labResult.Location = new System.Drawing.Point(240, 313);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(35, 12);
            this.labResult.TabIndex = 4;
            this.labResult.Text = "結果 :";
            // 
            // btnArrayOdd
            // 
            this.btnArrayOdd.Location = new System.Drawing.Point(12, 40);
            this.btnArrayOdd.Name = "btnArrayOdd";
            this.btnArrayOdd.Size = new System.Drawing.Size(319, 22);
            this.btnArrayOdd.TabIndex = 5;
            this.btnArrayOdd.Text = "陣列arr0711[]統計奇偶數的結果";
            this.btnArrayOdd.UseVisualStyleBackColor = true;
            this.btnArrayOdd.Click += new System.EventHandler(this.btnArrayOdd_Click);
            // 
            // btnBigSmall
            // 
            this.btnBigSmall.Location = new System.Drawing.Point(12, 68);
            this.btnBigSmall.Name = "btnBigSmall";
            this.btnBigSmall.Size = new System.Drawing.Size(319, 22);
            this.btnBigSmall.TabIndex = 6;
            this.btnBigSmall.Text = "陣列arr0711[]最大最小值";
            this.btnBigSmall.UseVisualStyleBackColor = true;
            this.btnBigSmall.Click += new System.EventHandler(this.btnBigSmall_Click);
            // 
            // btnTheLongestName
            // 
            this.btnTheLongestName.Location = new System.Drawing.Point(14, 96);
            this.btnTheLongestName.Name = "btnTheLongestName";
            this.btnTheLongestName.Size = new System.Drawing.Size(319, 22);
            this.btnTheLongestName.TabIndex = 7;
            this.btnTheLongestName.Text = "陣列arr0711[]最長的名字";
            this.btnTheLongestName.UseVisualStyleBackColor = true;
            this.btnTheLongestName.Click += new System.EventHandler(this.btnTheLongestName_Click);
            // 
            // btnNameWithLove
            // 
            this.btnNameWithLove.Location = new System.Drawing.Point(14, 124);
            this.btnNameWithLove.Name = "btnNameWithLove";
            this.btnNameWithLove.Size = new System.Drawing.Size(319, 22);
            this.btnNameWithLove.TabIndex = 8;
            this.btnNameWithLove.Text = "陣列arr0711[]有\"愛\"的名字有幾個";
            this.btnNameWithLove.UseVisualStyleBackColor = true;
            this.btnNameWithLove.Click += new System.EventHandler(this.btnNameWithLove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(73, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空結果";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnArrayBoarderOne
            // 
            this.btnArrayBoarderOne.Location = new System.Drawing.Point(577, 12);
            this.btnArrayBoarderOne.Name = "btnArrayBoarderOne";
            this.btnArrayBoarderOne.Size = new System.Drawing.Size(319, 22);
            this.btnArrayBoarderOne.TabIndex = 10;
            this.btnArrayBoarderOne.Text = "[10,10]二維陣列-邊 1,內 0";
            this.btnArrayBoarderOne.UseVisualStyleBackColor = true;
            this.btnArrayBoarderOne.Click += new System.EventHandler(this.btnArrayBoarderOne_Click);
            // 
            // btnArrayBoarderZero
            // 
            this.btnArrayBoarderZero.Location = new System.Drawing.Point(577, 40);
            this.btnArrayBoarderZero.Name = "btnArrayBoarderZero";
            this.btnArrayBoarderZero.Size = new System.Drawing.Size(319, 22);
            this.btnArrayBoarderZero.TabIndex = 11;
            this.btnArrayBoarderZero.Text = "[10,10]二維陣列-邊 0,內 1";
            this.btnArrayBoarderZero.UseVisualStyleBackColor = true;
            this.btnArrayBoarderZero.Click += new System.EventHandler(this.btnArrayBoarderZero_Click);
            // 
            // btnOneZeroCross
            // 
            this.btnOneZeroCross.Location = new System.Drawing.Point(577, 68);
            this.btnOneZeroCross.Name = "btnOneZeroCross";
            this.btnOneZeroCross.Size = new System.Drawing.Size(319, 22);
            this.btnOneZeroCross.TabIndex = 12;
            this.btnOneZeroCross.Text = "[10,10]二維陣列-010101";
            this.btnOneZeroCross.UseVisualStyleBackColor = true;
            this.btnOneZeroCross.Click += new System.EventHandler(this.btnOneZeroCross_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(577, 96);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(319, 22);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(577, 124);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(319, 22);
            this.btnSum.TabIndex = 14;
            this.btnSum.Text = "陣列arr0711[]Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(577, 152);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(319, 22);
            this.btnMax.TabIndex = 15;
            this.btnMax.Text = "陣列arr0711[]Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(577, 180);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(319, 22);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "陣列arr0711[]Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // frmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 559);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnOneZeroCross);
            this.Controls.Add(this.btnArrayBoarderZero);
            this.Controls.Add(this.btnArrayBoarderOne);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNameWithLove);
            this.Controls.Add(this.btnTheLongestName);
            this.Controls.Add(this.btnBigSmall);
            this.Controls.Add(this.btnArrayOdd);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labOddNumber);
            this.Controls.Add(this.btnOddNumber);
            this.Controls.Add(this.txtOddNumber);
            this.Name = "frmMethod";
            this.Text = "frmMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOddNumber;
        private System.Windows.Forms.Button btnOddNumber;
        private System.Windows.Forms.Label labOddNumber;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnArrayOdd;
        private System.Windows.Forms.Button btnBigSmall;
        private System.Windows.Forms.Button btnTheLongestName;
        private System.Windows.Forms.Button btnNameWithLove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnArrayBoarderOne;
        private System.Windows.Forms.Button btnArrayBoarderZero;
        private System.Windows.Forms.Button btnOneZeroCross;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}