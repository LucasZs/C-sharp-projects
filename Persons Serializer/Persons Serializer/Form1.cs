using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persons_Serializer
{
    public partial class personsForm : Form
    {
        public Person CurrentPerson { get; private set; }

        public personsForm()
        {
            InitializeComponent();
        }

        private void LoadPerson(int id)
        {
            CurrentPerson = Person.FromFile(id);
            Text = "Person -- " + id.ToString();
            nameTextBox.Text = CurrentPerson.Name;
            addressTextBox.Text = CurrentPerson.Address;
            phoneTextBox.Text = CurrentPerson.PhoneNumber;
        }

        private void SavePerson()
        {
            CurrentPerson.ToFile();
        }

        private void personsForm_Load(object sender, EventArgs e)
        {
            LoadPerson(0);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPerson.Name = nameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPerson.Address = addressTextBox.Text;
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentPerson.PhoneNumber = phoneTextBox.Text;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            LoadPerson(CurrentPerson.SerialNumber != 0 ? (CurrentPerson.SerialNumber - 1) % 100 : 99);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            LoadPerson((CurrentPerson.SerialNumber + 1) % 100);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SavePerson();
        }
    }
}
