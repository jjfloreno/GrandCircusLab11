using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UML
{
    class Staff:Person
    {
        //fields
        private string school;
        private double pay;

        //properties
        public string School
        {
            set { school = value; }

            get { return school; }
        }
        public double Pay
        {
            set { pay = value; }

            get { return pay; }
        }

        //constructors
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public Staff() : this("Name Unknown", "1234 Learn Blvd", "Institution", 50000)
        {

        }

        //methods
        public override string ToString()
        {
            return $"Staff: {Name, -20}Address: {Address, -30}School: {School, -20}Pay: {Pay, -10:C0}";
        }
    }
}
