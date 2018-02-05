using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UML
{
    class Person
    {
        //fields
        private string name;
        private string address;

        //properties
        public string Name
        {
            set { name = value; }

            get { return name; }
        }

        public string Address
        {
            set { address = value; }

            get { return address; }
        }

        //constructors
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public Person() : this("Name Unknown", "742 Fake St")
        {

        }

        //methods
        public override string ToString()
        {
            return String.Format($"Person: {Name, -20}Address: {Address, -30}");
        }
    }
}
