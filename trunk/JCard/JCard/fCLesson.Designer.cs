﻿namespace JCard
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.setting1 = new JCard.Setting();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabVocabulary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabGrammar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 444);
            this.tabControl1.TabIndex = 10;
            // 
            // tabVocabulary
            // 
            this.tabVocabulary.BackgroundImage = global::JCard.Properties.Resources.Back2;
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
            this.tabVocabulary.Size = new System.Drawing.Size(446, 418);
            this.tabVocabulary.TabIndex = 0;
            this.tabVocabulary.Text = "Vocabulary";
            this.tabVocabulary.UseVisualStyleBackColor = true;
            // 
            // cBoxCollapse
            // 
            this.cBoxCollapse.AutoSize = true;
            this.cBoxCollapse.Location = new System.Drawing.Point(322, 327);
            this.cBoxCollapse.Name = "cBoxCollapse";
            this.cBoxCollapse.Size = new System.Drawing.Size(80, 17);
            this.cBoxCollapse.TabIndex = 17;
            this.cBoxCollapse.Text = "Collapse All";
            this.cBoxCollapse.UseVisualStyleBackColor = true;
            this.cBoxCollapse.CheckedChanged += new System.EventHandler(this.cBoxCollapse_CheckedChanged_1);
            // 
            // chBoxAll
            // 
            this.chBoxAll.AutoSize = true;
            this.chBoxAll.Location = new System.Drawing.Point(234, 327);
            this.chBoxAll.Name = "chBoxAll";
            this.chBoxAll.Size = new System.Drawing.Size(71, 17);
            this.chBoxAll.TabIndex = 16;
            this.chBoxAll.Text = "Check All";
            this.chBoxAll.UseVisualStyleBackColor = true;
            this.chBoxAll.CheckedChanged += new System.EventHandler(this.chBoxAll_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radCombine
            // 
            this.radCombine.Location = new System.Drawing.Point(3, 387);
            this.radCombine.Name = "radCombine";
            this.radCombine.Size = new System.Drawing.Size(188, 24);
            this.radCombine.TabIndex = 14;
            this.radCombine.Text = "Combine new topic and  last topic";
            this.radCombine.UseVisualStyleBackColor = true;
            // 
            // radLastTopic
            // 
            this.radLastTopic.Location = new System.Drawing.Point(3, 357);
            this.radLastTopic.Name = "radLastTopic";
            this.radLastTopic.Size = new System.Drawing.Size(128, 24);
            this.radLastTopic.TabIndex = 12;
            this.radLastTopic.Text = "Load the last topic";
            this.radLastTopic.UseVisualStyleBackColor = true;
            // 
            // radNewTopic
            // 
            this.radNewTopic.Checked = true;
            this.radNewTopic.Location = new System.Drawing.Point(3, 327);
            this.radNewTopic.Name = "radNewTopic";
            this.radNewTopic.Size = new System.Drawing.Size(135, 24);
            this.radNewTopic.TabIndex = 13;
            this.radNewTopic.TabStop = true;
            this.radNewTopic.Text = "New Topic";
            this.radNewTopic.UseVisualStyleBackColor = true;
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
            this.buttCopy.Location = new System.Drawing.Point(235, 380);
            this.buttCopy.Name = "buttCopy";
            this.buttCopy.Size = new System.Drawing.Size(95, 25);
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
            this.tabGrammar.Size = new System.Drawing.Size(446, 418);
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
            this.label2.TabIndex = 1;
            this.label2.Text = "Grammar Reminder ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 137);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(105, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "&Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1kyu",
            "2kyu",
            "3kyu",
            "4kyu"});
            this.comboBox1.Location = new System.Drawing.Point(177, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "2kyu";
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
            // tabSetting
            // 
            this.tabSetting.BackColor = System.Drawing.Color.Transparent;
            this.tabSetting.BackgroundImage = global::JCard.Properties.Resources.Back2;
            this.tabSetting.Controls.Add(this.setting1);
            this.tabSetting.Location = new System.Drawing.Point(4, 22);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Size = new System.Drawing.Size(446, 418);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Setting";
            // 
            // setting1
            // 
            this.setting1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting1.BackgroundImage")));
            this.setting1.Location = new System.Drawing.Point(-1, 0);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(454, 444);
            this.setting1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.vocabularyToolStripMenuItem,
            this.grammarToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 114);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.vocabularyToolStripMenuItem.Text = "Vocabulary";
            // 
            // grammarToolStripMenuItem
            // 
            this.grammarToolStripMenuItem.Name = "grammarToolStripMenuItem";
            this.grammarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.grammarToolStripMenuItem.Text = "Grammar";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick_1);
            // 
            // fCLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fCLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCard - PhuongHD";
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
            this.tabSetting.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grammarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Setting setting1;
    }
}

