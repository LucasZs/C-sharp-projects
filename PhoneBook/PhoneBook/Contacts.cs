using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{

    enum Type
    {
        Home, Workplace, Mobile
    }

    public struct Person
    {
        public string name;
        public string address;
        public int age;
        public string mobile;
        public int phoneType;

        public Person(string name, string address, int age, string mobile, int phoneType)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.phoneType = phoneType;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Address: {1}, Age: {2}, Mobile: {3}, Phone Type: {4}", name, address, age, mobile, phoneType);
        }
    }

    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void _Click(object sender, EventArgs e)
        {

        }
    }

    public class PhoneDirectory : List<Person>
    {
      List<Person> persons = new List<Person>();
            int sizeOfList = persons.Count
;
            while (sizeOfList <= 50)
            {
                persons.Add(new Person() { });
                sizeOfList += 1;
            }
        }
    }
}