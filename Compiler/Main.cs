using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Diagnostics;

namespace Compiler
{
    public partial class Main : Form
    {
        string path;
        int error_no = 1;

        public Main()
        {
            InitializeComponent();
            runToolStripMenuItem.Enabled = false; //Run Is Disabled
        }

        private static bool ChangeColor(RichTextBox RTB, int StartPos, string Regex1, Color color)
        {
            bool t = false;

            Regex R = new Regex(Regex1);
            //   RTB.SelectAll();
            //  RTB.SelectionColor = Color.White;
            RTB.Select(RTB.Text.Length, 1);

            foreach (Match Match in R.Matches(RTB.Text))
            {
                RTB.Select(Match.Index, Match.Length);
                RTB.SelectionColor = color;
                RTB.SelectionStart = StartPos;
                t = true;
            }
            // rtb.SelectionColor = Color.Black;
            return t;
        }


        private void tbProgram_TextChanged(object sender, EventArgs e)
        {

            error_no = 1;
            List_Error.Items.Clear();
            tbProgram.SelectionColor = Color.Black;
            //No semi_colon
            //ChangeColor(tbProgram, 0, "[^,;]+", Color.Red);
            if (!tbProgram.Text.EndsWith("\n"))
                if (ChangeColor(tbProgram, 0, ".*[^;]$", Color.Red) && !tbCompiled.Text.EndsWith("\n"))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = error_no.ToString();
                    error_no++;
                    item.SubItems.Add("Current");
                    item.SubItems.Add("Semicolon not added");
                    List_Error.Items.Add(item);
                    //Errors.Add("Error with parenthese");
                }
            ChangeColor(tbProgram, 0, ".*?\\(\\)", Color.Black);
            ChangeColor(tbProgram, 0, ".*?;", Color.Black);
            ChangeColor(tbProgram, 0, "{?", Color.Black);
            ChangeColor(tbProgram, 0, "}?", Color.Black);
            //find comments            
            ChangeColor(tbProgram, 0, "(/\\*([^*]|[\r\n]|(\\*+([^*/]|[\r\n])))*\\*+/)|(//.*)", Color.Green);
            //find types
            ChangeColor(tbProgram, 0, @"\bint\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bstring\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bdouble\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bfloat\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\blong\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bshort\b", Color.Blue);
            //find condictions
            ChangeColor(tbProgram, 0, @"\bif\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bwhile\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bfor\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bforeach\b", Color.Blue);
            ChangeColor(tbProgram, 0, @"\bswitch\b", Color.Blue);
            //include
            ChangeColor(tbProgram, 0, "#include", Color.Purple);
            //using
            ChangeColor(tbProgram, 0, @"\busing\b", Color.Blue);
            //return
            ChangeColor(tbProgram, 0, @"\breturn\b", Color.Blue);

            /*if (FindRegexCount(tbProgram, 1, @"\(.*?\)") != FindRegexCount(tbProgram, 1, "\\("))
            {

                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error with parenthese");
                List_Error.Items.Add(item);
            }


            if (FindRegexCount(tbProgram, 1, @"\(.*?\)") != FindRegexCount(tbProgram, 1, "\\)"))
            {

                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error with parenthese");
                List_Error.Items.Add(item);
            }

            if (FindRegexCount(tbProgram, 1, @"\{.*?\}") != FindRegexCount(tbProgram, 1, "\\{"))
            {

                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error with curly brackets");
                List_Error.Items.Add(item);
            }


            if (FindRegexCount(tbProgram, 1, @"\{.*?\}") != FindRegexCount(tbProgram, 1, "\\}"))
            {

                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error with curly brackets");
                List_Error.Items.Add(item);
            }*/
            int leftSquatebrackt = 0;
            int rightSquarebracket = 0;
            int leftParentheses = 0;
            int rightParentheses = 0;
            int rightbraces = 0;
            int leftbraces = 0;

