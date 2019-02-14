using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[];
            
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}
