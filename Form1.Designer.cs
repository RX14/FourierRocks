namespace FourierRocks
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInfo1 = new System.Windows.Forms.Label();
            this.btBrowse1 = new System.Windows.Forms.Button();
            this.lbFTitle1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbInfo2 = new System.Windows.Forms.Label();
            this.btBrowse2 = new System.Windows.Forms.Button();
            this.lbFTitle2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panAnalyse = new System.Windows.Forms.GroupBox();
            this.btAnalyse = new System.Windows.Forms.Button();
            this.cbFFTPrecision = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbFFTQual = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbOverlapSamples = new System.Windows.Forms.NumericUpDown();
            this.ckOverlap = new System.Windows.Forms.CheckBox();
            this.cbNormType = new System.Windows.Forms.ComboBox();
            this.ckNormalize = new System.Windows.Forms.CheckBox();
            this.tbTrimThres = new System.Windows.Forms.NumericUpDown();
            this.ckTrim = new System.Windows.Forms.CheckBox();
            this.lbAvgErr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurStep = new System.Windows.Forms.Label();
            this.pbProg = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFreqAvgErr = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBestOverlap = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.spTimeDiff = new FourierRocks.SpectrumUI();
            this.spErr = new FourierRocks.SpectrumUI();
            this.spDiff = new FourierRocks.SpectrumUI();
            this.sp2 = new FourierRocks.SpectrumUI();
            this.w2 = new FourierRocks.WaveUI();
            this.w1 = new FourierRocks.WaveUI();
            this.sp1 = new FourierRocks.SpectrumUI();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbChan1 = new System.Windows.Forms.ComboBox();
            this.cbChan2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panAnalyse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOverlapSamples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimThres)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChan1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbInfo1);
            this.groupBox1.Controls.Add(this.btBrowse1);
            this.groupBox1.Controls.Add(this.lbFTitle1);
            this.groupBox1.Controls.Add(this.w1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File 1";
            // 
            // lbInfo1
            // 
            this.lbInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInfo1.Location = new System.Drawing.Point(6, 128);
            this.lbInfo1.Name = "lbInfo1";
            this.lbInfo1.Size = new System.Drawing.Size(235, 21);
            this.lbInfo1.TabIndex = 5;
            // 
            // btBrowse1
            // 
            this.btBrowse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBrowse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse1.Location = new System.Drawing.Point(330, 17);
            this.btBrowse1.Name = "btBrowse1";
            this.btBrowse1.Size = new System.Drawing.Size(57, 20);
            this.btBrowse1.TabIndex = 2;
            this.btBrowse1.Text = "Browse";
            this.btBrowse1.UseVisualStyleBackColor = false;
            this.btBrowse1.Click += new System.EventHandler(this.btBrowse1_Click);
            // 
            // lbFTitle1
            // 
            this.lbFTitle1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFTitle1.Location = new System.Drawing.Point(8, 19);
            this.lbFTitle1.Name = "lbFTitle1";
            this.lbFTitle1.Size = new System.Drawing.Size(320, 17);
            this.lbFTitle1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbChan2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbInfo2);
            this.groupBox2.Controls.Add(this.btBrowse2);
            this.groupBox2.Controls.Add(this.lbFTitle2);
            this.groupBox2.Controls.Add(this.w2);
            this.groupBox2.Location = new System.Drawing.Point(399, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File 2";
            // 
            // lbInfo2
            // 
            this.lbInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbInfo2.Location = new System.Drawing.Point(6, 129);
            this.lbInfo2.Name = "lbInfo2";
            this.lbInfo2.Size = new System.Drawing.Size(235, 21);
            this.lbInfo2.TabIndex = 6;
            // 
            // btBrowse2
            // 
            this.btBrowse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBrowse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse2.Location = new System.Drawing.Point(328, 17);
            this.btBrowse2.Name = "btBrowse2";
            this.btBrowse2.Size = new System.Drawing.Size(57, 20);
            this.btBrowse2.TabIndex = 3;
            this.btBrowse2.Text = "Browse";
            this.btBrowse2.UseVisualStyleBackColor = false;
            this.btBrowse2.Click += new System.EventHandler(this.btBrowse2_Click);
            // 
            // lbFTitle2
            // 
            this.lbFTitle2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFTitle2.Location = new System.Drawing.Point(6, 19);
            this.lbFTitle2.Name = "lbFTitle2";
            this.lbFTitle2.Size = new System.Drawing.Size(320, 17);
            this.lbFTitle2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(7, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(386, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Spectral attenuation (F2/F1) +- 100 dB scale";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(402, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(386, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Spectral Average Error (+-100 dB scale)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(402, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "File 1 FFT Live Spectrum";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(5, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(386, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "File 1 FFT Live Spectrum";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panAnalyse
            // 
            this.panAnalyse.Controls.Add(this.btAnalyse);
            this.panAnalyse.Controls.Add(this.cbFFTPrecision);
            this.panAnalyse.Controls.Add(this.label16);
            this.panAnalyse.Controls.Add(this.cbFFTQual);
            this.panAnalyse.Controls.Add(this.label15);
            this.panAnalyse.Controls.Add(this.tbOverlapSamples);
            this.panAnalyse.Controls.Add(this.ckOverlap);
            this.panAnalyse.Controls.Add(this.cbNormType);
            this.panAnalyse.Controls.Add(this.ckNormalize);
            this.panAnalyse.Controls.Add(this.tbTrimThres);
            this.panAnalyse.Controls.Add(this.ckTrim);
            this.panAnalyse.Enabled = false;
            this.panAnalyse.Location = new System.Drawing.Point(12, 579);
            this.panAnalyse.Name = "panAnalyse";
            this.panAnalyse.Size = new System.Drawing.Size(296, 153);
            this.panAnalyse.TabIndex = 27;
            this.panAnalyse.TabStop = false;
            this.panAnalyse.Text = "Analyse options";
            // 
            // btAnalyse
            // 
            this.btAnalyse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAnalyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnalyse.Location = new System.Drawing.Point(9, 130);
            this.btAnalyse.Name = "btAnalyse";
            this.btAnalyse.Size = new System.Drawing.Size(281, 23);
            this.btAnalyse.TabIndex = 10;
            this.btAnalyse.Text = "Analyse";
            this.btAnalyse.UseVisualStyleBackColor = false;
            this.btAnalyse.Click += new System.EventHandler(this.btAnalyse_Click);
            // 
            // cbFFTPrecision
            // 
            this.cbFFTPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFFTPrecision.FormattingEnabled = true;
            this.cbFFTPrecision.Items.AddRange(new object[] {
            "Fastest",
            "Average",
            "Good",
            "Slowest"});
            this.cbFFTPrecision.Location = new System.Drawing.Point(121, 107);
            this.cbFFTPrecision.Name = "cbFFTPrecision";
            this.cbFFTPrecision.Size = new System.Drawing.Size(159, 21);
            this.cbFFTPrecision.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "FFT Analyse precision";
            // 
            // cbFFTQual
            // 
            this.cbFFTQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFFTQual.FormattingEnabled = true;
            this.cbFFTQual.Items.AddRange(new object[] {
            "Low",
            "Average",
            "Good",
            "Best"});
            this.cbFFTQual.Location = new System.Drawing.Point(121, 85);
            this.cbFFTQual.Name = "cbFFTQual";
            this.cbFFTQual.Size = new System.Drawing.Size(159, 21);
            this.cbFFTQual.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "FFT Spectrum Quality";
            // 
            // tbOverlapSamples
            // 
            this.tbOverlapSamples.Location = new System.Drawing.Point(187, 62);
            this.tbOverlapSamples.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.tbOverlapSamples.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbOverlapSamples.Name = "tbOverlapSamples";
            this.tbOverlapSamples.Size = new System.Drawing.Size(93, 20);
            this.tbOverlapSamples.TabIndex = 5;
            this.tbOverlapSamples.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ckOverlap
            // 
            this.ckOverlap.AutoSize = true;
            this.ckOverlap.Checked = true;
            this.ckOverlap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckOverlap.Location = new System.Drawing.Point(6, 65);
            this.ckOverlap.Name = "ckOverlap";
            this.ckOverlap.Size = new System.Drawing.Size(176, 17);
            this.ckOverlap.TabIndex = 4;
            this.ckOverlap.Text = "Det. best overlap : max samples";
            this.ckOverlap.UseVisualStyleBackColor = true;
            this.ckOverlap.CheckedChanged += new System.EventHandler(this.ckOverlap_CheckedChanged);
            // 
            // cbNormType
            // 
            this.cbNormType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbNormType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNormType.Enabled = false;
            this.cbNormType.FormattingEnabled = true;
            this.cbNormType.Items.AddRange(new object[] {
            "Increase to Highest",
            "Attenuate to Lowest"});
            this.cbNormType.Location = new System.Drawing.Point(121, 38);
            this.cbNormType.Name = "cbNormType";
            this.cbNormType.Size = new System.Drawing.Size(159, 21);
            this.cbNormType.TabIndex = 3;
            // 
            // ckNormalize
            // 
            this.ckNormalize.AutoSize = true;
            this.ckNormalize.Location = new System.Drawing.Point(6, 42);
            this.ckNormalize.Name = "ckNormalize";
            this.ckNormalize.Size = new System.Drawing.Size(109, 17);
            this.ckNormalize.TabIndex = 2;
            this.ckNormalize.Text = "Normalize volume";
            this.ckNormalize.UseVisualStyleBackColor = true;
            this.ckNormalize.CheckedChanged += new System.EventHandler(this.ckNormalize_CheckedChanged);
            // 
            // tbTrimThres
            // 
            this.tbTrimThres.Location = new System.Drawing.Point(215, 16);
            this.tbTrimThres.Name = "tbTrimThres";
            this.tbTrimThres.Size = new System.Drawing.Size(65, 20);
            this.tbTrimThres.TabIndex = 1;
            // 
            // ckTrim
            // 
            this.ckTrim.AutoSize = true;
            this.ckTrim.Checked = true;
            this.ckTrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTrim.Location = new System.Drawing.Point(6, 19);
            this.ckTrim.Name = "ckTrim";
            this.ckTrim.Size = new System.Drawing.Size(155, 17);
            this.ckTrim.TabIndex = 0;
            this.ckTrim.Text = "Trim silence : Threshold (%)";
            this.ckTrim.UseVisualStyleBackColor = true;
            this.ckTrim.CheckedChanged += new System.EventHandler(this.ckTrim_CheckedChanged);
            // 
            // lbAvgErr
            // 
            this.lbAvgErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvgErr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAvgErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvgErr.ForeColor = System.Drawing.Color.White;
            this.lbAvgErr.Location = new System.Drawing.Point(23, 44);
            this.lbAvgErr.Name = "lbAvgErr";
            this.lbAvgErr.Size = new System.Drawing.Size(94, 36);
            this.lbAvgErr.TabIndex = 34;
            this.lbAvgErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Time domain Average Error (%)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Time difference (%)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Current Step:";
            // 
            // lbCurStep
            // 
            this.lbCurStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbCurStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCurStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurStep.Location = new System.Drawing.Point(415, 588);
            this.lbCurStep.Name = "lbCurStep";
            this.lbCurStep.Size = new System.Drawing.Size(368, 20);
            this.lbCurStep.TabIndex = 30;
            // 
            // pbProg
            // 
            this.pbProg.ForeColor = System.Drawing.Color.Green;
            this.pbProg.Location = new System.Drawing.Point(416, 612);
            this.pbProg.Name = "pbProg";
            this.pbProg.Size = new System.Drawing.Size(367, 19);
            this.pbProg.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProg.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Step %:";
            // 
            // lbFreqAvgErr
            // 
            this.lbFreqAvgErr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFreqAvgErr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbFreqAvgErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFreqAvgErr.ForeColor = System.Drawing.Color.White;
            this.lbFreqAvgErr.Location = new System.Drawing.Point(198, 44);
            this.lbFreqAvgErr.Name = "lbFreqAvgErr";
            this.lbFreqAvgErr.Size = new System.Drawing.Size(94, 36);
            this.lbFreqAvgErr.TabIndex = 36;
            this.lbFreqAvgErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(175, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 37);
            this.label12.TabIndex = 35;
            this.label12.Text = "Frequency domain Average Error (dB)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbBestOverlap);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbFreqAvgErr);
            this.panel1.Controls.Add(this.lbAvgErr);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(317, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 92);
            this.panel1.TabIndex = 37;
            // 
            // lbBestOverlap
            // 
            this.lbBestOverlap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbBestOverlap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBestOverlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestOverlap.ForeColor = System.Drawing.Color.Black;
            this.lbBestOverlap.Location = new System.Drawing.Point(358, 44);
            this.lbBestOverlap.Name = "lbBestOverlap";
            this.lbBestOverlap.Size = new System.Drawing.Size(94, 36);
            this.lbBestOverlap.TabIndex = 38;
            this.lbBestOverlap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(352, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 37);
            this.label13.TabIndex = 37;
            this.label13.Text = "Best Overlap (samples)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spTimeDiff
            // 
            this.spTimeDiff.BackColor = System.Drawing.Color.Black;
            this.spTimeDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spTimeDiff.FFTData = null;
            this.spTimeDiff.Location = new System.Drawing.Point(5, 182);
            this.spTimeDiff.Name = "spTimeDiff";
            this.spTimeDiff.Size = new System.Drawing.Size(783, 129);
            this.spTimeDiff.TabIndex = 29;
            // 
            // spErr
            // 
            this.spErr.BackColor = System.Drawing.Color.Black;
            this.spErr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spErr.FFTData = null;
            this.spErr.Location = new System.Drawing.Point(402, 466);
            this.spErr.Name = "spErr";
            this.spErr.Size = new System.Drawing.Size(386, 107);
            this.spErr.TabIndex = 19;
            // 
            // spDiff
            // 
            this.spDiff.BackColor = System.Drawing.Color.Black;
            this.spDiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spDiff.FFTData = null;
            this.spDiff.Location = new System.Drawing.Point(7, 466);
            this.spDiff.Name = "spDiff";
            this.spDiff.Size = new System.Drawing.Size(386, 107);
            this.spDiff.TabIndex = 17;
            // 
            // sp2
            // 
            this.sp2.BackColor = System.Drawing.Color.Black;
            this.sp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sp2.FFTData = null;
            this.sp2.Location = new System.Drawing.Point(402, 336);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(386, 107);
            this.sp2.TabIndex = 15;
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.White;
            this.w2.Location = new System.Drawing.Point(6, 39);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(378, 86);
            this.w2.TabIndex = 1;
            this.w2.WaveFile = null;
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.White;
            this.w1.Location = new System.Drawing.Point(6, 39);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(378, 86);
            this.w1.TabIndex = 0;
            this.w1.WaveFile = null;
            // 
            // sp1
            // 
            this.sp1.BackColor = System.Drawing.Color.Black;
            this.sp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sp1.FFTData = null;
            this.sp1.Location = new System.Drawing.Point(5, 335);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(386, 107);
            this.sp1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Compare Channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Compare Channel";
            // 
            // cbChan1
            // 
            this.cbChan1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChan1.FormattingEnabled = true;
            this.cbChan1.Location = new System.Drawing.Point(339, 128);
            this.cbChan1.Name = "cbChan1";
            this.cbChan1.Size = new System.Drawing.Size(42, 21);
            this.cbChan1.TabIndex = 7;
            // 
            // cbChan2
            // 
            this.cbChan2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChan2.FormattingEnabled = true;
            this.cbChan2.Location = new System.Drawing.Point(339, 129);
            this.cbChan2.Name = "cbChan2";
            this.cbChan2.Size = new System.Drawing.Size(42, 21);
            this.cbChan2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spTimeDiff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbProg);
            this.Controls.Add(this.lbCurStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panAnalyse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spErr);
            this.Controls.Add(this.spDiff);
            this.Controls.Add(this.sp2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sp1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "FourierRocks WAV Analysis - Primiano Tucci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panAnalyse.ResumeLayout(false);
            this.panAnalyse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOverlapSamples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTrimThres)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btBrowse1;
        private System.Windows.Forms.Label lbFTitle1;
        private WaveUI w1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBrowse2;
        private System.Windows.Forms.Label lbFTitle2;
        private WaveUI w2;
        private SpectrumUI sp1;
        private System.Windows.Forms.Label lbInfo1;
        private System.Windows.Forms.Label lbInfo2;
        private SpectrumUI sp2;
        private SpectrumUI spDiff;
        private SpectrumUI spErr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox panAnalyse;
        private System.Windows.Forms.ComboBox cbNormType;
        private System.Windows.Forms.CheckBox ckNormalize;
        private System.Windows.Forms.NumericUpDown tbTrimThres;
        private System.Windows.Forms.CheckBox ckTrim;
        private System.Windows.Forms.NumericUpDown tbOverlapSamples;
        private System.Windows.Forms.CheckBox ckOverlap;
        private System.Windows.Forms.ComboBox cbFFTQual;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btAnalyse;
        private System.Windows.Forms.ComboBox cbFFTPrecision;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private SpectrumUI spTimeDiff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurStep;
        private System.Windows.Forms.ProgressBar pbProg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAvgErr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFreqAvgErr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBestOverlap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbChan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChan2;
        private System.Windows.Forms.Label label6;


    }
}

