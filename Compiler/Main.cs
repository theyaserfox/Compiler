using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compiler
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void компілюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var compiler = new Compiler();
            tbCompiled.Text = compiler.Compile(tbProgram.Text);
            MessageBox.Show(compiler.Errors.Aggregate("", (current, error) => current + (error + Environment.NewLine)));
        }
    }
}
