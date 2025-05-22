using com.calitha.goldparser;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Compiler : Form
    {
        MyParser parser;
        public Compiler()
        {
            InitializeComponent();
            parser = new MyParser("Lang.cgt");
            parser.OnError += Parser_OnError;
            parser.OnReadToken += Parser_OnReadToken;
        }

        private void Parser_OnReadToken(int id, string token)
        {
            lstReadTokens.Items.Add(id.ToString()).SubItems.Add(token);
        }

        private void Parser_OnError(int line, string unExpected, string expected)
        {
            var lst = lstErrors.Items.Add(line.ToString());
            lst.SubItems.Add(unExpected);
            lst.SubItems.Add(expected);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = (FormWindowState)(this.WindowState == FormWindowState.Maximized ? 0 : 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; // Prevents the default tab behavior
                int selectionStart = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Insert(selectionStart, "    "); // Inserts a tab character at the current cursor position
                textBox1.SelectionStart = selectionStart + 4; // Moves the cursor after the inserted tab
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lstErrors.Items.Clear();
            lstReadTokens.Items.Clear();
            parser.Parse(textBox1.Text);
        }
    }
}
