namespace HomeWork
{
    partial class frmPOS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWine = new System.Windows.Forms.Button();
            this.labMENU = new System.Windows.Forms.Label();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.labTotalPaymet = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.labCreditCard = new System.Windows.Forms.Label();
            this.labPaymentMethod = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtShoppingList = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labShoppingList = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnWine);
            this.panel1.Controls.Add(this.labMENU);
            this.panel1.Controls.Add(this.btnWhisky);
            this.panel1.Controls.Add(this.btnBeer);
            this.panel1.Controls.Add(this.btnTequila);
            this.panel1.Location = new System.Drawing.Point(24, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 329);
            this.panel1.TabIndex = 1;
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(118, 147);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(92, 96);
            this.btnWine.TabIndex = 11;
            this.btnWine.Text = "紅酒\r\nWINE\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // labMENU
            // 
            this.labMENU.AutoSize = true;
            this.labMENU.Location = new System.Drawing.Point(12, 9);
            this.labMENU.Name = "labMENU";
            this.labMENU.Size = new System.Drawing.Size(62, 12);
            this.labMENU.TabIndex = 0;
            this.labMENU.Text = "菜單MENU";
            // 
            // btnWhisky
            // 
            this.btnWhisky.Location = new System.Drawing.Point(20, 147);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(92, 96);
            this.btnWhisky.TabIndex = 10;
            this.btnWhisky.Text = "威士忌\r\nWHISKY\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(20, 45);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(92, 96);
            this.btnBeer.TabIndex = 8;
            this.btnBeer.Text = "啤酒\r\nBEER\r\nNT$120\r\n";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Location = new System.Drawing.Point(118, 45);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(92, 96);
            this.btnTequila.TabIndex = 9;
            this.btnTequila.Text = "龍舌蘭\r\nTEQUILA\r\nNT$180\r\n";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTotalPayment);
            this.panel2.Controls.Add(this.labTotalPaymet);
            this.panel2.Location = new System.Drawing.Point(296, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 99);
            this.panel2.TabIndex = 2;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtTotalPayment.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalPayment.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotalPayment.Location = new System.Drawing.Point(27, 36);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalPayment.Size = new System.Drawing.Size(176, 33);
            this.txtTotalPayment.TabIndex = 6;
            this.txtTotalPayment.Text = "NT$";
            this.txtTotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPayment.WordWrap = false;
            // 
            // labTotalPaymet
            // 
            this.labTotalPaymet.AutoSize = true;
            this.labTotalPaymet.Location = new System.Drawing.Point(15, 9);
            this.labTotalPaymet.Name = "labTotalPaymet";
            this.labTotalPaymet.Size = new System.Drawing.Size(119, 12);
            this.labTotalPaymet.TabIndex = 5;
            this.labTotalPaymet.Text = "消費金額  totalpayment";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCash);
            this.panel3.Controls.Add(this.btnCreditCard);
            this.panel3.Controls.Add(this.labCreditCard);
            this.panel3.Controls.Add(this.labPaymentMethod);
            this.panel3.Location = new System.Drawing.Point(296, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 137);
            this.panel3.TabIndex = 3;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(38, 51);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(67, 39);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(125, 51);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(67, 39);
            this.btnCreditCard.TabIndex = 8;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // labCreditCard
            // 
            this.labCreditCard.AutoSize = true;
            this.labCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCreditCard.Location = new System.Drawing.Point(123, 113);
            this.labCreditCard.Name = "labCreditCard";
            this.labCreditCard.Size = new System.Drawing.Size(91, 14);
            this.labCreditCard.TabIndex = 5;
            this.labCreditCard.Text = "信用卡九折優惠";
            // 
            // labPaymentMethod
            // 
            this.labPaymentMethod.AutoSize = true;
            this.labPaymentMethod.Location = new System.Drawing.Point(15, 13);
            this.labPaymentMethod.Name = "labPaymentMethod";
            this.labPaymentMethod.Size = new System.Drawing.Size(137, 12);
            this.labPaymentMethod.TabIndex = 5;
            this.labPaymentMethod.Text = "付款方式  payment method";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtShoppingList);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.labShoppingList);
            this.panel4.Location = new System.Drawing.Point(565, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 329);
            this.panel4.TabIndex = 4;
            // 
            // txtShoppingList
            // 
            this.txtShoppingList.Location = new System.Drawing.Point(30, 36);
            this.txtShoppingList.Multiline = true;
            this.txtShoppingList.Name = "txtShoppingList";
            this.txtShoppingList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShoppingList.Size = new System.Drawing.Size(176, 243);
            this.txtShoppingList.TabIndex = 7;
            this.txtShoppingList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labShoppingList
            // 
            this.labShoppingList.AutoSize = true;
            this.labShoppingList.Location = new System.Drawing.Point(15, 9);
            this.labShoppingList.Name = "labShoppingList";
            this.labShoppingList.Size = new System.Drawing.Size(118, 12);
            this.labShoppingList.TabIndex = 5;
            this.labShoppingList.Text = "購物清單  shopping list";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPOS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmPOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Label labMENU;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label labTotalPaymet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Label labCreditCard;
        private System.Windows.Forms.Label labPaymentMethod;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtShoppingList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labShoppingList;
        private System.Diagnostics.EventLog eventLog1;
    }
}