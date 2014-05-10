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
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCompiled = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbProgram = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Constants = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.includesView = new System.Windows.Forms.ListView();
            this.predecessorsView = new System.Windows.Forms.ListView();
            this.reservedWordsView = new System.Windows.Forms.ListView();
            this.symbolsView = new System.Windows.Forms.ListView();
            this.constantsView = new System.Windows.Forms.ListView();
            this.literalsView = new System.Windows.Forms.ListView();
            this.List_Error = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.compileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbProgram);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Constants);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.includesView);
            this.splitContainer1.Panel1.Controls.Add(this.predecessorsView);
            this.splitContainer1.Panel1.Controls.Add(this.reservedWordsView);
            this.splitContainer1.Panel1.Controls.Add(this.symbolsView);
            this.splitContainer1.Panel1.Controls.Add(this.constantsView);
            this.splitContainer1.Panel1.Controls.Add(this.literalsView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.List_Error);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(676, 440);
            this.splitContainer1.SplitterDistance = 318;
            this.splitContainer1.TabIndex = 1;
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(3, 0);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(670, 161);
            this.tbProgram.TabIndex = 3;
            this.tbProgram.Text = "";
            this.tbProgram.TextChanged += new System.EventHandler(this.tbProgram_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Includes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Predecessors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reserved words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbols";
            // 
            // Constants
            // 
            this.Constants.AutoSize = true;
            this.Constants.Location = new System.Drawing.Point(146, 164);
            this.Constants.Name = "Constants";
            this.Constants.Size = new System.Drawing.Size(54, 13);
            this.Constants.TabIndex = 2;
            this.Constants.Text = "Constants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Literals";
            // 
            // includesView
            // 
            this.includesView.Location = new System.Drawing.Point(569, 185);
            this.includesView.Name = "includesView";
            this.includesView.Size = new System.Drawing.Size(104, 130);
            this.includesView.TabIndex = 1;
            this.includesView.UseCompatibleStateImageBehavior = false;
            // 
            // predecessorsView
            // 
            this.predecessorsView.Location = new System.Drawing.Point(462, 185);
            this.predecessorsView.Name = "predecessorsView";
            this.predecessorsView.Size = new System.Drawing.Size(101, 130);
            this.predecessorsView.TabIndex = 1;
            this.predecessorsView.UseCompatibleStateImageBehavior = false;
            // 
            // reservedWordsView
            // 
            this.reservedWordsView.Location = new System.Drawing.Point(352, 185);
            this.reservedWordsView.Name = "reservedWordsView";
            this.reservedWordsView.Size = new System.Drawing.Size(104, 130);
            this.reservedWordsView.TabIndex = 1;
            this.reservedWordsView.UseCompatibleStateImageBehavior = false;
            // 
            // symbolsView
            // 
            this.symbolsView.Location = new System.Drawing.Point(234, 185);
            this.symbolsView.Name = "symbolsView";
            this.symbolsView.Size = new System.Drawing.Size(112, 130);
            this.symbolsView.TabIndex = 1;
            this.symbolsView.UseCompatibleStateImageBehavior = false;
            // 
            // constantsView
            // 
            this.constantsView.Location = new System.Drawing.Point(115, 185);
            this.constantsView.Name = "constantsView";
            this.constantsView.Size = new System.Drawing.Size(113, 130);
            this.constantsView.TabIndex = 1;
            this.constantsView.UseCompatibleStateImageBehavior = false;
            // 
            // literalsView
            // 
            this.literalsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.literalsView.Location = new System.Drawing.Point(3, 185);
            this.literalsView.Name = "literalsView";
            this.literalsView.Size = new System.Drawing.Size(106, 130);
            this.literalsView.TabIndex = 1;
            this.literalsView.UseCompatibleStateImageBehavior = false;
            // 
            // List_Error
            // 
            this.List_Error.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Line,
            this.Error});
            this.List_Error.Location = new System.Drawing.Point(3, 0);
            this.List_Error.Margin = new System.Windows.Forms.Padding(0);
            this.List_Error.Name = "List_Error";
            this.List_Error.Size = new System.Drawing.Size(670, 118);
            this.List_Error.TabIndex = 6;
            this.List_Error.UseCompatibleStateImageBehavior = false;
            this.List_Error.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "#";
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 40;
            // 
            // Error
            // 
            this.Error.Text = "Error";
            this.Error.Width = 600;
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
            this.Text = "Compiler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox tbCompiled;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView literalsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Constants;
        private System.Windows.Forms.ListView constantsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView symbolsView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView reservedWordsView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView predecessorsView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView includesView;
        private System.Windows.Forms.RichTextBox tbProgram;

        private System.Windows.Forms.ListView List_Error;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.ColumnHeader Error;
    }
}