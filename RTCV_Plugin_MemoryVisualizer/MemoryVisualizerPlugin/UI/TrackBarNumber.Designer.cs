namespace MemoryVizualizer.UI
{
    partial class TrackBarNumber
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
            this.nmControlValue = new System.Windows.Forms.NumericUpDown();
            this.tbControlValue = new MemoryVizualizer.UI.NoFocusTrackBar();
            this.lbControlName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmControlValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControlValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nmControlValue
            // 
            this.nmControlValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmControlValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nmControlValue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nmControlValue.ForeColor = System.Drawing.Color.White;
            this.nmControlValue.Location = new System.Drawing.Point(75, 5);
            this.nmControlValue.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.nmControlValue.Name = "nmControlValue";
            this.nmControlValue.Size = new System.Drawing.Size(72, 22);
            this.nmControlValue.TabIndex = 5;
            this.nmControlValue.Tag = "color:normal";
            // 
            // tbControlValue
            // 
            this.tbControlValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControlValue.Location = new System.Drawing.Point(0, 27);
            this.tbControlValue.Maximum = 65536;
            this.tbControlValue.Name = "tbControlValue";
            this.tbControlValue.Size = new System.Drawing.Size(161, 45);
            this.tbControlValue.TabIndex = 6;
            this.tbControlValue.TabStop = false;
            this.tbControlValue.TickFrequency = 6553;
            // 
            // lbControlName
            // 
            this.lbControlName.AutoSize = true;
            this.lbControlName.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lbControlName.ForeColor = System.Drawing.Color.White;
            this.lbControlName.Location = new System.Drawing.Point(5, 8);
            this.lbControlName.Name = "lbControlName";
            this.lbControlName.Size = new System.Drawing.Size(43, 17);
            this.lbControlName.TabIndex = 8;
            this.lbControlName.Text = "Name";
            this.lbControlName.Visible = false;
            // 
            // TrackBarNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbControlName);
            this.Controls.Add(this.nmControlValue);
            this.Controls.Add(this.tbControlValue);
            this.Name = "TrackBarNumber";
            this.Size = new System.Drawing.Size(161, 60);
            this.Load += new System.EventHandler(this.TrackBarNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmControlValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbControlValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmControlValue;
        private NoFocusTrackBar tbControlValue;
        private System.Windows.Forms.Label lbControlName;
    }
}
