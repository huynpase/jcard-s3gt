namespace JCard
{
    partial class fCLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCLesson));
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVocabulary = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.cBoxCollapse = new System.Windows.Forms.CheckBox();
            this.chBoxAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radCombine = new System.Windows.Forms.RadioButton();
            this.radLastTopic = new System.Windows.Forms.RadioButton();
            this.radNewTopic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttCopy = new System.Windows.Forms.Button();
            this.tabGrammar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabVocabulary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGrammar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-80, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVocabulary);
            this.tabControl1.Controls.Add(this.tabGrammar);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 444);
            this.tabControl1.TabIndex = 10;
            // 
            // tabVocabulary
            // 
            this.tabVocabulary.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.tabVocabulary.Controls.Add(this.label3);
            this.tabVocabulary.Controls.Add(this.linkLabel2);
            this.tabVocabulary.Controls.Add(this.button5);
            this.tabVocabulary.Controls.Add(this.cBoxCollapse);
            this.tabVocabulary.Controls.Add(this.chBoxAll);
            this.tabVocabulary.Controls.Add(this.button1);
            this.tabVocabulary.Controls.Add(this.radCombine);
            this.tabVocabulary.Controls.Add(this.radLastTopic);
            this.tabVocabulary.Controls.Add(this.radNewTopic);
            this.tabVocabulary.Controls.Add(this.groupBox1);
            this.tabVocabulary.Controls.Add(this.buttCopy);
            this.tabVocabulary.Location = new System.Drawing.Point(4, 22);
            this.tabVocabulary.Name = "tabVocabulary";
            this.tabVocabulary.Padding = new System.Windows.Forms.Padding(3);
            this.tabVocabulary.Size = new System.Drawing.Size(473, 418);
            this.tabVocabulary.TabIndex = 0;
            this.tabVocabulary.Text = "Vocabulary";
            this.tabVocabulary.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Choose data base  of S3GT";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(378, 299);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 16);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Setting";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Browse...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cBoxCollapse
            // 
            this.cBoxCollapse.AutoSize = true;
            this.cBoxCollapse.Location = new System.Drawing.Point(377, 48);
            this.cBoxCollapse.Name = "cBoxCollapse";
            this.cBoxCollapse.Size = new System.Drawing.Size(79, 17);
            this.cBoxCollapse.TabIndex = 17;
            this.cBoxCollapse.Text = "Collapse all";
            this.cBoxCollapse.UseVisualStyleBackColor = true;
            this.cBoxCollapse.CheckedChanged += new System.EventHandler(this.cBoxCollapse_CheckedChanged_1);
            // 
            // chBoxAll
            // 
            this.chBoxAll.AutoSize = true;
            this.chBoxAll.Location = new System.Drawing.Point(377, 25);
            this.chBoxAll.Name = "chBoxAll";
            this.chBoxAll.Size = new System.Drawing.Size(70, 17);
            this.chBoxAll.TabIndex = 16;
            this.chBoxAll.Text = "Check all";
            this.chBoxAll.UseVisualStyleBackColor = true;
            this.chBoxAll.CheckedChanged += new System.EventHandler(this.chBoxAll_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(377, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCombine
            // 
            this.radCombine.Location = new System.Drawing.Point(3, 387);
            this.radCombine.Name = "radCombine";
            this.radCombine.Size = new System.Drawing.Size(274, 24);
            this.radCombine.TabIndex = 14;
            this.radCombine.Text = "Study combine new vocabulary and  last vocabulary";
            this.radCombine.UseVisualStyleBackColor = true;
            this.radCombine.CheckedChanged += new System.EventHandler(this.radCombine_CheckedChanged);
            // 
            // radLastTopic
            // 
            this.radLastTopic.Location = new System.Drawing.Point(3, 357);
            this.radLastTopic.Name = "radLastTopic";
            this.radLastTopic.Size = new System.Drawing.Size(128, 24);
            this.radLastTopic.TabIndex = 12;
            this.radLastTopic.Text = "Study last vocabulary";
            this.radLastTopic.UseVisualStyleBackColor = true;
            this.radLastTopic.CheckedChanged += new System.EventHandler(this.radLastTopic_CheckedChanged);
            // 
            // radNewTopic
            // 
            this.radNewTopic.Checked = true;
            this.radNewTopic.Location = new System.Drawing.Point(3, 327);
            this.radNewTopic.Name = "radNewTopic";
            this.radNewTopic.Size = new System.Drawing.Size(135, 24);
            this.radNewTopic.TabIndex = 13;
            this.radNewTopic.TabStop = true;
            this.radNewTopic.Text = "Study new vocabulary";
            this.radNewTopic.UseVisualStyleBackColor = true;
            this.radNewTopic.CheckedChanged += new System.EventHandler(this.radNewTopic_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 315);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please choose glossary(ies)  to learning";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(9, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(348, 283);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // buttCopy
            // 
            this.buttCopy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCopy.Location = new System.Drawing.Point(277, 372);
            this.buttCopy.Name = "buttCopy";
            this.buttCopy.Size = new System.Drawing.Size(94, 31);
            this.buttCopy.TabIndex = 10;
            this.buttCopy.Text = "&Start";
            this.buttCopy.UseVisualStyleBackColor = true;
            this.buttCopy.Click += new System.EventHandler(this.ButtStartClick);
            // 
            // tabGrammar
            // 
            this.tabGrammar.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.tabGrammar.Controls.Add(this.label2);
            this.tabGrammar.Controls.Add(this.panel1);
            this.tabGrammar.Location = new System.Drawing.Point(4, 22);
            this.tabGrammar.Name = "tabGrammar";
            this.tabGrammar.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrammar.Size = new System.Drawing.Size(473, 418);
            this.tabGrammar.TabIndex = 1;
            this.tabGrammar.Text = "Grammar";
            this.tabGrammar.UseVisualStyleBackColor = true;
            this.tabGrammar.Click += new System.EventHandler(this.tabGrammar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(136, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grammar Reminder ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cmbLevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 137);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(344, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(6, 71);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 29);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(106, 71);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(95, 29);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Se&tting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(243, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "1kyu",
            "2kyu",
            "3kyu",
            "4kyu"});
            this.cmbLevel.Location = new System.Drawing.Point(177, 3);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(118, 21);
            this.cmbLevel.TabIndex = 1;
            this.cmbLevel.Text = "2kyu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose  level:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(482, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(403, 453);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About JCard";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // fCLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 471);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fCLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCard ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.fCLesson_MouseHover);
            this.tabControl1.ResumeLayout(false);
            this.tabVocabulary.ResumeLayout(false);
            this.tabVocabulary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabGrammar.ResumeLayout(false);
            this.tabGrammar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVocabulary;
        private System.Windows.Forms.CheckBox cBoxCollapse;
        private System.Windows.Forms.CheckBox chBoxAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radCombine;
        private System.Windows.Forms.RadioButton radLastTopic;
        private System.Windows.Forms.RadioButton radNewTopic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttCopy;
        private System.Windows.Forms.TabPage tabGrammar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private rdbBR setting1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSetting;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
}
}

