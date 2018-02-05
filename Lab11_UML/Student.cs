using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UML
{
    class Student : Person
    {
        //fields
        private string program;
        private int year;
        private double fee;

        //properties
        public string Program {set; get;}
        public int Year { set; get; }
        public double Fee { set; get; }

        //constructors
        public Student(string name, string address, string program, int year, double fee): base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public Student() : this("Name Unknown", "742 Fake St", "Class Here", 2018, 1000)
        {

        }

        //methods
        public override string ToString()
        {
            return $"Student: {Name, -20}Address: {Address, -30}Program: {Program, -20}Year: {Year, -10}Fee: {Fee, -7:C0}";
        }

    }
}
