using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Matcher
{
    public partial class matcherForm : Form
    {
        public matcherForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            matchedRichTextBox.Text = "";
            MatchCollection matchSeeker = Regex.Matches(inputRichTextBox.Text, patternTextBox.Text);
            for (int i = 0; i < matchSeeker.Count; i++)
            {
                matchedRichTextBox.Text += matchSeeker[i].Value + '\n';
            }
        }
    }
}
