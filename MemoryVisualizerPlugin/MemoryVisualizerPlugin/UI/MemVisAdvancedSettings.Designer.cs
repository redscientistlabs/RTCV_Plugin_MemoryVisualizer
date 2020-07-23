namespace MemoryVisualizerPlugin.UI
{
    partial class MemVisAdvancedSettings
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMultithread = new System.Windows.Forms.GroupBox();
            this.lbRows = new System.Windows.Forms.Label();
            this.nPixPerThread = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.gbMultithread.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPixPerThread)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // gbMultithread
            // 
            this.gbMultithread.Controls.Add(this.nPixPerThread);
            this.gbMultithread.Controls.Add(this.lbRows);
            this.gbMultithread.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMultithread.ForeColor = System.Drawing.Color.White;
            this.gbMultithread.Location = new System.Drawing.Point(12, 27);
            this.gbMultithread.Name = "gbMultithread";
            this.gbMultithread.Size = new System.Drawing.Size(237, 393);
            this.gbMultithread.TabIndex = 1;
            this.gbMultithread.TabStop = false;
            this.gbMultithread.Text = "Multithreading";
            // 
            // lbRows
            // 
            this.lbRows.AutoSize = true;
            this.lbRows.Location = new System.Drawing.Point(7, 22);
            this.lbRows.Name = "lbRows";
            this.lbRows.Size = new System.Drawing.Size(93, 13);
            this.lbRows.TabIndex = 0;
            this.lbRows.Text = "Pixels Per Thread";
            // 
            // nPixPerThread
            // 
            this.nPixPerThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nPixPerThread.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nPixPerThread.ForeColor = System.Drawing.Color.White;
            this.nPixPerThread.Location = new System.Drawing.Point(10, 38);
            this.nPixPerThread.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nPixPerThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPixPerThread.Name = "nPixPerThread";
            this.nPixPerThread.Size = new System.Drawing.Size(100, 22);
            this.nPixPerThread.TabIndex = 146;
            this.nPixPerThread.Tag = "color:normal";
            this.nPixPerThread.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // MemVisAdvancedSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(283, 460);
            this.Controls.Add(this.gbMultithread);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MemVisAdvancedSettings";
            this.Tag = "color:dark1";
            this.Text = "MemVisAdvancedSettings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbMultithread.ResumeLayout(false);
            this.gbMultithread.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPixPerThread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMultithread;
        private System.Windows.Forms.Label lbRows;
        private System.Windows.Forms.NumericUpDown nPixPerThread;
    }
}