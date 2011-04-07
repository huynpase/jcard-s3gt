namespace JCard
{
    partial class fSetting
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbMeaning = new System.Windows.Forms.GroupBox();
            this.numMeaningFontsize = new System.Windows.Forms.NumericUpDown();
            this.pnlMeaningFClr = new System.Windows.Forms.Panel();
            this.pnlMeaningBgClr = new System.Windows.Forms.Panel();
            this.chkboxMeaning = new System.Windows.Forms.CheckBox();
            this.lblMeaningFColor = new System.Windows.Forms.Label();
            this.lblMeaningFontsize = new System.Windows.Forms.Label();
            this.lblMeaningBgColor = new System.Windows.Forms.Label();
            this.lblHiraganaFontsize = new System.Windows.Forms.Label();
            this.lblKanjiFontsize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDisTime = new System.Windows.Forms.NumericUpDown();
            this.numDelayTime = new System.Windows.Forms.NumericUpDown();
            this.radTopLeft = new System.Windows.Forms.RadioButton();
            this.radBottRight = new System.Windows.Forms.RadioButton();
            this.radTopRight = new System.Windows.Forms.RadioButton();
            this.radBottLeft = new System.Windows.Forms.RadioButton();
            this.grbKanji = new System.Windows.Forms.GroupBox();
            this.numKanjiFontsize = new System.Windows.Forms.NumericUpDown();
            this.pnlKanjiFClr = new System.Windows.Forms.Panel();
            this.pnlKanjiBgClr = new System.Windows.Forms.Panel();
            this.chkboxKanji = new System.Windows.Forms.CheckBox();
            this.lblKanjiFColor = new System.Windows.Forms.Label();
            this.lblKanjiBgColor = new System.Windows.Forms.Label();
            this.grbHiragana = new System.Windows.Forms.GroupBox();
            this.numHiraganaFontsize = new System.Windows.Forms.NumericUpDown();
            this.pnlHiraganaFClr = new System.Windows.Forms.Panel();
            this.pnlHiraganaBgClr = new System.Windows.Forms.Panel();
            this.chkboxHiragana = new System.Windows.Forms.CheckBox();
            this.lblHiraganaFColor = new System.Windows.Forms.Label();
            this.lblHiraganaBgColor = new System.Windows.Forms.Label();
            this.grbMeaning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeaningFontsize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTime)).BeginInit();
            this.grbKanji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKanjiFontsize)).BeginInit();
            this.grbHiragana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiraganaFontsize)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbMeaning
            // 
            this.grbMeaning.BackColor = System.Drawing.Color.Transparent;
            this.grbMeaning.Controls.Add(this.numMeaningFontsize);
            this.grbMeaning.Controls.Add(this.pnlMeaningFClr);
            this.grbMeaning.Controls.Add(this.pnlMeaningBgClr);
            this.grbMeaning.Controls.Add(this.chkboxMeaning);
            this.grbMeaning.Controls.Add(this.lblMeaningFColor);
            this.grbMeaning.Controls.Add(this.lblMeaningFontsize);
            this.grbMeaning.Controls.Add(this.lblMeaningBgColor);
            this.grbMeaning.Location = new System.Drawing.Point(10, 280);
            this.grbMeaning.Name = "grbMeaning";
            this.grbMeaning.Size = new System.Drawing.Size(359, 74);
            this.grbMeaning.TabIndex = 3;
            this.grbMeaning.TabStop = false;
            this.grbMeaning.Text = "Meaning";
            // 
            // numMeaningFontsize
            // 
            this.numMeaningFontsize.Location = new System.Drawing.Point(263, 15);
            this.numMeaningFontsize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMeaningFontsize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMeaningFontsize.Name = "numMeaningFontsize";
            this.numMeaningFontsize.Size = new System.Drawing.Size(52, 20);
            this.numMeaningFontsize.TabIndex = 2;
            this.numMeaningFontsize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMeaningFontsize.Enter += new System.EventHandler(this.numDelayTime_Enter);
            this.numMeaningFontsize.Leave += new System.EventHandler(this.numDelayTime_Leave);
            // 
            // pnlMeaningFClr
            // 
            this.pnlMeaningFClr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMeaningFClr.Location = new System.Drawing.Point(263, 42);
            this.pnlMeaningFClr.Name = "pnlMeaningFClr";
            this.pnlMeaningFClr.Size = new System.Drawing.Size(26, 25);
            this.pnlMeaningFClr.TabIndex = 6;
            this.pnlMeaningFClr.DoubleClick += new System.EventHandler(this.pnlMeaningFClr_DoubleClick);
            // 
            // pnlMeaningBgClr
            // 
            this.pnlMeaningBgClr.BackColor = System.Drawing.Color.Maroon;
            this.pnlMeaningBgClr.Location = new System.Drawing.Point(118, 42);
            this.pnlMeaningBgClr.Name = "pnlMeaningBgClr";
            this.pnlMeaningBgClr.Size = new System.Drawing.Size(26, 25);
            this.pnlMeaningBgClr.TabIndex = 4;
            this.pnlMeaningBgClr.DoubleClick += new System.EventHandler(this.pnlMeaningBgClr_DoubleClick);
            // 
            // chkboxMeaning
            // 
            this.chkboxMeaning.AutoSize = true;
            this.chkboxMeaning.Location = new System.Drawing.Point(12, 16);
            this.chkboxMeaning.Name = "chkboxMeaning";
            this.chkboxMeaning.Size = new System.Drawing.Size(83, 17);
            this.chkboxMeaning.TabIndex = 0;
            this.chkboxMeaning.Text = "Is Displayed";
            this.chkboxMeaning.UseVisualStyleBackColor = true;
            // 
            // lblMeaningFColor
            // 
            this.lblMeaningFColor.AutoSize = true;
            this.lblMeaningFColor.Location = new System.Drawing.Point(177, 54);
            this.lblMeaningFColor.Name = "lblMeaningFColor";
            this.lblMeaningFColor.Size = new System.Drawing.Size(55, 13);
            this.lblMeaningFColor.TabIndex = 5;
            this.lblMeaningFColor.Text = "Font Color";
            // 
            // lblMeaningFontsize
            // 
            this.lblMeaningFontsize.AutoSize = true;
            this.lblMeaningFontsize.Location = new System.Drawing.Point(177, 17);
            this.lblMeaningFontsize.Name = "lblMeaningFontsize";
            this.lblMeaningFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblMeaningFontsize.TabIndex = 1;
            this.lblMeaningFontsize.Text = "Font Size:";
            // 
            // lblMeaningBgColor
            // 
            this.lblMeaningBgColor.AutoSize = true;
            this.lblMeaningBgColor.Location = new System.Drawing.Point(9, 54);
            this.lblMeaningBgColor.Name = "lblMeaningBgColor";
            this.lblMeaningBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblMeaningBgColor.TabIndex = 3;
            this.lblMeaningBgColor.Text = "Background Color";
            // 
            // lblHiraganaFontsize
            // 
            this.lblHiraganaFontsize.AutoSize = true;
            this.lblHiraganaFontsize.Location = new System.Drawing.Point(177, 18);
            this.lblHiraganaFontsize.Name = "lblHiraganaFontsize";
            this.lblHiraganaFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblHiraganaFontsize.TabIndex = 1;
            this.lblHiraganaFontsize.Text = "Font Size:";
            // 
            // lblKanjiFontsize
            // 
            this.lblKanjiFontsize.AutoSize = true;
            this.lblKanjiFontsize.Location = new System.Drawing.Point(177, 18);
            this.lblKanjiFontsize.Name = "lblKanjiFontsize";
            this.lblKanjiFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblKanjiFontsize.TabIndex = 1;
            this.lblKanjiFontsize.Text = "Font Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Display Time (s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delay Time (s):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numDisTime);
            this.groupBox1.Controls.Add(this.numDelayTime);
            this.groupBox1.Controls.Add(this.radTopLeft);
            this.groupBox1.Controls.Add(this.radBottRight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radTopRight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radBottLeft);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // numDisTime
            // 
            this.numDisTime.Location = new System.Drawing.Point(263, 73);
            this.numDisTime.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDisTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDisTime.Name = "numDisTime";
            this.numDisTime.Size = new System.Drawing.Size(52, 20);
            this.numDisTime.TabIndex = 7;
            this.numDisTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDisTime.Enter += new System.EventHandler(this.numDelayTime_Enter);
            this.numDisTime.Leave += new System.EventHandler(this.numDelayTime_Leave);
            // 
            // numDelayTime
            // 
            this.numDelayTime.Location = new System.Drawing.Point(118, 73);
            this.numDelayTime.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDelayTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelayTime.Name = "numDelayTime";
            this.numDelayTime.Size = new System.Drawing.Size(52, 20);
            this.numDelayTime.TabIndex = 5;
            this.numDelayTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelayTime.Enter += new System.EventHandler(this.numDelayTime_Enter);
            this.numDelayTime.Leave += new System.EventHandler(this.numDelayTime_Leave);
            // 
            // radTopLeft
            // 
            this.radTopLeft.AutoSize = true;
            this.radTopLeft.Location = new System.Drawing.Point(12, 20);
            this.radTopLeft.Name = "radTopLeft";
            this.radTopLeft.Size = new System.Drawing.Size(65, 17);
            this.radTopLeft.TabIndex = 0;
            this.radTopLeft.Text = "Top Left";
            this.radTopLeft.UseVisualStyleBackColor = true;
            // 
            // radBottRight
            // 
            this.radBottRight.AutoSize = true;
            this.radBottRight.Checked = true;
            this.radBottRight.Location = new System.Drawing.Point(180, 43);
            this.radBottRight.Name = "radBottRight";
            this.radBottRight.Size = new System.Drawing.Size(86, 17);
            this.radBottRight.TabIndex = 3;
            this.radBottRight.TabStop = true;
            this.radBottRight.Text = "Bottom Right";
            this.radBottRight.UseVisualStyleBackColor = true;
            // 
            // radTopRight
            // 
            this.radTopRight.AutoSize = true;
            this.radTopRight.Location = new System.Drawing.Point(180, 20);
            this.radTopRight.Name = "radTopRight";
            this.radTopRight.Size = new System.Drawing.Size(72, 17);
            this.radTopRight.TabIndex = 1;
            this.radTopRight.Text = "Top Right";
            this.radTopRight.UseVisualStyleBackColor = true;
            // 
            // radBottLeft
            // 
            this.radBottLeft.AutoSize = true;
            this.radBottLeft.Location = new System.Drawing.Point(12, 42);
            this.radBottLeft.Name = "radBottLeft";
            this.radBottLeft.Size = new System.Drawing.Size(79, 17);
            this.radBottLeft.TabIndex = 2;
            this.radBottLeft.Text = "Bottom Left";
            this.radBottLeft.UseVisualStyleBackColor = true;
            // 
            // grbKanji
            // 
            this.grbKanji.BackColor = System.Drawing.Color.Transparent;
            this.grbKanji.Controls.Add(this.numKanjiFontsize);
            this.grbKanji.Controls.Add(this.pnlKanjiFClr);
            this.grbKanji.Controls.Add(this.pnlKanjiBgClr);
            this.grbKanji.Controls.Add(this.chkboxKanji);
            this.grbKanji.Controls.Add(this.lblKanjiFColor);
            this.grbKanji.Controls.Add(this.lblKanjiBgColor);
            this.grbKanji.Controls.Add(this.lblKanjiFontsize);
            this.grbKanji.Location = new System.Drawing.Point(10, 116);
            this.grbKanji.Name = "grbKanji";
            this.grbKanji.Size = new System.Drawing.Size(359, 76);
            this.grbKanji.TabIndex = 1;
            this.grbKanji.TabStop = false;
            this.grbKanji.Text = "Kanji";
            // 
            // numKanjiFontsize
            // 
            this.numKanjiFontsize.Location = new System.Drawing.Point(263, 16);
            this.numKanjiFontsize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numKanjiFontsize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKanjiFontsize.Name = "numKanjiFontsize";
            this.numKanjiFontsize.Size = new System.Drawing.Size(52, 20);
            this.numKanjiFontsize.TabIndex = 2;
            this.numKanjiFontsize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numKanjiFontsize.Enter += new System.EventHandler(this.numDelayTime_Enter);
            this.numKanjiFontsize.Leave += new System.EventHandler(this.numDelayTime_Leave);
            // 
            // pnlKanjiFClr
            // 
            this.pnlKanjiFClr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlKanjiFClr.Location = new System.Drawing.Point(263, 43);
            this.pnlKanjiFClr.Name = "pnlKanjiFClr";
            this.pnlKanjiFClr.Size = new System.Drawing.Size(26, 25);
            this.pnlKanjiFClr.TabIndex = 6;
            this.pnlKanjiFClr.DoubleClick += new System.EventHandler(this.pnlKanjiFClr_DoubleClick);
            // 
            // pnlKanjiBgClr
            // 
            this.pnlKanjiBgClr.BackColor = System.Drawing.Color.Maroon;
            this.pnlKanjiBgClr.Location = new System.Drawing.Point(118, 43);
            this.pnlKanjiBgClr.Name = "pnlKanjiBgClr";
            this.pnlKanjiBgClr.Size = new System.Drawing.Size(26, 25);
            this.pnlKanjiBgClr.TabIndex = 4;
            this.pnlKanjiBgClr.DoubleClick += new System.EventHandler(this.pnlKanjiBgClr_DoubleClick);
            // 
            // chkboxKanji
            // 
            this.chkboxKanji.AutoSize = true;
            this.chkboxKanji.Location = new System.Drawing.Point(12, 17);
            this.chkboxKanji.Name = "chkboxKanji";
            this.chkboxKanji.Size = new System.Drawing.Size(83, 17);
            this.chkboxKanji.TabIndex = 0;
            this.chkboxKanji.Text = "Is Displayed";
            this.chkboxKanji.UseVisualStyleBackColor = true;
            // 
            // lblKanjiFColor
            // 
            this.lblKanjiFColor.AutoSize = true;
            this.lblKanjiFColor.Location = new System.Drawing.Point(177, 55);
            this.lblKanjiFColor.Name = "lblKanjiFColor";
            this.lblKanjiFColor.Size = new System.Drawing.Size(55, 13);
            this.lblKanjiFColor.TabIndex = 5;
            this.lblKanjiFColor.Text = "Font Color";
            // 
            // lblKanjiBgColor
            // 
            this.lblKanjiBgColor.AutoSize = true;
            this.lblKanjiBgColor.Location = new System.Drawing.Point(9, 55);
            this.lblKanjiBgColor.Name = "lblKanjiBgColor";
            this.lblKanjiBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblKanjiBgColor.TabIndex = 3;
            this.lblKanjiBgColor.Text = "Background Color";
            // 
            // grbHiragana
            // 
            this.grbHiragana.BackColor = System.Drawing.Color.Transparent;
            this.grbHiragana.Controls.Add(this.numHiraganaFontsize);
            this.grbHiragana.Controls.Add(this.pnlHiraganaFClr);
            this.grbHiragana.Controls.Add(this.pnlHiraganaBgClr);
            this.grbHiragana.Controls.Add(this.chkboxHiragana);
            this.grbHiragana.Controls.Add(this.lblHiraganaFColor);
            this.grbHiragana.Controls.Add(this.lblHiraganaBgColor);
            this.grbHiragana.Controls.Add(this.lblHiraganaFontsize);
            this.grbHiragana.Location = new System.Drawing.Point(10, 198);
            this.grbHiragana.Name = "grbHiragana";
            this.grbHiragana.Size = new System.Drawing.Size(359, 76);
            this.grbHiragana.TabIndex = 2;
            this.grbHiragana.TabStop = false;
            this.grbHiragana.Text = "Hiragana";
            // 
            // numHiraganaFontsize
            // 
            this.numHiraganaFontsize.Location = new System.Drawing.Point(263, 16);
            this.numHiraganaFontsize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numHiraganaFontsize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHiraganaFontsize.Name = "numHiraganaFontsize";
            this.numHiraganaFontsize.Size = new System.Drawing.Size(52, 20);
            this.numHiraganaFontsize.TabIndex = 2;
            this.numHiraganaFontsize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHiraganaFontsize.Enter += new System.EventHandler(this.numDelayTime_Enter);
            this.numHiraganaFontsize.Leave += new System.EventHandler(this.numDelayTime_Leave);
            // 
            // pnlHiraganaFClr
            // 
            this.pnlHiraganaFClr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHiraganaFClr.Location = new System.Drawing.Point(263, 43);
            this.pnlHiraganaFClr.Name = "pnlHiraganaFClr";
            this.pnlHiraganaFClr.Size = new System.Drawing.Size(26, 25);
            this.pnlHiraganaFClr.TabIndex = 6;
            this.pnlHiraganaFClr.DoubleClick += new System.EventHandler(this.pnlHiraganaFClr_DoubleClick);
            // 
            // pnlHiraganaBgClr
            // 
            this.pnlHiraganaBgClr.BackColor = System.Drawing.Color.Maroon;
            this.pnlHiraganaBgClr.Location = new System.Drawing.Point(118, 43);
            this.pnlHiraganaBgClr.Name = "pnlHiraganaBgClr";
            this.pnlHiraganaBgClr.Size = new System.Drawing.Size(26, 25);
            this.pnlHiraganaBgClr.TabIndex = 4;
            this.pnlHiraganaBgClr.DoubleClick += new System.EventHandler(this.pnlHiraganaBgClr_DoubleClick);
            // 
            // chkboxHiragana
            // 
            this.chkboxHiragana.AutoSize = true;
            this.chkboxHiragana.Location = new System.Drawing.Point(12, 17);
            this.chkboxHiragana.Name = "chkboxHiragana";
            this.chkboxHiragana.Size = new System.Drawing.Size(83, 17);
            this.chkboxHiragana.TabIndex = 0;
            this.chkboxHiragana.Text = "Is Displayed";
            this.chkboxHiragana.UseVisualStyleBackColor = true;
            // 
            // lblHiraganaFColor
            // 
            this.lblHiraganaFColor.AutoSize = true;
            this.lblHiraganaFColor.Location = new System.Drawing.Point(177, 55);
            this.lblHiraganaFColor.Name = "lblHiraganaFColor";
            this.lblHiraganaFColor.Size = new System.Drawing.Size(55, 13);
            this.lblHiraganaFColor.TabIndex = 5;
            this.lblHiraganaFColor.Text = "Font Color";
            // 
            // lblHiraganaBgColor
            // 
            this.lblHiraganaBgColor.AutoSize = true;
            this.lblHiraganaBgColor.Location = new System.Drawing.Point(9, 55);
            this.lblHiraganaBgColor.Name = "lblHiraganaBgColor";
            this.lblHiraganaBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblHiraganaBgColor.TabIndex = 3;
            this.lblHiraganaBgColor.Text = "Background Color";
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.ClientSize = new System.Drawing.Size(379, 400);
            this.Controls.Add(this.grbHiragana);
            this.Controls.Add(this.grbKanji);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMeaning);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Vocabulary";
            this.grbMeaning.ResumeLayout(false);
            this.grbMeaning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMeaningFontsize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayTime)).EndInit();
            this.grbKanji.ResumeLayout(false);
            this.grbKanji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKanjiFontsize)).EndInit();
            this.grbHiragana.ResumeLayout(false);
            this.grbHiragana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiraganaFontsize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbMeaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBottRight;
        private System.Windows.Forms.RadioButton radTopRight;
        private System.Windows.Forms.RadioButton radBottLeft;
        private System.Windows.Forms.RadioButton radTopLeft;
        private System.Windows.Forms.Label lblKanjiFontsize;
        private System.Windows.Forms.Label lblHiraganaFontsize;
        private System.Windows.Forms.Label lblMeaningFontsize;
        private System.Windows.Forms.GroupBox grbKanji;
        private System.Windows.Forms.Label lblKanjiBgColor;
        private System.Windows.Forms.Label lblKanjiFColor;
        private System.Windows.Forms.CheckBox chkboxMeaning;
        private System.Windows.Forms.Label lblMeaningFColor;
        private System.Windows.Forms.Label lblMeaningBgColor;
        private System.Windows.Forms.CheckBox chkboxKanji;
        private System.Windows.Forms.GroupBox grbHiragana;
        private System.Windows.Forms.CheckBox chkboxHiragana;
        private System.Windows.Forms.Label lblHiraganaFColor;
        private System.Windows.Forms.Label lblHiraganaBgColor;
        private System.Windows.Forms.Panel pnlKanjiBgClr;
        private System.Windows.Forms.Panel pnlMeaningFClr;
        private System.Windows.Forms.Panel pnlMeaningBgClr;
        private System.Windows.Forms.Panel pnlKanjiFClr;
        private System.Windows.Forms.Panel pnlHiraganaFClr;
        private System.Windows.Forms.Panel pnlHiraganaBgClr;
        private System.Windows.Forms.NumericUpDown numMeaningFontsize;
        private System.Windows.Forms.NumericUpDown numDisTime;
        private System.Windows.Forms.NumericUpDown numDelayTime;
        private System.Windows.Forms.NumericUpDown numKanjiFontsize;
        private System.Windows.Forms.NumericUpDown numHiraganaFontsize;



    }
}