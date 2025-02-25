using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_XML
{
    public interface IPerson
    {
        string Fname { get; set; }
        string Lname { get; set; }
        string Mname { get; set; }
        DateTime Birthday { get; set; }
        string Email { get; set; }

        string GetName();
        void SetName(string firstName, string lastName);
    }
}
