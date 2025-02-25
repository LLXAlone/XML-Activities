using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_XML
{
    public class Admin : Person
    {
        public Admin() { }

        public void Create()
        {
            Console.WriteLine("The admin is creating...");
        }

        public void Update()
        {
            Console.WriteLine("The admin is updating...");
        }

        public void Delete()
        {
            Console.WriteLine("The admin is deleting...");
        }
    }
}
