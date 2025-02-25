using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_XML
{
    public class Person : IPerson
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Mname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }

        public string GetName()
        {
            return $"{Fname} {Lname}";
        }

        public void SetName(string firstName, string lastName)
        {
            Fname = firstName;
            Lname = lastName;
        }
    }
}
