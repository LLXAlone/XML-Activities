using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_XML
{
    public class Employee : Person
    {
        public Employee() { }

        public void Teach()
        {
            Console.WriteLine("The employee is teaching...");
        }

        public void AdminWork()
        {
            Console.WriteLine("The employee is doing admin work...");
        }
    }
}
