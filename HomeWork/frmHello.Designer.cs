namespace HomeWork
{
    partial class frmHello
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
            this.labChineseName = new System.Windows.Forms.Label();
            this.labEnglishName = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labConstellation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConstellation = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labChineseName
            // 
            this.labChineseName.AutoSize = true;
            this.labChineseName.Location = new System.Drawing.Point(144, 58);
            this.labChineseName.Name = "labChineseName";
            this.labChineseName.Size = new System.Drawing.Size(29, 12);
            this.labChineseName.TabIndex = 0;
            this.labChineseName.Text = "姓名";
            // 
            // labEnglishName
            // 
            this.labEnglishName.AutoSize = true;
            this.labEnglishName.Location = new System.Drawing.Point(144, 90);
            this.labEnglishName.Name = "labEnglishName";
            this.labEnglishName.Size = new System.Drawing.Size(53, 12);
            this.labEnglishName.TabIndex = 1;
            this.labEnglishName.Text = "英文名字";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(144, 122);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(29, 12);
            this.labGender.TabIndex = 2;
            this.labGender.Text = "性別";
            // 
            // labConstellation
            // 
            this.labConstellation.AutoSize = true;
            this.labConstellation.Location = new System.Drawing.Point(144, 153);
            this.labConstellation.Name = "labConstellation";
            this.labConstellation.Size = new System.Drawing.Size(29, 12);
            this.labConstellation.TabIndex = 3;
            this.labConstellation.Text = "星座";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtConstellation
            // 
            this.txtConstellation.Location = new System.Drawing.Point(214, 150);
            this.txtConstellation.Name = "txtConstellation";
            this.txtConstellation.Size = new System.Drawing.Size(182, 22);
            this.txtConstellation.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(214, 119);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(182, 22);
            this.txtGender.TabIndex = 6;
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(214, 87);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(182, 22);
            this.txtEnglishName.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(146, 208);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(112, 57);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(284, 208);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(112, 57);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 323);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtConstellation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labConstellation);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEnglishName);
            this.Controls.Add(this.labChineseName);
            this.Name = "frmHello";
            this.Text = "frmHello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChineseName;
        private System.Windows.Forms.Label labEnglishName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labConstellation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConstellation;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEnglishName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}