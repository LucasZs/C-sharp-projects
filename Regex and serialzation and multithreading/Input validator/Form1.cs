using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input_validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");

            return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(nameTextBox.Text, @"^([A-Za-z]*\s*)*$"))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");

            if (!Regex.IsMatch(phoneTextBox.Text, @"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{4}$"))
                MessageBox.Show("The phone number is not a valid US phone number");

            if (!Regex.IsMatch(emailTextBox.Text, @"^([a-zA-Z0-9_\-” [email protected]\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                MessageBox.Show("The e-mail address is not valid.");
            
            phoneTextBox.Text = ReformatPhone(phoneTextBox.Text);
        }
    }
}
