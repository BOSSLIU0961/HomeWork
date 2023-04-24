namespace HomeWork
{
    partial class frmDrawPainter
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
            this.pbDrawPainter = new System.Windows.Forms.PictureBox();
            this.cdDrawPainter = new System.Windows.Forms.ColorDialog();
            this.btnDrawPainter = new System.Windows.Forms.Button();
            this.tbColor = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawPainter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDrawPainter
            // 
            this.pbDrawPainter.Location = new System.Drawing.Point(1, 1);
            this.pbDrawPainter.Name = "pbDrawPainter";
            this.pbDrawPainter.Size = new System.Drawing.Size(1304, 560);
            this.pbDrawPainter.TabIndex = 0;
            this.pbDrawPainter.TabStop = false;
            // 
            // btnDrawPainter
            // 
            this.btnDrawPainter.Location = new System.Drawing.Point(1207, 23);
            this.btnDrawPainter.Name = "btnDrawPainter";
            this.btnDrawPainter.Size = new System.Drawing.Size(72, 47);
            this.btnDrawPainter.TabIndex = 1;
            this.btnDrawPainter.Text = "顏色";
            this.btnDrawPainter.UseVisualStyleBackColor = true;
            this.btnDrawPainter.Click += new System.EventHandler(this.btnDrawPainter_Click);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(1212, 104);
            this.tbColor.Name = "tbColor";
            this.tbColor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbColor.Size = new System.Drawing.Size(45, 239);
            this.tbColor.TabIndex = 2;
            // 
            // frmDrawPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 564);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.btnDrawPainter);
            this.Controls.Add(this.pbDrawPainter);
            this.Name = "frmDrawPainter";
            this.Text = "frmDrawPainter";
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawPainter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrawPainter;
        private System.Windows.Forms.ColorDialog cdDrawPainter;
        private System.Windows.Forms.Button btnDrawPainter;
        private System.Windows.Forms.TrackBar tbColor;
    }
}