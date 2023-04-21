namespace HomeWork
{
    partial class frmClock
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
            this.components = new System.ComponentModel.Container();
            this.tmrCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.dtpCurrentTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labCurrentTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCurrentTime
            // 
            this.tmrCurrentTime.Enabled = true;
            this.tmrCurrentTime.Tick += new System.EventHandler(this.tmrCurrentTime_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCheck);
            this.groupBox1.Controls.Add(this.dtpCurrentTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(155, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Location = new System.Drawing.Point(237, 144);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(65, 16);
            this.cbCheck.TabIndex = 3;
            this.cbCheck.Text = "set alarm";
            this.cbCheck.UseVisualStyleBackColor = true;
            // 
            // dtpCurrentTime
            // 
            this.dtpCurrentTime.CustomFormat = "";
            this.dtpCurrentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCurrentTime.Location = new System.Drawing.Point(215, 98);
            this.dtpCurrentTime.Name = "dtpCurrentTime";
            this.dtpCurrentTime.Size = new System.Drawing.Size(112, 22);
            this.dtpCurrentTime.TabIndex = 2;
            this.dtpCurrentTime.Value = new System.DateTime(2023, 4, 21, 15, 19, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alarm Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm Time";
            // 
            // labCurrentTime
            // 
            this.labCurrentTime.AutoSize = true;
            this.labCurrentTime.Location = new System.Drawing.Point(74, 56);
            this.labCurrentTime.Name = "labCurrentTime";
            this.labCurrentTime.Size = new System.Drawing.Size(33, 12);
            this.labCurrentTime.TabIndex = 1;
            this.labCurrentTime.Text = "label3";
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labCurrentTime);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmClock";
            this.Text = "frmClock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCurrentTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.DateTimePicker dtpCurrentTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCurrentTime;
    }
}