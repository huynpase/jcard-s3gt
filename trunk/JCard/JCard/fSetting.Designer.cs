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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSetting));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbMeaning = new System.Windows.Forms.GroupBox();
            this.comFontMeaning = new System.Windows.Forms.ComboBox();
            this.lblMeaningFontsize = new System.Windows.Forms.Label();
            this.comFontKana = new System.Windows.Forms.ComboBox();
            this.lblHiraganaFontsize = new System.Windows.Forms.Label();
            this.comFontKanji = new System.Windows.Forms.ComboBox();
            this.lblKanjiFontsize = new System.Windows.Forms.Label();
            this.comDisTime = new System.Windows.Forms.ComboBox();
            this.comDeplayTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radBottRight = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grbKanji = new System.Windows.Forms.GroupBox();
            this.lblKanjiBgColor = new System.Windows.Forms.Label();
            this.lblKanjiFColor = new System.Windows.Forms.Label();
            this.chkboxKanji = new System.Windows.Forms.CheckBox();
            this.grbHiragana = new System.Windows.Forms.GroupBox();
            this.chkboxHiragana = new System.Windows.Forms.CheckBox();
            this.lblHiraganaFColor = new System.Windows.Forms.Label();
            this.lblHiraganaBgColor = new System.Windows.Forms.Label();
            this.chkboxMeaning = new System.Windows.Forms.CheckBox();
            this.lblMeaningFColor = new System.Windows.Forms.Label();
            this.lblMeaningBgColor = new System.Windows.Forms.Label();
            this.pnlSampleBgClr = new System.Windows.Forms.Panel();
            this.pnlSampleFClr = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbMeaning.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbKanji.SuspendLayout();
            this.grbHiragana.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(188, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 3;
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
            this.button1.TabIndex = 2;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbMeaning
            // 
            this.grbMeaning.BackColor = System.Drawing.Color.Transparent;
            this.grbMeaning.Controls.Add(this.panel4);
            this.grbMeaning.Controls.Add(this.panel3);
            this.grbMeaning.Controls.Add(this.comFontMeaning);
            this.grbMeaning.Controls.Add(this.chkboxMeaning);
            this.grbMeaning.Controls.Add(this.lblMeaningFColor);
            this.grbMeaning.Controls.Add(this.lblMeaningFontsize);
            this.grbMeaning.Controls.Add(this.lblMeaningBgColor);
            this.grbMeaning.Location = new System.Drawing.Point(10, 280);
            this.grbMeaning.Name = "grbMeaning";
            this.grbMeaning.Size = new System.Drawing.Size(359, 74);
            this.grbMeaning.TabIndex = 1;
            this.grbMeaning.TabStop = false;
            this.grbMeaning.Text = "Meaning";
            // 
            // comFontMeaning
            // 
            this.comFontMeaning.FormattingEnabled = true;
            this.comFontMeaning.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comFontMeaning.Location = new System.Drawing.Point(263, 14);
            this.comFontMeaning.Name = "comFontMeaning";
            this.comFontMeaning.Size = new System.Drawing.Size(55, 21);
            this.comFontMeaning.TabIndex = 11;
            this.comFontMeaning.Text = "5";
            // 
            // lblMeaningFontsize
            // 
            this.lblMeaningFontsize.AutoSize = true;
            this.lblMeaningFontsize.Location = new System.Drawing.Point(177, 17);
            this.lblMeaningFontsize.Name = "lblMeaningFontsize";
            this.lblMeaningFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblMeaningFontsize.TabIndex = 10;
            this.lblMeaningFontsize.Text = "Font Size:";
            // 
            // comFontKana
            // 
            this.comFontKana.FormattingEnabled = true;
            this.comFontKana.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comFontKana.Location = new System.Drawing.Point(263, 15);
            this.comFontKana.Name = "comFontKana";
            this.comFontKana.Size = new System.Drawing.Size(52, 21);
            this.comFontKana.TabIndex = 7;
            this.comFontKana.Text = "5";
            // 
            // lblHiraganaFontsize
            // 
            this.lblHiraganaFontsize.AutoSize = true;
            this.lblHiraganaFontsize.Location = new System.Drawing.Point(177, 18);
            this.lblHiraganaFontsize.Name = "lblHiraganaFontsize";
            this.lblHiraganaFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblHiraganaFontsize.TabIndex = 6;
            this.lblHiraganaFontsize.Text = "Font Size:";
            // 
            // comFontKanji
            // 
            this.comFontKanji.FormattingEnabled = true;
            this.comFontKanji.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comFontKanji.Location = new System.Drawing.Point(263, 15);
            this.comFontKanji.Name = "comFontKanji";
            this.comFontKanji.Size = new System.Drawing.Size(52, 21);
            this.comFontKanji.TabIndex = 5;
            this.comFontKanji.Text = "5";
            // 
            // lblKanjiFontsize
            // 
            this.lblKanjiFontsize.AutoSize = true;
            this.lblKanjiFontsize.Location = new System.Drawing.Point(177, 18);
            this.lblKanjiFontsize.Name = "lblKanjiFontsize";
            this.lblKanjiFontsize.Size = new System.Drawing.Size(54, 13);
            this.lblKanjiFontsize.TabIndex = 4;
            this.lblKanjiFontsize.Text = "Font Size:";
            // 
            // comDisTime
            // 
            this.comDisTime.FormattingEnabled = true;
            this.comDisTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comDisTime.Location = new System.Drawing.Point(263, 72);
            this.comDisTime.Name = "comDisTime";
            this.comDisTime.Size = new System.Drawing.Size(52, 21);
            this.comDisTime.TabIndex = 3;
            this.comDisTime.Text = "5";
            // 
            // comDeplayTime
            // 
            this.comDeplayTime.FormattingEnabled = true;
            this.comDeplayTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comDeplayTime.Location = new System.Drawing.Point(116, 73);
            this.comDeplayTime.Name = "comDeplayTime";
            this.comDeplayTime.Size = new System.Drawing.Size(55, 21);
            this.comDeplayTime.TabIndex = 1;
            this.comDeplayTime.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Display Time (s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deplay Time (s):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comDisTime);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.comDeplayTime);
            this.groupBox1.Controls.Add(this.radBottRight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Top Left";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(180, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Top Right";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Bottom Left";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grbKanji
            // 
            this.grbKanji.BackColor = System.Drawing.Color.Transparent;
            this.grbKanji.Controls.Add(this.pnlSampleFClr);
            this.grbKanji.Controls.Add(this.pnlSampleBgClr);
            this.grbKanji.Controls.Add(this.chkboxKanji);
            this.grbKanji.Controls.Add(this.lblKanjiFColor);
            this.grbKanji.Controls.Add(this.lblKanjiBgColor);
            this.grbKanji.Controls.Add(this.lblKanjiFontsize);
            this.grbKanji.Controls.Add(this.comFontKanji);
            this.grbKanji.Location = new System.Drawing.Point(10, 116);
            this.grbKanji.Name = "grbKanji";
            this.grbKanji.Size = new System.Drawing.Size(359, 76);
            this.grbKanji.TabIndex = 4;
            this.grbKanji.TabStop = false;
            this.grbKanji.Text = "Kanji";
            // 
            // lblKanjiBgColor
            // 
            this.lblKanjiBgColor.AutoSize = true;
            this.lblKanjiBgColor.Location = new System.Drawing.Point(9, 55);
            this.lblKanjiBgColor.Name = "lblKanjiBgColor";
            this.lblKanjiBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblKanjiBgColor.TabIndex = 0;
            this.lblKanjiBgColor.Text = "Background Color";
            // 
            // lblKanjiFColor
            // 
            this.lblKanjiFColor.AutoSize = true;
            this.lblKanjiFColor.Location = new System.Drawing.Point(177, 55);
            this.lblKanjiFColor.Name = "lblKanjiFColor";
            this.lblKanjiFColor.Size = new System.Drawing.Size(55, 13);
            this.lblKanjiFColor.TabIndex = 1;
            this.lblKanjiFColor.Text = "Font Color";
            // 
            // chkboxKanji
            // 
            this.chkboxKanji.AutoSize = true;
            this.chkboxKanji.Location = new System.Drawing.Point(12, 17);
            this.chkboxKanji.Name = "chkboxKanji";
            this.chkboxKanji.Size = new System.Drawing.Size(83, 17);
            this.chkboxKanji.TabIndex = 4;
            this.chkboxKanji.Text = "Is Displayed";
            this.chkboxKanji.UseVisualStyleBackColor = true;
            // 
            // grbHiragana
            // 
            this.grbHiragana.BackColor = System.Drawing.Color.Transparent;
            this.grbHiragana.Controls.Add(this.panel2);
            this.grbHiragana.Controls.Add(this.panel1);
            this.grbHiragana.Controls.Add(this.chkboxHiragana);
            this.grbHiragana.Controls.Add(this.lblHiraganaFColor);
            this.grbHiragana.Controls.Add(this.lblHiraganaBgColor);
            this.grbHiragana.Controls.Add(this.lblHiraganaFontsize);
            this.grbHiragana.Controls.Add(this.comFontKana);
            this.grbHiragana.Location = new System.Drawing.Point(10, 198);
            this.grbHiragana.Name = "grbHiragana";
            this.grbHiragana.Size = new System.Drawing.Size(359, 76);
            this.grbHiragana.TabIndex = 5;
            this.grbHiragana.TabStop = false;
            this.grbHiragana.Text = "Hiragana";
            // 
            // chkboxHiragana
            // 
            this.chkboxHiragana.AutoSize = true;
            this.chkboxHiragana.Location = new System.Drawing.Point(12, 17);
            this.chkboxHiragana.Name = "chkboxHiragana";
            this.chkboxHiragana.Size = new System.Drawing.Size(83, 17);
            this.chkboxHiragana.TabIndex = 4;
            this.chkboxHiragana.Text = "Is Displayed";
            this.chkboxHiragana.UseVisualStyleBackColor = true;
            // 
            // lblHiraganaFColor
            // 
            this.lblHiraganaFColor.AutoSize = true;
            this.lblHiraganaFColor.Location = new System.Drawing.Point(177, 55);
            this.lblHiraganaFColor.Name = "lblHiraganaFColor";
            this.lblHiraganaFColor.Size = new System.Drawing.Size(55, 13);
            this.lblHiraganaFColor.TabIndex = 1;
            this.lblHiraganaFColor.Text = "Font Color";
            // 
            // lblHiraganaBgColor
            // 
            this.lblHiraganaBgColor.AutoSize = true;
            this.lblHiraganaBgColor.Location = new System.Drawing.Point(9, 55);
            this.lblHiraganaBgColor.Name = "lblHiraganaBgColor";
            this.lblHiraganaBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblHiraganaBgColor.TabIndex = 0;
            this.lblHiraganaBgColor.Text = "Background Color";
            // 
            // chkboxMeaning
            // 
            this.chkboxMeaning.AutoSize = true;
            this.chkboxMeaning.Location = new System.Drawing.Point(12, 16);
            this.chkboxMeaning.Name = "chkboxMeaning";
            this.chkboxMeaning.Size = new System.Drawing.Size(83, 17);
            this.chkboxMeaning.TabIndex = 10;
            this.chkboxMeaning.Text = "Is Displayed";
            this.chkboxMeaning.UseVisualStyleBackColor = true;
            // 
            // lblMeaningFColor
            // 
            this.lblMeaningFColor.AutoSize = true;
            this.lblMeaningFColor.Location = new System.Drawing.Point(177, 54);
            this.lblMeaningFColor.Name = "lblMeaningFColor";
            this.lblMeaningFColor.Size = new System.Drawing.Size(55, 13);
            this.lblMeaningFColor.TabIndex = 9;
            this.lblMeaningFColor.Text = "Font Color";
            // 
            // lblMeaningBgColor
            // 
            this.lblMeaningBgColor.AutoSize = true;
            this.lblMeaningBgColor.Location = new System.Drawing.Point(9, 54);
            this.lblMeaningBgColor.Name = "lblMeaningBgColor";
            this.lblMeaningBgColor.Size = new System.Drawing.Size(92, 13);
            this.lblMeaningBgColor.TabIndex = 8;
            this.lblMeaningBgColor.Text = "Background Color";
            // 
            // pnlSampleBgClr
            // 
            this.pnlSampleBgClr.BackColor = System.Drawing.Color.Maroon;
            this.pnlSampleBgClr.Location = new System.Drawing.Point(118, 43);
            this.pnlSampleBgClr.Name = "pnlSampleBgClr";
            this.pnlSampleBgClr.Size = new System.Drawing.Size(26, 25);
            this.pnlSampleBgClr.TabIndex = 12;
            // 
            // pnlSampleFClr
            // 
            this.pnlSampleFClr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSampleFClr.Location = new System.Drawing.Point(263, 43);
            this.pnlSampleFClr.Name = "pnlSampleFClr";
            this.pnlSampleFClr.Size = new System.Drawing.Size(26, 25);
            this.pnlSampleFClr.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(118, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 25);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(263, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 25);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(118, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 25);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(263, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 25);
            this.panel4.TabIndex = 6;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Vocabulary";
            this.Load += new System.EventHandler(this.fSetting_Load);
            this.grbMeaning.ResumeLayout(false);
            this.grbMeaning.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbKanji.ResumeLayout(false);
            this.grbKanji.PerformLayout();
            this.grbHiragana.ResumeLayout(false);
            this.grbHiragana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbMeaning;
        private System.Windows.Forms.ComboBox comDisTime;
        private System.Windows.Forms.ComboBox comDeplayTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBottRight;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comFontKanji;
        private System.Windows.Forms.Label lblKanjiFontsize;
        private System.Windows.Forms.ComboBox comFontKana;
        private System.Windows.Forms.Label lblHiraganaFontsize;
        private System.Windows.Forms.ComboBox comFontMeaning;
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
        private System.Windows.Forms.Panel pnlSampleBgClr;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSampleFClr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;



    }
}