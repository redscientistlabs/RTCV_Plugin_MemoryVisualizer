namespace MemoryVizualizer.UI
{
    partial class NumericTrackbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSlider = new NoFocusTrackBar();
            this.nmBox = new System.Windows.Forms.NumericUpDown();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBox)).BeginInit();
            this.SuspendLayout();
            //
            // tbSlider
            //
            this.tbSlider.Location = new System.Drawing.Point(0, 25);
            this.tbSlider.Maximum = 65536;
            this.tbSlider.Name = "tbSlider";
            this.tbSlider.Size = new System.Drawing.Size(161, 45);
            this.tbSlider.TabIndex = 0;
            this.tbSlider.TickFrequency = 6553;
            //
            // nmBox
            //
            this.nmBox.BackColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.nmBox.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
            this.nmBox.ForeColor = System.Drawing.Color.White;
            this.nmBox.Location = new System.Drawing.Point(81, 4);
            this.nmBox.Maximum = new decimal(new int[4]{
            65535,
            0,
            0,
            0});
            this.nmBox.Name = "nmBox";
            this.nmBox.Size = new System.Drawing.Size(68, 22);
            this.nmBox.TabIndex = 1;
            //
            // lbName
            //
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(3, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            //
            // NumericTrackbar
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.nmBox);
            this.Controls.Add(this.tbSlider);
            this.Name = "NumericTrackbar";
            this.Size = new System.Drawing.Size(161, 60);
            this.Load += new System.EventHandler(this.NumericTrackbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemoryVizualizer.UI.NoFocusTrackBar tbSlider;
        private System.Windows.Forms.NumericUpDown nmBox;
        private System.Windows.Forms.Label lbName;

    }
}
