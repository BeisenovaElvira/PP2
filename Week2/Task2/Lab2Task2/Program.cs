using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int numbers = int.Parse(Console.ReadLine());
            int j;
            bool prime = false;
            for(int i=0;i<numbers;i++)
            {
                for(j=2;j<0;j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                        
                }
                if (prime = true)
                {
                    Console.WriteLine("", j);

                }
                else prime = false; 
            }
                
        }
    }
}
