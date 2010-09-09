namespace JCard
{
    partial class fControl
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
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        	this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.practiceVocalularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.practiceGrammarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.contextMenuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.practiceVocalularyToolStripMenuItem,
        	        	        	this.practiceGrammarToolStripMenuItem});
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
        	// 
        	// toolStrip1
        	// 
        	this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
        	this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        	this.toolStrip1.Name = "toolStrip1";
        	this.toolStrip1.Size = new System.Drawing.Size(295, 25);
        	this.toolStrip1.TabIndex = 1;
        	this.toolStrip1.Text = "toolStrip1";
        	// 
        	// notifyIcon1
        	// 
        	this.notifyIcon1.Text = "notifyIcon1";
        	this.notifyIcon1.Visible = true;
        	// 
        	// practiceVocalularyToolStripMenuItem
        	// 
        	this.practiceVocalularyToolStripMenuItem.Name = "practiceVocalularyToolStripMenuItem";
        	this.practiceVocalularyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
        	this.practiceVocalularyToolStripMenuItem.Text = "Vocalulary";
        	// 
        	// practiceGrammarToolStripMenuItem
        	// 
        	this.practiceGrammarToolStripMenuItem.Name = "practiceGrammarToolStripMenuItem";
        	this.practiceGrammarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
        	this.practiceGrammarToolStripMenuItem.Text = "Grammar";
        	// 
        	// fControl
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(295, 84);
        	this.ContextMenuStrip = this.contextMenuStrip1;
        	this.Controls.Add(this.toolStrip1);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "fControl";
        	this.Text = "JCARD - 2 in 1";
        	this.Load += new System.EventHandler(this.FControlLoad);
        	this.contextMenuStrip1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem practiceGrammarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceVocalularyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        #endregion
    }
}