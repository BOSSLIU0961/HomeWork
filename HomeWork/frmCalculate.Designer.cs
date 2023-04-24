namespace HomeWork
{
    partial class frmCalculate
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(342, 146);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(159, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(342, 189);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(159, 22);
            this.txtNum2.TabIndex = 1;
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Location = new System.Drawing.Point(271, 149);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(32, 12);
            this.labNum1.TabIndex = 2;
            this.labNum1.Text = "num1";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Location = new System.Drawing.Point(271, 192);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(32, 12);
            this.labNum2.TabIndex = 3;
            this.labNum2.Text = "num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = =";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Location = new System.Drawing.Point(271, 250);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(54, 12);
            this.labAnswer.TabIndex = 5;
            this.labAnswer.Text = "labAnswer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(342, 247);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(159, 22);
            this.txtAnswer.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(586, 147);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(78, 27);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(586, 177);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 27);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(586, 207);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(78, 27);
            this.btnMultiplication.TabIndex = 9;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(586, 237);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(78, 27);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // frmCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmCalculate";
            this.Text = "frmCalculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
    }
}