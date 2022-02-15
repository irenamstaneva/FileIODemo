using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\35989\OneDrive\Документи\C# кодовете на Ирена\Demo\test.txt";
            lines = File.ReadAllLines(filePath).ToList();

            List<string> lines=new List<string>();
            List<Person> people = new List<Person>();
            List<string> outContents = new List<string>();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
            }
            

            foreach(Person p in people)
            {
                Console.WriteLine(p);
                outContents.Add(p.ToString());
            }
            string outFile= @"C:\Users\35989\OneDrive\Документи\C# кодовете на Ирена\Demo\outFile.txt";
            File.WriteAllLines(outFile,outContents);
            Console.ReadLine();
        }
    }
}
