namespace JCard
{
    partial class fJCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fJCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHiragana = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tempTextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHanNom = new System.Windows.Forms.TextBox();
            this.timer_Flag = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKanji);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 58);
            this.panel1.TabIndex = 100;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10003;
            // 
            // txtKanji
            // 
            this.txtKanji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtKanji.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKanji.Font = new System.Drawing.Font("MS PGothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKanji.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtKanji.Location = new System.Drawing.Point(3, 11);
            this.txtKanji.Multiline = true;
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.ReadOnly = true;
            this.txtKanji.Size = new System.Drawing.Size(210, 30);
            this.txtKanji.TabIndex = 10002;
            this.txtKanji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKanji.MouseLeave += new System.EventHandler(this.txtKanji_MouseLeave);
            this.txtKanji.MouseHover += new System.EventHandler(this.txtKanji_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtHiragana);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 58);
            this.panel2.TabIndex = 100;
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // txtHiragana
            // 
            this.txtHiragana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHiragana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHiragana.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtHiragana.ForeColor = System.Drawing.Color.Red;
            this.txtHiragana.Location = new System.Drawing.Point(2, 11);
            this.txtHiragana.Multiline = true;
            this.txtHiragana.Name = "txtHiragana";
            this.txtHiragana.ReadOnly = true;
            this.txtHiragana.Size = new System.Drawing.Size(211, 26);
            this.txtHiragana.TabIndex = 10001;
            this.txtHiragana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHiragana.MouseLeave += new System.EventHandler(this.txtHiragana_MouseLeave);
            this.txtHiragana.MouseHover += new System.EventHandler(this.txtHiragana_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 58);
            this.panel3.TabIndex = 100;
            // 
            // tempTextbox
            // 
            this.tempTextbox.Location = new System.Drawing.Point(3, 266);
            this.tempTextbox.Name = "tempTextbox";
            this.tempTextbox.Size = new System.Drawing.Size(10, 20);
            this.tempTextbox.TabIndex = 1;
            this.tempTextbox.Text = "set focus here";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.txtHanNom);
            this.panel4.Location = new System.Drawing.Point(-1, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 57);
            this.panel4.TabIndex = 101;
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.panel4_MouseHover);
            // 
            // txtHanNom
            // 
            this.txtHanNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtHanNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHanNom.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanNom.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtHanNom.Location = new System.Drawing.Point(3, 13);
            this.txtHanNom.Multiline = true;
            this.txtHanNom.Name = "txtHanNom";
            this.txtHanNom.ReadOnly = true;
            this.txtHanNom.Size = new System.Drawing.Size(211, 31);
            this.txtHanNom.TabIndex = 10002;
            this.txtHanNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHanNom.MouseHover += new System.EventHandler(this.txtHanNom_MouseHover);
            // 
            // timer_Flag
            // 
            this.timer_Flag.Enabled = true;
            this.timer_Flag.Interval = 1000;
            this.timer_Flag.Tick += new System.EventHandler(this.timer_Flag_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.txtMeaning);
            this.panel5.Location = new System.Drawing.Point(-1, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 57);
            this.panel5.TabIndex = 102;
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.panel5.MouseHover += new System.EventHandler(this.panel5_MouseHover);
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMeaning.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtMeaning.Location = new System.Drawing.Point(3, 13);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ReadOnly = true;
            this.txtMeaning.Size = new System.Drawing.Size(211, 31);
            this.txtMeaning.TabIndex = 10002;
            this.txtMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMeaning.MouseLeave += new System.EventHandler(this.txtMeaning_MouseLeave);
            this.txtMeaning.MouseHover += new System.EventHandler(this.txtMeaning_MouseHover);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vocabularyToolStripMenuItem,
            this.grammarToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vocabularyToolStripMenuItem.Text = "Vocabulary";
            // 
            // grammarToolStripMenuItem
            // 
            this.grammarToolStripMenuItem.Name = "grammarToolStripMenuItem";
            this.grammarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grammarToolStripMenuItem.Text = "Grammar";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click_2);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_2);
            // 
            // fJCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(215, 227);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tempTextbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fJCard";
            this.Opacity = 0;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCard- Vocabulary";
            this.MouseLeave += new System.EventHandler(this.FJCardMouseLeave);
            this.MouseHover += new System.EventHandler(this.FJCardMouseHover);
            this.Load += new System.EventHandler(this.FJCardLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.TextBox txtHiragana;
     //   private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtHanNom;
        private System.Windows.Forms.Timer timer_Flag;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grammarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

