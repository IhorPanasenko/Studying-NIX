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

        internal string Name { get { return name; } set { name = value; } }

        internal int Age { get { return age; } set { age = value>0?value:0; Console.WriteLine("Age must be grater than 0"); } }

        public string Phone { get { return phone; } set { phone = value; } }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Phone = "Unknown";
        }

        public Person(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            Phone = phone;
        }

    }
}
