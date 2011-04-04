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
            this.tempTextbox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer_Flag = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlMeaning = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMeaning = new System.Windows.Forms.Label();
            this.pnlHanNom = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtHanNom = new System.Windows.Forms.Label();
            this.pnlHiragana = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtHiragana = new System.Windows.Forms.Label();
            this.pnlKanji = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtKanji = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMeaning.SuspendLayout();
            this.pnlHanNom.SuspendLayout();
            this.pnlHiragana.SuspendLayout();
            this.pnlKanji.SuspendLayout();
            this.SuspendLayout();
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
            // timer_Flag
            // 
            this.timer_Flag.Enabled = true;
            this.timer_Flag.Interval = 1000;
            this.timer_Flag.Tick += new System.EventHandler(this.timer_Flag_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Jcard";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vocabularyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vocabularyToolStripMenuItem.Text = "Back to Main screen";
            this.vocabularyToolStripMenuItem.Click += new System.EventHandler(this.vocabularyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_2);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlMeaning);
            this.panel4.Controls.Add(this.pnlHanNom);
            this.panel4.Controls.Add(this.pnlHiragana);
            this.panel4.Controls.Add(this.pnlKanji);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 160);
            this.panel4.TabIndex = 3;
            // 
            // pnlMeaning
            // 
            this.pnlMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMeaning.Controls.Add(this.panel11);
            this.pnlMeaning.Controls.Add(this.panel8);
            this.pnlMeaning.Controls.Add(this.txtMeaning);
            this.pnlMeaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMeaning.Location = new System.Drawing.Point(0, 120);
            this.pnlMeaning.Name = "pnlMeaning";
            this.pnlMeaning.Size = new System.Drawing.Size(194, 40);
            this.pnlMeaning.TabIndex = 107;
            // 
            // panel11
            // 
            this.panel11.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 40);
            this.panel11.TabIndex = 10009;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.panel11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // panel8
            // 
            this.panel8.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(192, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 40);
            this.panel8.TabIndex = 10008;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMeaning.Location = new System.Drawing.Point(7, 8);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(180, 23);
            this.txtMeaning.TabIndex = 10007;
            this.txtMeaning.Text = "label2";
            this.txtMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHanNom
            // 
            this.pnlHanNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlHanNom.Controls.Add(this.panel10);
            this.pnlHanNom.Controls.Add(this.panel7);
            this.pnlHanNom.Controls.Add(this.txtHanNom);
            this.pnlHanNom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHanNom.Location = new System.Drawing.Point(0, 80);
            this.pnlHanNom.Name = "pnlHanNom";
            this.pnlHanNom.Size = new System.Drawing.Size(194, 40);
            this.pnlHanNom.TabIndex = 105;
            // 
            // panel10
            // 
            this.panel10.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 40);
            this.panel10.TabIndex = 10008;
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // panel7
            // 
            this.panel7.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(192, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 40);
            this.panel7.TabIndex = 10007;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtHanNom
            // 
            this.txtHanNom.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanNom.Location = new System.Drawing.Point(7, 8);
            this.txtHanNom.Name = "txtHanNom";
            this.txtHanNom.Size = new System.Drawing.Size(180, 23);
            this.txtHanNom.TabIndex = 10006;
            this.txtHanNom.Text = "label2";
            this.txtHanNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHiragana
            // 
            this.pnlHiragana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlHiragana.Controls.Add(this.panel9);
            this.pnlHiragana.Controls.Add(this.panel6);
            this.pnlHiragana.Controls.Add(this.txtHiragana);
            this.pnlHiragana.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHiragana.Location = new System.Drawing.Point(0, 40);
            this.pnlHiragana.Name = "pnlHiragana";
            this.pnlHiragana.Size = new System.Drawing.Size(194, 40);
            this.pnlHiragana.TabIndex = 104;
            // 
            // panel9
            // 
            this.panel9.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 40);
            this.panel9.TabIndex = 10007;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // panel6
            // 
            this.panel6.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(192, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 40);
            this.panel6.TabIndex = 10006;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtHiragana
            // 
            this.txtHiragana.Font = new System.Drawing.Font("MS Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHiragana.Location = new System.Drawing.Point(7, 8);
            this.txtHiragana.Name = "txtHiragana";
            this.txtHiragana.Size = new System.Drawing.Size(180, 23);
            this.txtHiragana.TabIndex = 10005;
            this.txtHiragana.Text = "label2";
            this.txtHiragana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlKanji
            // 
            this.pnlKanji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlKanji.Controls.Add(this.panel2);
            this.pnlKanji.Controls.Add(this.panel5);
            this.pnlKanji.Controls.Add(this.txtKanji);
            this.pnlKanji.Controls.Add(this.label1);
            this.pnlKanji.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKanji.Location = new System.Drawing.Point(0, 0);
            this.pnlKanji.Name = "pnlKanji";
            this.pnlKanji.Size = new System.Drawing.Size(194, 40);
            this.pnlKanji.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 40);
            this.panel2.TabIndex = 10006;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove2);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // panel5
            // 
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(192, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 40);
            this.panel5.TabIndex = 10005;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // txtKanji
            // 
            this.txtKanji.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKanji.Location = new System.Drawing.Point(7, 8);
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.Size = new System.Drawing.Size(180, 23);
            this.txtKanji.TabIndex = 10004;
            this.txtKanji.Text = "label2";
            this.txtKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10003;
            // 
            // fJCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(194, 160);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tempTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fJCard";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JCard- Vocabulary";
            this.Load += new System.EventHandler(this.FJCardLoad);
            this.MouseLeave += new System.EventHandler(this.FJCardMouseLeave);
            this.MouseHover += new System.EventHandler(this.FJCardMouseHover);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlMeaning.ResumeLayout(false);
            this.pnlHanNom.ResumeLayout(false);
            this.pnlHiragana.ResumeLayout(false);
            this.pnlKanji.ResumeLayout(false);
            this.pnlKanji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //   private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox tempTextbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer_Flag;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlMeaning;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label txtMeaning;
        private System.Windows.Forms.Panel pnlHanNom;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtHanNom;
        private System.Windows.Forms.Panel pnlHiragana;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtHiragana;
        private System.Windows.Forms.Panel pnlKanji;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtKanji;
        private System.Windows.Forms.Label label1;
    }
}

