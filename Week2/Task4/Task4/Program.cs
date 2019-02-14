using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Create(@"C: \Users\ww\source\Test.txt");
            fs.Close();
            File.Copy(@"C: \Users\ww\source\Test.txt", @"C:\Users\ww\source\repos\Test.txt", true);
            StreamWriter file = new StreamWriter(@"C:\Users\ww\source\repos\Test.txt");
            file.Close();
            File.Delete(@"C: \Users\ww\source\Test.txt");
        }
    }
}
