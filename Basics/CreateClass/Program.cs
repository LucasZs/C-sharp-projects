using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CreateClass
{
    [Serializable]
    class Person
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private DateTime birthDate;
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }

        public Person()
        {

        }

        public Person(string Name, DateTime birthDate)
        {
            this.Name = Name;
            this.birthDate = birthDate;
        }

        public enum Genders : int { Male, Female }

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }
    }

    class Employee : Person, ICloneable
    {
        private int salary;
        public int Salary { get { return salary; } set { salary = value; } }

        private string profession;
        public string Profession { get { return profession; } set { profession = value; } }

        public Room Room;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession) : base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", salary: {0}, profession: {1}, room: {2}", salary, profession, Room.Number);
        }

        //Implement cloning - way 1:
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //Implement cloning - way 2:
        //public object Clone()
        //{
        //Employee newEmployee = (Employee)this.MemberwiseClone();
        //newEmployee.Room = new Room(Room.Number);
        //return newEmployee;
        //}
    }

    class Room
    {
        private int number;
        public int Number { get { return number; } set { number = value; } }

        public Room(int number)
        {
            this.number = number;
        }
    }

    class Program
    {
        private static void Serialize(Person sp)
        {
            // Create file to save the data to
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);

            // Create a BinaryFormatter object to perform the serialization
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to serialize the data to the file
            bf.Serialize(fs, sp);

            // Close the file
            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp = new Person();

            // Open file to read the data from
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);

            // Create a BinaryFormatter object to perform the deserialization
            BinaryFormatter bf = new BinaryFormatter();

            // Use the BinaryFormatter object to deserialize the data from the file
            dsp = (Person)bf.Deserialize(fs);

            // Close the file
            fs.Close();

            return dsp;
        }

        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;

            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }

}
