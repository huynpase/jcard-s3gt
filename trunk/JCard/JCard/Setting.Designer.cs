namespace JCard
{
    partial class rdbBR
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbBR2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbTR = new System.Windows.Forms.RadioButton();
            this.cmbDisplayTime = new System.Windows.Forms.ComboBox();
            this.rdbBL = new System.Windows.Forms.RadioButton();
            this.cmbDelayTime = new System.Windows.Forms.ComboBox();
            this.rdbTL = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbImiFontSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKanaFontSize = new System.Windows.Forms.ComboBox();
            this.cmbKanjiFontSize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdbBR2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbTR);
            this.groupBox1.Controls.Add(this.cmbDisplayTime);
            this.groupBox1.Controls.Add(this.rdbBL);
            this.groupBox1.Controls.Add(this.cmbDelayTime);
            this.groupBox1.Controls.Add(this.rdbTL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "(s)";
            // 
            // rdbBR2
            // 
            this.rdbBR2.AutoSize = true;
            this.rdbBR2.Checked = true;
            this.rdbBR2.Location = new System.Drawing.Point(159, 42);
            this.rdbBR2.Name = "rdbBR2";
            this.rdbBR2.Size = new System.Drawing.Size(86, 17);
            this.rdbBR2.TabIndex = 3;
            this.rdbBR2.TabStop = true;
            this.rdbBR2.Text = "Bottom Right";
            this.rdbBR2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "(s)";
            // 
            // rdbTR
            // 
            this.rdbTR.AutoSize = true;
            this.rdbTR.Location = new System.Drawing.Point(159, 20);
            this.rdbTR.Name = "rdbTR";
            this.rdbTR.Size = new System.Drawing.Size(72, 17);
            this.rdbTR.TabIndex = 2;
            this.rdbTR.Text = "Top Right";
            this.rdbTR.UseVisualStyleBackColor = true;
            // 
            // cmbDisplayTime
            // 
            this.cmbDisplayTime.FormattingEnabled = true;
            this.cmbDisplayTime.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cmbDisplayTime.Location = new System.Drawing.Point(78, 95);
            this.cmbDisplayTime.Name = "cmbDisplayTime";
            this.cmbDisplayTime.Size = new System.Drawing.Size(69, 21);
            this.cmbDisplayTime.TabIndex = 15;
            this.cmbDisplayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDisplayTime_KeyPress);
            // 
            // rdbBL
            // 
            this.rdbBL.AutoSize = true;
            this.rdbBL.Location = new System.Drawing.Point(11, 38);
            this.rdbBL.Name = "rdbBL";
            this.rdbBL.Size = new System.Drawing.Size(79, 17);
            this.rdbBL.TabIndex = 1;
            this.rdbBL.Text = "Bottom Left";
            this.rdbBL.UseVisualStyleBackColor = true;
            // 
            // cmbDelayTime
            // 
            this.cmbDelayTime.FormattingEnabled = true;
            this.cmbDelayTime.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cmbDelayTime.Location = new System.Drawing.Point(78, 70);
            this.cmbDelayTime.Name = "cmbDelayTime";
            this.cmbDelayTime.Size = new System.Drawing.Size(69, 21);
            this.cmbDelayTime.TabIndex = 14;
            this.cmbDelayTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDelayTime_KeyPress);
            // 
            // rdbTL
            // 
            this.rdbTL.AutoSize = true;
            this.rdbTL.Location = new System.Drawing.Point(11, 16);
            this.rdbTL.Name = "rdbTL";
            this.rdbTL.Size = new System.Drawing.Size(65, 17);
            this.rdbTL.TabIndex = 0;
            this.rdbTL.Text = "Top Left";
            this.rdbTL.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Display Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Deplay Time:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbImiFontSize);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbKanaFontSize);
            this.groupBox2.Controls.Add(this.cmbKanjiFontSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // cmbImiFontSize
            // 
            this.cmbImiFontSize.FormattingEnabled = true;
            this.cmbImiFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.cmbImiFontSize.Location = new System.Drawing.Point(95, 77);
            this.cmbImiFontSize.Name = "cmbImiFontSize";
            this.cmbImiFontSize.Size = new System.Drawing.Size(69, 21);
            this.cmbImiFontSize.TabIndex = 23;
            this.cmbImiFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbImiFontSize_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Imi\'s Font size:";
            // 
            // cmbKanaFontSize
            // 
            this.cmbKanaFontSize.FormattingEnabled = true;
            this.cmbKanaFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.cmbKanaFontSize.Location = new System.Drawing.Point(95, 50);
            this.cmbKanaFontSize.Name = "cmbKanaFontSize";
            this.cmbKanaFontSize.Size = new System.Drawing.Size(69, 21);
            this.cmbKanaFontSize.TabIndex = 21;
            this.cmbKanaFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbKanaFontSize_KeyPress);
            // 
            // cmbKanjiFontSize
            // 
            this.cmbKanjiFontSize.FormattingEnabled = true;
            this.cmbKanjiFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.cmbKanjiFontSize.Location = new System.Drawing.Point(95, 23);
            this.cmbKanjiFontSize.Name = "cmbKanjiFontSize";
            this.cmbKanjiFontSize.Size = new System.Drawing.Size(69, 21);
            this.cmbKanjiFontSize.TabIndex = 19;
            this.cmbKanjiFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbKanjiFontSize_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kana\'s Font size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kanji\'s Font size:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(235, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 25);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(120, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 25);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbBR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "rdbBR";
            this.Size = new System.Drawing.Size(454, 399);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBR2;
        private System.Windows.Forms.RadioButton rdbTR;
        private System.Windows.Forms.RadioButton rdbBL;
        private System.Windows.Forms.RadioButton rdbTL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDisplayTime;
        private System.Windows.Forms.ComboBox cmbDelayTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKanjiFontSize;
        private System.Windows.Forms.ComboBox cmbKanaFontSize;
        private System.Windows.Forms.ComboBox cmbImiFontSize;
        private System.Windows.Forms.Label label7;
    }
}
