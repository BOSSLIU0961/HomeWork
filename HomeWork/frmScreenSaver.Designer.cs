namespace HomeWork
{
    partial class frmScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreenSaver));
            this.pbNiceBoat = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNiceBoat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNiceBoat
            // 
            this.pbNiceBoat.Image = ((System.Drawing.Image)(resources.GetObject("pbNiceBoat.Image")));
            this.pbNiceBoat.Location = new System.Drawing.Point(1, 11);
            this.pbNiceBoat.Name = "pbNiceBoat";
            this.pbNiceBoat.Size = new System.Drawing.Size(262, 199);
            this.pbNiceBoat.TabIndex = 0;
            this.pbNiceBoat.TabStop = false;
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // frmScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbNiceBoat);
            this.Name = "frmScreenSaver";
            this.Text = "frmScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmScreenSaver_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbNiceBoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNiceBoat;
        private System.Windows.Forms.Timer tmrMove;
    }
}