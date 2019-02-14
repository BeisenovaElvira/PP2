using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");//вывести на консоль
            int numbers = int.Parse(Console.ReadLine());
            int j;
            bool num= false;//bool num хранить значения false
            for (int i = 2; i <= numbers; i++) // 2....++
            {
                for (j = 2; j < i; j++) 
                {
                    if (i % j == 0)//2/2=0 is true
                    {
                        num = true;
                    }
                        }
                if (num == false) 
                {
                    Console.WriteLine("Prime number are :{0}",j);//
                }
                else num = false;
            }

        }
    }
}
