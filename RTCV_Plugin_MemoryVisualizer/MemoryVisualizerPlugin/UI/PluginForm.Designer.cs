namespace MemoryVizualizer.UI
{

    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.labelLimiter = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nRowAmt = new System.Windows.Forms.NumericUpDown();
            this.bPlusRow = new System.Windows.Forms.Button();
            this.bMinusRow = new System.Windows.Forms.Button();
            this.bRefreshDomains = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDomains = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bForwardPage = new System.Windows.Forms.Button();
            this.bBackFull = new System.Windows.Forms.Button();
            this.sliderOffset = new global::MemoryVizualizer.UI.NumericTrackbar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nAlignment = new System.Windows.Forms.NumericUpDown();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.cbLegacyLoop = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bLoop = new System.Windows.Forms.Button();
            this.bPullOnce = new System.Windows.Forms.Button();
            this.bCopyRange = new System.Windows.Forms.Button();
            this.bCopyImage = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.display = new global::MemoryVizualizer.UI.RealtimeBitmap();
            this.sliderDelay = new global::MemoryVizualizer.UI.NumericTrackbar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRowAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFormat
            // 
            this.cbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbFormat.ForeColor = System.Drawing.Color.White;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(11, 112);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(124, 21);
            this.cbFormat.TabIndex = 0;
            this.cbFormat.Tag = "color:normal";
            // 
            // labelLimiter
            // 
            this.labelLimiter.AutoSize = true;
            this.labelLimiter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelLimiter.ForeColor = System.Drawing.Color.White;
            this.labelLimiter.Location = new System.Drawing.Point(8, 96);
            this.labelLimiter.Name = "labelLimiter";
            this.labelLimiter.Size = new System.Drawing.Size(72, 13);
            this.labelLimiter.TabIndex = 1;
            this.labelLimiter.Text = "Pixel Format:";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.label6);
            this.gbSettings.Controls.Add(this.label7);
            this.gbSettings.Controls.Add(this.nRowAmt);
            this.gbSettings.Controls.Add(this.bPlusRow);
            this.gbSettings.Controls.Add(this.bMinusRow);
            this.gbSettings.Controls.Add(this.bRefreshDomains);
            this.gbSettings.Controls.Add(this.label5);
            this.gbSettings.Controls.Add(this.cbDomains);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.bForwardPage);
            this.gbSettings.Controls.Add(this.bBackFull);
            this.gbSettings.Controls.Add(this.sliderOffset);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.nAlignment);
            this.gbSettings.Controls.Add(this.nHeight);
            this.gbSettings.Controls.Add(this.nWidth);
            this.gbSettings.Controls.Add(this.cbFormat);
            this.gbSettings.Controls.Add(this.labelLimiter);
            this.gbSettings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gbSettings.ForeColor = System.Drawing.Color.White;
            this.gbSettings.Location = new System.Drawing.Point(535, 53);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(281, 290);
            this.gbSettings.TabIndex = 13;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Controls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 162;
            this.label6.Text = "Row Amt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 161;
            this.label7.Text = "Image:";
            this.label7.Visible = false;
            // 
            // nRowAmt
            // 
            this.nRowAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nRowAmt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nRowAmt.ForeColor = System.Drawing.Color.White;
            this.nRowAmt.Location = new System.Drawing.Point(136, 255);
            this.nRowAmt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nRowAmt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRowAmt.Name = "nRowAmt";
            this.nRowAmt.Size = new System.Drawing.Size(72, 22);
            this.nRowAmt.TabIndex = 159;
            this.nRowAmt.Tag = "color:normal";
            this.nRowAmt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRowAmt.ValueChanged += new System.EventHandler(this.nRowAmt_ValueChanged);
            // 
            // bPlusRow
            // 
            this.bPlusRow.BackColor = System.Drawing.Color.Gray;
            this.bPlusRow.FlatAppearance.BorderSize = 0;
            this.bPlusRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPlusRow.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bPlusRow.ForeColor = System.Drawing.Color.White;
            this.bPlusRow.Location = new System.Drawing.Point(225, 255);
            this.bPlusRow.Name = "bPlusRow";
            this.bPlusRow.Size = new System.Drawing.Size(49, 23);
            this.bPlusRow.TabIndex = 158;
            this.bPlusRow.TabStop = false;
            this.bPlusRow.Tag = "color:light1";
            this.bPlusRow.Text = "Row";
            this.bPlusRow.UseVisualStyleBackColor = false;
            this.bPlusRow.Click += new System.EventHandler(this.bPlusRow_Click);
            // 
            // bMinusRow
            // 
            this.bMinusRow.BackColor = System.Drawing.Color.Gray;
            this.bMinusRow.FlatAppearance.BorderSize = 0;
            this.bMinusRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinusRow.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bMinusRow.ForeColor = System.Drawing.Color.White;
            this.bMinusRow.Location = new System.Drawing.Point(5, 255);
            this.bMinusRow.Name = "bMinusRow";
            this.bMinusRow.Size = new System.Drawing.Size(49, 23);
            this.bMinusRow.TabIndex = 157;
            this.bMinusRow.TabStop = false;
            this.bMinusRow.Tag = "color:light1";
            this.bMinusRow.Text = "Row";
            this.bMinusRow.UseVisualStyleBackColor = false;
            this.bMinusRow.Click += new System.EventHandler(this.bMinusRow_Click);
            // 
            // bRefreshDomains
            // 
            this.bRefreshDomains.BackColor = System.Drawing.Color.Gray;
            this.bRefreshDomains.FlatAppearance.BorderSize = 0;
            this.bRefreshDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefreshDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bRefreshDomains.ForeColor = System.Drawing.Color.White;
            this.bRefreshDomains.Location = new System.Drawing.Point(148, 26);
            this.bRefreshDomains.Name = "bRefreshDomains";
            this.bRefreshDomains.Size = new System.Drawing.Size(125, 35);
            this.bRefreshDomains.TabIndex = 20;
            this.bRefreshDomains.TabStop = false;
            this.bRefreshDomains.Tag = "color:light1";
            this.bRefreshDomains.Text = "Refresh Domains";
            this.bRefreshDomains.UseVisualStyleBackColor = false;
            this.bRefreshDomains.Click += new System.EventHandler(this.bRefreshDomains_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 156;
            this.label5.Text = "Domain:";
            // 
            // cbDomains
            // 
            this.cbDomains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbDomains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbDomains.ForeColor = System.Drawing.Color.White;
            this.cbDomains.FormattingEnabled = true;
            this.cbDomains.Location = new System.Drawing.Point(11, 40);
            this.cbDomains.Name = "cbDomains";
            this.cbDomains.Size = new System.Drawing.Size(124, 21);
            this.cbDomains.TabIndex = 155;
            this.cbDomains.Tag = "color:normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "Alignment:";
            // 
            // bForwardPage
            // 
            this.bForwardPage.BackColor = System.Drawing.Color.Gray;
            this.bForwardPage.FlatAppearance.BorderSize = 0;
            this.bForwardPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bForwardPage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bForwardPage.ForeColor = System.Drawing.Color.White;
            this.bForwardPage.Location = new System.Drawing.Point(225, 191);
            this.bForwardPage.Name = "bForwardPage";
            this.bForwardPage.Size = new System.Drawing.Size(49, 60);
            this.bForwardPage.TabIndex = 152;
            this.bForwardPage.TabStop = false;
            this.bForwardPage.Tag = "color:light1";
            this.bForwardPage.Text = "Next Page";
            this.bForwardPage.UseVisualStyleBackColor = false;
            this.bForwardPage.Click += new System.EventHandler(this.bForwardPage_Click);
            // 
            // bBackFull
            // 
            this.bBackFull.BackColor = System.Drawing.Color.Gray;
            this.bBackFull.FlatAppearance.BorderSize = 0;
            this.bBackFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackFull.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bBackFull.ForeColor = System.Drawing.Color.White;
            this.bBackFull.Location = new System.Drawing.Point(5, 191);
            this.bBackFull.Name = "bBackFull";
            this.bBackFull.Size = new System.Drawing.Size(49, 60);
            this.bBackFull.TabIndex = 20;
            this.bBackFull.TabStop = false;
            this.bBackFull.Tag = "color:light1";
            this.bBackFull.Text = "Prev. Page";
            this.bBackFull.UseVisualStyleBackColor = false;
            this.bBackFull.Click += new System.EventHandler(this.bBackFull_Click);
            // 
            // sliderOffset
            // 
            this.sliderOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderOffset.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sliderOffset.Hexadecimal = true;
            this.sliderOffset.Label = "Start Addr.";
            this.sliderOffset.Location = new System.Drawing.Point(62, 191);
            this.sliderOffset.Maximum = ((long)(65535));
            this.sliderOffset.Minimum = ((long)(0));
            this.sliderOffset.Name = "sliderOffset";
            this.sliderOffset.Size = new System.Drawing.Size(161, 60);
            this.sliderOffset.TabIndex = 150;
            this.sliderOffset.Tag = "color:dark1";
            this.sliderOffset.Value = ((long)(0));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 149;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 148;
            this.label1.Text = "Width:";
            // 
            // nAlignment
            // 
            this.nAlignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nAlignment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nAlignment.ForeColor = System.Drawing.Color.White;
            this.nAlignment.Location = new System.Drawing.Point(154, 111);
            this.nAlignment.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nAlignment.Name = "nAlignment";
            this.nAlignment.ReadOnly = true;
            this.nAlignment.Size = new System.Drawing.Size(100, 22);
            this.nAlignment.TabIndex = 147;
            this.nAlignment.Tag = "color:normal";
            this.nAlignment.ValueChanged += new System.EventHandler(this.nAlignment_ValueChanged);
            // 
            // nHeight
            // 
            this.nHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nHeight.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nHeight.ForeColor = System.Drawing.Color.White;
            this.nHeight.Location = new System.Drawing.Point(154, 154);
            this.nHeight.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(100, 22);
            this.nHeight.TabIndex = 146;
            this.nHeight.Tag = "color:normal";
            this.nHeight.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nHeight.ValueChanged += new System.EventHandler(this.nHeight_ValueChanged);
            // 
            // nWidth
            // 
            this.nWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nWidth.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nWidth.ForeColor = System.Drawing.Color.White;
            this.nWidth.Location = new System.Drawing.Point(11, 154);
            this.nWidth.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(100, 22);
            this.nWidth.TabIndex = 145;
            this.nWidth.Tag = "color:normal";
            this.nWidth.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nWidth.ValueChanged += new System.EventHandler(this.nWidth_ValueChanged);
            // 
            // cbLegacyLoop
            // 
            this.cbLegacyLoop.AutoSize = true;
            this.cbLegacyLoop.Location = new System.Drawing.Point(186, 16);
            this.cbLegacyLoop.Name = "cbLegacyLoop";
            this.cbLegacyLoop.Size = new System.Drawing.Size(89, 17);
            this.cbLegacyLoop.TabIndex = 163;
            this.cbLegacyLoop.Text = "Legacy Loop";
            this.cbLegacyLoop.UseVisualStyleBackColor = true;
            this.cbLegacyLoop.Visible = false;
            this.cbLegacyLoop.CheckedChanged += new System.EventHandler(this.cbLegacyLoop_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(116, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "memory polled every x frames";
            // 
            // bLoop
            // 
            this.bLoop.BackColor = System.Drawing.Color.Gray;
            this.bLoop.FlatAppearance.BorderSize = 0;
            this.bLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLoop.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bLoop.ForeColor = System.Drawing.Color.White;
            this.bLoop.Location = new System.Drawing.Point(6, 53);
            this.bLoop.Name = "bLoop";
            this.bLoop.Size = new System.Drawing.Size(102, 48);
            this.bLoop.TabIndex = 19;
            this.bLoop.TabStop = false;
            this.bLoop.Tag = "color:light1";
            this.bLoop.Text = "Start Updating";
            this.bLoop.UseVisualStyleBackColor = false;
            this.bLoop.Click += new System.EventHandler(this.bLoop_Click);
            // 
            // bPullOnce
            // 
            this.bPullOnce.BackColor = System.Drawing.Color.Gray;
            this.bPullOnce.FlatAppearance.BorderSize = 0;
            this.bPullOnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPullOnce.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bPullOnce.ForeColor = System.Drawing.Color.White;
            this.bPullOnce.Location = new System.Drawing.Point(6, 24);
            this.bPullOnce.Name = "bPullOnce";
            this.bPullOnce.Size = new System.Drawing.Size(102, 24);
            this.bPullOnce.TabIndex = 17;
            this.bPullOnce.TabStop = false;
            this.bPullOnce.Tag = "color:light1";
            this.bPullOnce.Text = "Update Once";
            this.bPullOnce.UseVisualStyleBackColor = false;
            this.bPullOnce.Click += new System.EventHandler(this.bPullOnce_Click);
            // 
            // bCopyRange
            // 
            this.bCopyRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyRange.BackColor = System.Drawing.Color.Gray;
            this.bCopyRange.FlatAppearance.BorderSize = 0;
            this.bCopyRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopyRange.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bCopyRange.ForeColor = System.Drawing.Color.White;
            this.bCopyRange.Location = new System.Drawing.Point(535, 483);
            this.bCopyRange.Name = "bCopyRange";
            this.bCopyRange.Size = new System.Drawing.Size(140, 40);
            this.bCopyRange.TabIndex = 164;
            this.bCopyRange.TabStop = false;
            this.bCopyRange.Tag = "color:light1";
            this.bCopyRange.Text = "Copy Addresses to Clipboard";
            this.bCopyRange.UseVisualStyleBackColor = false;
            this.bCopyRange.Click += new System.EventHandler(this.bCopyRange_Click);
            // 
            // bCopyImage
            // 
            this.bCopyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopyImage.BackColor = System.Drawing.Color.Gray;
            this.bCopyImage.FlatAppearance.BorderSize = 0;
            this.bCopyImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCopyImage.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.bCopyImage.ForeColor = System.Drawing.Color.White;
            this.bCopyImage.Location = new System.Drawing.Point(686, 483);
            this.bCopyImage.Name = "bCopyImage";
            this.bCopyImage.Size = new System.Drawing.Size(130, 40);
            this.bCopyImage.TabIndex = 165;
            this.bCopyImage.TabStop = false;
            this.bCopyImage.Tag = "color:light1";
            this.bCopyImage.Text = "Save Image to File";
            this.bCopyImage.UseVisualStyleBackColor = false;
            this.bCopyImage.Click += new System.EventHandler(this.bCopyImage_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(732, 23);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(4);
            this.labelVersion.Size = new System.Drawing.Size(22, 21);
            this.labelVersion.TabIndex = 164;
            this.labelVersion.Text = "v";
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.Location = new System.Drawing.Point(9, 12);
            this.display.Margin = new System.Windows.Forms.Padding(0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(512, 512);
            this.display.TabIndex = 18;
            // 
            // sliderDelay
            // 
            this.sliderDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderDelay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sliderDelay.Hexadecimal = false;
            this.sliderDelay.Label = "Poll Rate";
            this.sliderDelay.Location = new System.Drawing.Point(114, 51);
            this.sliderDelay.Maximum = ((long)(1000));
            this.sliderDelay.Minimum = ((long)(1));
            this.sliderDelay.Name = "sliderDelay";
            this.sliderDelay.Size = new System.Drawing.Size(161, 60);
            this.sliderDelay.TabIndex = 151;
            this.sliderDelay.Tag = "color:dark1";
            this.sliderDelay.Value = ((long)(1));
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbLegacyLoop);
            this.groupBox1.Controls.Add(this.bLoop);
            this.groupBox1.Controls.Add(this.bPullOnce);
            this.groupBox1.Controls.Add(this.sliderDelay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(535, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 117);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto-Refresh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(535, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 32);
            this.label8.TabIndex = 166;
            this.label8.Text = "Memory Visualizer";
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(828, 535);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.bCopyImage);
            this.Controls.Add(this.bCopyRange);
            this.Controls.Add(this.display);
            this.Controls.Add(this.gbSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Memory Visualizer";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRowAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        public System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label labelLimiter;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.NumericUpDown nAlignment;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.NumericUpDown nWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private global::MemoryVizualizer.UI.NumericTrackbar sliderOffset;
        private global::MemoryVizualizer.UI.NumericTrackbar sliderDelay;
        private System.Windows.Forms.Button bPullOnce;
        private global::MemoryVizualizer.UI.RealtimeBitmap display;
        private System.Windows.Forms.Button bLoop;
        private System.Windows.Forms.Button bForwardPage;
        private System.Windows.Forms.Button bBackFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbDomains;
        private System.Windows.Forms.Button bRefreshDomains;
        private System.Windows.Forms.Button bPlusRow;
        private System.Windows.Forms.Button bMinusRow;
        private System.Windows.Forms.NumericUpDown nRowAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbLegacyLoop;
        private System.Windows.Forms.Button bCopyRange;
        private System.Windows.Forms.Button bCopyImage;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
    }
}
