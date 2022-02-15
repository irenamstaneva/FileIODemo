using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOGUI
{
    internal class Person
    {
        public Person(string FirstName, string LastName, string URL) 
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.uRL = URL;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string uRL { get; set; }

        public override string ToString()
        {
            return "First Name:"+firstName+", Last Name:"+lastName+", URL:"+uRL;
        }
    }
}
