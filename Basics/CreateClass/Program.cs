using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
