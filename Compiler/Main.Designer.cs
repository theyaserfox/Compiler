namespace Compiler
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компілюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCompiled = new System.Windows.Forms.TextBox();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.literalsView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.constantsView = new System.Windows.Forms.ListView();
            this.Constants = new System.Windows.Forms.Label();
            this.symbolsView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компілюватиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компілюватиToolStripMenuItem
            // 
            this.компілюватиToolStripMenuItem.Name = "компілюватиToolStripMenuItem";
            this.компілюватиToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.компілюватиToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.компілюватиToolStripMenuItem.Text = "Компілювати";
            this.компілюватиToolStripMenuItem.Click += new System.EventHandler(this.компілюватиToolStripMenuItem_Click);
            // 
            // tbCompiled
            // 
            this.tbCompiled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompiled.Location = new System.Drawing.Point(3, 3);
            this.tbCompiled.Multiline = true;
            this.tbCompiled.Name = "tbCompiled";
            this.tbCompiled.Size = new System.Drawing.Size(670, 112);
            this.tbCompiled.TabIndex = 0;
            // 
            // tbProgram
            // 
            this.tbProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProgram.Location = new System.Drawing.Point(3, 3);
            this.tbProgram.Multiline = true;
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(670, 154);
            this.tbProgram.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Constants);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.symbolsView);
            this.splitContainer1.Panel1.Controls.Add(this.constantsView);
            this.splitContainer1.Panel1.Controls.Add(this.literalsView);
            this.splitContainer1.Panel1.Controls.Add(this.tbProgram);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbCompiled);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(676, 440);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 1;
            // 
            // literalsView
            // 
            this.literalsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.literalsView.Location = new System.Drawing.Point(3, 185);
            this.literalsView.Name = "literalsView";
            this.literalsView.Size = new System.Drawing.Size(121, 130);
            this.literalsView.TabIndex = 1;
            this.literalsView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Literals";
            // 
            // constantsView
            // 
            this.constantsView.Location = new System.Drawing.Point(130, 185);
            this.constantsView.Name = "constantsView";
            this.constantsView.Size = new System.Drawing.Size(121, 130);
            this.constantsView.TabIndex = 1;
            this.constantsView.UseCompatibleStateImageBehavior = false;
            // 
            // Constants
            // 
            this.Constants.AutoSize = true;
            this.Constants.Location = new System.Drawing.Point(163, 164);
            this.Constants.Name = "Constants";
            this.Constants.Size = new System.Drawing.Size(54, 13);
            this.Constants.TabIndex = 2;
            this.Constants.Text = "Constants";
            // 
            // symbolsView
            // 
            this.symbolsView.Location = new System.Drawing.Point(257, 185);
            this.symbolsView.Name = "symbolsView";
            this.symbolsView.Size = new System.Drawing.Size(121, 130);
            this.symbolsView.TabIndex = 1;
            this.symbolsView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbols";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 464);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компілюватиToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCompiled;
        private System.Windows.Forms.TextBox tbProgram;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView literalsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Constants;
        private System.Windows.Forms.ListView constantsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView symbolsView;
    }
}