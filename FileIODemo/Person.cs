using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    internal class Person
    {
        public Person(string FirstName, string LastName, string uRL)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.URL = uRL;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName +" , Last Name: "+lastName+ " , URL: "+URL;
        }
    }
}
