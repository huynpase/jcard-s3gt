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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNewTopic = new System.Windows.Forms.RadioButton();
            this.radLastTopic = new System.Windows.Forms.RadioButton();
            this.radCombine = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.txtS3GTDB = new System.Windows.Forms.TextBox();
            this.lblVocabS3GT = new System.Windows.Forms.Label();
            this.btnBrowseVoc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chBoxAll = new System.Windows.Forms.CheckBox();
            this.cBoxCollapse = new System.Windows.Forms.CheckBox();
            this.ButtCopy = new System.Windows.Forms.Button();
            this.tabGrammar = new System.Windows.Forms.TabPage();
            this.txtDatabaseGram = new System.Windows.Forms.TextBox();
            this.lblGramS3GT = new System.Windows.Forms.Label();
            this.btnBrowseGram = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trvGrammars = new System.Windows.Forms.TreeView();
            this.chbGramAll = new System.Windows.Forms.CheckBox();
            this.chbGramColAll = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabVocabulary.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGrammar.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 471);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabVocabulary
            // 
            this.tabVocabulary.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.tabVocabulary.Controls.Add(this.groupBox3);
            this.tabVocabulary.Controls.Add(this.button4);
            this.tabVocabulary.Controls.Add(this.txtS3GTDB);
            this.tabVocabulary.Controls.Add(this.lblVocabS3GT);
            this.tabVocabulary.Controls.Add(this.btnBrowseVoc);
            this.tabVocabulary.Controls.Add(this.button1);
            this.tabVocabulary.Controls.Add(this.groupBox1);
            this.tabVocabulary.Controls.Add(this.ButtCopy);
            this.tabVocabulary.Location = new System.Drawing.Point(4, 22);
            this.tabVocabulary.Name = "tabVocabulary";
            this.tabVocabulary.Padding = new System.Windows.Forms.Padding(3);
            this.tabVocabulary.Size = new System.Drawing.Size(508, 445);
            this.tabVocabulary.TabIndex = 0;
            this.tabVocabulary.Text = "Vocabulary";
            this.tabVocabulary.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radNewTopic);
            this.groupBox3.Controls.Add(this.radLastTopic);
            this.groupBox3.Controls.Add(this.radCombine);
            this.groupBox3.Location = new System.Drawing.Point(387, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 128);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Learn vocabulary";
            // 
            // radNewTopic
            // 
            this.radNewTopic.Checked = true;
            this.radNewTopic.Location = new System.Drawing.Point(6, 35);
            this.radNewTopic.Name = "radNewTopic";
            this.radNewTopic.Size = new System.Drawing.Size(103, 24);
            this.radNewTopic.TabIndex = 13;
            this.radNewTopic.TabStop = true;
            this.radNewTopic.Text = "New vocabulary";
            this.radNewTopic.UseVisualStyleBackColor = true;
            this.radNewTopic.CheckedChanged += new System.EventHandler(this.radNewTopic_CheckedChanged);
            // 
            // radLastTopic
            // 
            this.radLastTopic.Location = new System.Drawing.Point(6, 65);
            this.radLastTopic.Name = "radLastTopic";
            this.radLastTopic.Size = new System.Drawing.Size(103, 24);
            this.radLastTopic.TabIndex = 12;
            this.radLastTopic.Text = "Last vocabulary";
            this.radLastTopic.UseVisualStyleBackColor = true;
            this.radLastTopic.CheckedChanged += new System.EventHandler(this.radLastTopic_CheckedChanged);
            // 
            // radCombine
            // 
            this.radCombine.Location = new System.Drawing.Point(6, 95);
            this.radCombine.Name = "radCombine";
            this.radCombine.Size = new System.Drawing.Size(76, 24);
            this.radCombine.TabIndex = 14;
            this.radCombine.Text = "All";
            this.radCombine.UseVisualStyleBackColor = true;
            this.radCombine.CheckedChanged += new System.EventHandler(this.radCombine_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 26;
            this.button4.Text = "Se&tting";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtS3GTDB
            // 
            this.txtS3GTDB.Location = new System.Drawing.Point(95, 12);
            this.txtS3GTDB.Name = "txtS3GTDB";
            this.txtS3GTDB.ReadOnly = true;
            this.txtS3GTDB.Size = new System.Drawing.Size(286, 20);
            this.txtS3GTDB.TabIndex = 24;
            this.txtS3GTDB.Text = "datasource\\\\s3gt_db.mdb";
            // 
            // lblVocabS3GT
            // 
            this.lblVocabS3GT.AutoSize = true;
            this.lblVocabS3GT.BackColor = System.Drawing.Color.Transparent;
            this.lblVocabS3GT.Location = new System.Drawing.Point(9, 15);
            this.lblVocabS3GT.Name = "lblVocabS3GT";
            this.lblVocabS3GT.Size = new System.Drawing.Size(87, 13);
            this.lblVocabS3GT.TabIndex = 23;
            this.lblVocabS3GT.Text = "S3GT Database:";
            // 
            // btnBrowseVoc
            // 
            this.btnBrowseVoc.Location = new System.Drawing.Point(387, 9);
            this.btnBrowseVoc.Name = "btnBrowseVoc";
            this.btnBrowseVoc.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseVoc.TabIndex = 20;
            this.btnBrowseVoc.Text = "Browse...";
            this.btnBrowseVoc.UseVisualStyleBackColor = true;
            this.btnBrowseVoc.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.chBoxAll);
            this.groupBox1.Controls.Add(this.cBoxCollapse);
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 341);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please choose glossary(ies)  to learn";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(9, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(363, 300);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // chBoxAll
            // 
            this.chBoxAll.AutoSize = true;
            this.chBoxAll.Location = new System.Drawing.Point(217, 12);
            this.chBoxAll.Name = "chBoxAll";
            this.chBoxAll.Size = new System.Drawing.Size(70, 17);
            this.chBoxAll.TabIndex = 16;
            this.chBoxAll.Text = "Check all";
            this.chBoxAll.UseVisualStyleBackColor = true;
            this.chBoxAll.CheckedChanged += new System.EventHandler(this.chBoxAll_CheckedChanged_1);
            // 
            // cBoxCollapse
            // 
            this.cBoxCollapse.AutoSize = true;
            this.cBoxCollapse.Location = new System.Drawing.Point(293, 12);
            this.cBoxCollapse.Name = "cBoxCollapse";
            this.cBoxCollapse.Size = new System.Drawing.Size(79, 17);
            this.cBoxCollapse.TabIndex = 17;
            this.cBoxCollapse.Text = "Collapse all";
            this.cBoxCollapse.UseVisualStyleBackColor = true;
            this.cBoxCollapse.CheckedChanged += new System.EventHandler(this.cBoxCollapse_CheckedChanged_1);
            // 
            // ButtCopy
            // 
            this.ButtCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtCopy.Location = new System.Drawing.Point(281, 390);
            this.ButtCopy.Name = "ButtCopy";
            this.ButtCopy.Size = new System.Drawing.Size(94, 31);
            this.ButtCopy.TabIndex = 10;
            this.ButtCopy.Text = "&Start";
            this.ButtCopy.UseVisualStyleBackColor = true;
            this.ButtCopy.Click += new System.EventHandler(this.ButtCopy_Click);
            // 
            // tabGrammar
            // 
            this.tabGrammar.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.tabGrammar.Controls.Add(this.txtDatabaseGram);
            this.tabGrammar.Controls.Add(this.lblGramS3GT);
            this.tabGrammar.Controls.Add(this.btnBrowseGram);
            this.tabGrammar.Controls.Add(this.groupBox2);
            this.tabGrammar.Controls.Add(this.btnImport);
            this.tabGrammar.Controls.Add(this.button2);
            this.tabGrammar.Controls.Add(this.btnSetting);
            this.tabGrammar.Controls.Add(this.button3);
            this.tabGrammar.Location = new System.Drawing.Point(4, 22);
            this.tabGrammar.Name = "tabGrammar";
            this.tabGrammar.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrammar.Size = new System.Drawing.Size(508, 445);
            this.tabGrammar.TabIndex = 1;
            this.tabGrammar.Text = "Grammar";
            this.tabGrammar.UseVisualStyleBackColor = true;
            // 
            // txtDatabaseGram
            // 
            this.txtDatabaseGram.Location = new System.Drawing.Point(95, 12);
            this.txtDatabaseGram.Name = "txtDatabaseGram";
            this.txtDatabaseGram.ReadOnly = true;
            this.txtDatabaseGram.Size = new System.Drawing.Size(286, 20);
            this.txtDatabaseGram.TabIndex = 28;
            this.txtDatabaseGram.Text = "datasource\\\\s3gt_db.mdb";
            // 
            // lblGramS3GT
            // 
            this.lblGramS3GT.AutoSize = true;
            this.lblGramS3GT.BackColor = System.Drawing.Color.Transparent;
            this.lblGramS3GT.Location = new System.Drawing.Point(9, 15);
            this.lblGramS3GT.Name = "lblGramS3GT";
            this.lblGramS3GT.Size = new System.Drawing.Size(87, 13);
            this.lblGramS3GT.TabIndex = 27;
            this.lblGramS3GT.Text = "S3GT Database:";
            // 
            // btnBrowseGram
            // 
            this.btnBrowseGram.Location = new System.Drawing.Point(387, 9);
            this.btnBrowseGram.Name = "btnBrowseGram";
            this.btnBrowseGram.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseGram.TabIndex = 26;
            this.btnBrowseGram.Text = "Browse...";
            this.btnBrowseGram.UseVisualStyleBackColor = true;
            this.btnBrowseGram.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trvGrammars);
            this.groupBox2.Controls.Add(this.chbGramAll);
            this.groupBox2.Controls.Add(this.chbGramColAll);
            this.groupBox2.Location = new System.Drawing.Point(3, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 341);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Please choose grammar(s)  to learn";
            // 
            // trvGrammars
            // 
            this.trvGrammars.CheckBoxes = true;
            this.trvGrammars.Location = new System.Drawing.Point(9, 35);
            this.trvGrammars.Name = "trvGrammars";
            this.trvGrammars.Size = new System.Drawing.Size(363, 300);
            this.trvGrammars.TabIndex = 0;
            this.trvGrammars.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // chbGramAll
            // 
            this.chbGramAll.AutoSize = true;
            this.chbGramAll.Location = new System.Drawing.Point(217, 12);
            this.chbGramAll.Name = "chbGramAll";
            this.chbGramAll.Size = new System.Drawing.Size(70, 17);
            this.chbGramAll.TabIndex = 16;
            this.chbGramAll.Text = "Check all";
            this.chbGramAll.UseVisualStyleBackColor = true;
            this.chbGramAll.CheckedChanged += new System.EventHandler(this.chBoxAll_CheckedChanged_1);
            // 
            // chbGramColAll
            // 
            this.chbGramColAll.AutoSize = true;
            this.chbGramColAll.Location = new System.Drawing.Point(293, 12);
            this.chbGramColAll.Name = "chbGramColAll";
            this.chbGramColAll.Size = new System.Drawing.Size(79, 17);
            this.chbGramColAll.TabIndex = 17;
            this.chbGramColAll.Text = "Collapse all";
            this.chbGramColAll.UseVisualStyleBackColor = true;
            this.chbGramColAll.CheckedChanged += new System.EventHandler(this.cBoxCollapse_CheckedChanged_1);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(12, 390);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(94, 31);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(387, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(117, 390);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(94, 31);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Se&tting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(516, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(419, 454);
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
            this.ClientSize = new System.Drawing.Size(516, 471);
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
            this.tabControl1.ResumeLayout(false);
            this.tabVocabulary.ResumeLayout(false);
            this.tabVocabulary.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabGrammar.ResumeLayout(false);
            this.tabGrammar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button ButtCopy;
        private System.Windows.Forms.TabPage tabGrammar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSetting;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnBrowseVoc;

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtS3GTDB;
        private System.Windows.Forms.Label lblVocabS3GT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDatabaseGram;
        private System.Windows.Forms.Label lblGramS3GT;
        private System.Windows.Forms.Button btnBrowseGram;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView trvGrammars;
        private System.Windows.Forms.CheckBox chbGramAll;
        private System.Windows.Forms.CheckBox chbGramColAll;
}
}

