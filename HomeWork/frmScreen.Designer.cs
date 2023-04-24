namespace HomeWork
{
    partial class frmScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreen));
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.tmrScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreen
            // 
            this.pbScreen.Image = ((System.Drawing.Image)(resources.GetObject("pbScreen.Image")));
            this.pbScreen.Location = new System.Drawing.Point(5, 4);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(260, 251);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreen.TabIndex = 0;
            this.pbScreen.TabStop = false;
            this.pbScreen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbScreen_MouseDoubleClick);
            // 
            // tmrScreen
            // 
            this.tmrScreen.Enabled = true;
            this.tmrScreen.Interval = 20;
            this.tmrScreen.Tick += new System.EventHandler(this.tmrScreen_Tick);
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreen";
            this.Text = "frmScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.Timer tmrScreen;
    }
}