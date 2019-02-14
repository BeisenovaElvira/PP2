using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww");
            PrintInfo(dir, 0);
        }

        static void PrintInfo(FileSystemInfo fs, int k)
        {
        string s = new string(' ', k);
            Console.WriteLine(s + fs.Name);
             
            if(fs.GetType()==typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fs).GetFileSystemInfos();
                for (int i=0;i<arr.Length;++i)
                {
                    PrintInfo(arr[i], k + 3);
                }
            }
            Console.ReadKey();
        }
    }
}
