using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            //test output
            List<Person> PersonList = new List<Person>();

            PersonList.Add(new Person()); //default
            PersonList.Add(new Person("Dylan Larkin", "1500 Pizza St"));

            PersonList.Add(new Student()); //default
            PersonList.Add(new Student("John Floreno", "7359 Kenwood St", "C#", 2018, 7500));

            PersonList.Add(new Staff()); //default
            PersonList.Add(new Staff("Dr K.", "1570 Woodward Ave", "Grand Circus", 100000));

            foreach (Person p in PersonList)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
