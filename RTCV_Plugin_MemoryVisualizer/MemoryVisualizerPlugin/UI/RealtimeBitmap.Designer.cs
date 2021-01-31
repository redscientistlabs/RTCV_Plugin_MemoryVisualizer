namespace MemoryVizualizer.UI
{
    partial class RealtimeBitmap
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
            bitmap.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.disp = new MemoryVizualizer.UI.BetterPictureDisplayer();
            ((System.ComponentModel.ISupportInitialize)(this.disp)).BeginInit();
            this.SuspendLayout();
            // 
            // disp
            // 
            this.disp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disp.Location = new System.Drawing.Point(0, 0);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(150, 150);
            this.disp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disp.TabIndex = 0;
            this.disp.TabStop = false;
            // 
            // RealtimeBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.disp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RealtimeBitmap";
            ((System.ComponentModel.ISupportInitialize)(this.disp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MemoryVizualizer.UI.BetterPictureDisplayer disp;
    }
}
