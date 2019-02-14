using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;//переменная name, которая имеет тип string
        public string id;//переменная id, которая имеет тип string
        public Student(string n, string i)
        {
            name = n;
            id = i;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"name:{name}  id:{id}");//вывести на консоль в одной строке значения сразу нескольких переменных


        }
        class Program
        {
            static void Main(string[] args)//используем метод Main,Main стартовая точка приложения 
            {
                string n;
                string k;
                Student s = new Student(n = Console.ReadLine("name:"), k = Console.ReadLine(id:));//Вводим имя и id студента          
                Console.WriteLine("Enter the year of study");//Вводим год обечение на консоль 
                int y = int.Parse(Console.ReadLine());
                s.PrintInfo();
                Console.WriteLine($" Next year of study is: {y+1}");//год обучения +1
             }
        }
    }
}
