
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Persons_Serializer
{
    [Serializable]
    public class Person
    {
        private string name;
        private string address;
        private string phoneNumber;
        private DateTime dateOfDataRecording;
        [NonSerialized] private int serialNumber = 0;
        static bool[] serialNumberUsed = new bool[100];
        static BinaryFormatter formatter = new BinaryFormatter();

        public static Person FromFile(int id)
        {
            string idAsString = id.ToString();
            if (idAsString.Length == 1)
            {
                idAsString = "0" + idAsString;
            }
            string fileName = "person" + idAsString + ".dat";
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Person p = (Person) formatter.Deserialize(fs);
            fs.Close();
            p.SerialNumber = id;
            serialNumberUsed[id] = true;
            return p;
        }

        public Person()
        {
            for (int i = 0; i < 100; i++)
            {
                if (!serialNumberUsed[i])
                {
                    SerialNumber = i;
                    serialNumberUsed[i] = true;
                    Name = "";
                    Address = "";
                    PhoneNumber = "";
                    DateOfDataRecording = DateTime.Now;
                    return;
                }
            }
            throw new StoringMaxException();
        }

        ~Person()
        {
            serialNumberUsed[SerialNumber] = false;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public DateTime DateOfDataRecording
        {
            get
            {
                return dateOfDataRecording;
            }

            set
            {
                dateOfDataRecording = value;
            }
        }

        public int SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }

        public void ToFile()
        {
            string idAsString = SerialNumber.ToString();
            if (idAsString.Length == 1)
            {
                idAsString = "0" + idAsString;
            }
            string fileName = "person" + idAsString + ".dat";
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            formatter.Serialize(fs, this);
            fs.Close();
        }
    }
}
