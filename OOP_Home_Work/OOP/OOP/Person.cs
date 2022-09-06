using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {

        private string name;
        private int age;
        private string phone;
        private bool isMale;

        internal string Name { get { return name; } set { name = value; } }

        internal int Age { get { return age; } set { age = value > 0 ? value : 0; } }

        public string Phone { get { return phone; } set { phone = value; } }

        public bool IsMale { get { return isMale; } set { isMale = value; } }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Phone = "Unknown";
            IsMale = false;
        }

        public Person(string name, int age, string phone, bool isMale)
        {
            Name = name;
            Age = age;
            Phone = phone;
            IsMale = isMale;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name:" +Name+"\n"+"Age: "+Age+"\n"+"Phone: "+Phone+"\n"+"male: "+IsMale);
        }

    }
}