            for (int i = 0; i < tbProgram.Text.Length;i++ )
            {
                if (tbProgram.Text[i] == '[')
                {
                    leftSquatebrackt++;
                }
                else if(tbProgram.Text[i] == ']')
                {
                    rightSquarebracket++;
                }
                else if (tbProgram.Text[i] == '(')
                {
                    leftParentheses++;
                }
                else if (tbProgram.Text[i] == ')')
                {
                    rightParentheses++;
                }
                else if (tbProgram.Text[i] == '{')
                {
                    leftbraces++;
                }
                else if (tbProgram.Text[i] == '}')
                {
                    rightbraces++;
                }
            }
            if(leftSquatebrackt!=rightSquarebracket)
            {
                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error In Arary Bracket");
                List_Error.Items.Add(item);
            }
            if (rightParentheses != leftParentheses)
            {
                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error In praentheses");
                List_Error.Items.Add(item);
            }
            if(leftbraces!=rightbraces)
            {
                ListViewItem item = new ListViewItem();
                item.Text = error_no.ToString();
                error_no++;
                item.SubItems.Add("");
                item.SubItems.Add("Error In braces");
                List_Error.Items.Add(item);
            }

            tbProgram.SelectionColor = Color.Black;
        }

        private static int FindRegexCount(RichTextBox RTB, int StartPos, string Regex1)
        {
            Regex R = new Regex(Regex1);
            RTB.Select(RTB.Text.Length, 1);
            MatchCollection New_Line_Match = R.Matches(RTB.Text);
            return New_Line_Match.Count;
        }

        private void LoadnToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            OpenFileDialog OFD = new OpenFileDialog();
            //set the title of the save file dialog
            OFD.Title = "Open TXT from ....";
            //adding a filter to make sure it saved as exe
            OFD.Filter = "TXT|*.txt";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbProgram.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbProgram.Text.Length == 0)
                MessageBox.Show("The Editor is empty");
            else
            {
                SaveFileDialog SFD = new SaveFileDialog();
                //set the title of the save file dialog
                SFD.Title = "Save TXT to ....";
                //adding a filter to make sure it saved as exe
                SFD.Filter = "TXT|*.txt";
                if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    tbProgram.SaveFile(SFD.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            literalsView.Items.Clear();
            constantsView.Items.Clear();
            symbolsView.Items.Clear();
            reservedWordsView.Items.Clear();
            predecessorsView.Items.Clear();
            includesView.Items.Clear();
            Compiler compiler = new Compiler();
            tbCompiled.Text = compiler.Compile(tbProgram.Text, ref error_no, ref List_Error, ref literalsView, ref constantsView, ref symbolsView, ref reservedWordsView, ref predecessorsView, ref includesView);
            //tbCompiled.Text = Errors.Aggregate("", (current, error) => current + (error + Environment.NewLine));
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new instance of save file dialoge
            SaveFileDialog SFD = new SaveFileDialog();
            //set the title of the save file dialog
            SFD.Title = "Save EXE to ....";
            //adding a filter to make sure it saved as exe
            SFD.Filter = "EXE|*.exe";


            // if the user pressed ok on the form build it
            if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //clear the list
                List_Error.Items.Clear();
                //path = file name
                path = SFD.FileName;

                //Create a code Provider for the language path
                CodeDomProvider Code_Provider = CodeDomProvider.CreateProvider("CSharp");//create the pramter for code provider            }
                CompilerParameters prameters = new CompilerParameters(); //create prameters for code cmpiler
                prameters.GenerateExecutable = true; // make it that it generats an executable
                prameters.OutputAssembly = SFD.FileName; // output location == save file dialoge

                //compile the code in the rich box, return the error
                CompilerResults Results = Code_Provider.CompileAssemblyFromSource(prameters, tbProgram.Text);

                //error cheaking
                if (Results.Errors.Count > 0)
                {
                    //loop through each error
                    foreach (CompilerError cmperror in Results.Errors)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = cmperror.ErrorNumber + error_no;
                        item.SubItems.Add(cmperror.Line.ToString());
                        item.SubItems.Add(cmperror.ErrorText);
                        List_Error.Items.Add(item);

                    }
                }
                else
                {
                    runToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }

        private void clearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            literalsView.Items.Clear();
            constantsView.Items.Clear();
            symbolsView.Items.Clear();
            reservedWordsView.Items.Clear();
            predecessorsView.Items.Clear();
            includesView.Items.Clear();
            tbCompiled.Clear();
            List_Error.Items.Clear();
            error_no = 1;
        }
    }
}