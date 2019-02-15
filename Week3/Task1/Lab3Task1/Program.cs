using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task1
{
    enum FSIMode//оператор enum 
    {
        DirectoryInfo = 1,
        File = 2
    }

    class Layer//
    {
        public FileSystemInfo[] Content
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get;
            set;
        }
        public int selectedIndex = 0;

        public void Draw()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < Content.Length; ++i)
            {
                if (i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Content[i].Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files");
            Layer l = new Layer
            {
                Content = dir.GetFileSystemInfos(),// переменная content, указываем путь до папки
                SelectedIndex = 0
            };
            l.Draw();
            Stack<Layer> history = new Stack<Layer>();
            history.Push(l);


            bool esc = false;
            while (!esc)
            {
                history.Peek().Draw();
                ConsoleKeyInfo consolekeyInfo = Console.ReadKey();
                switch (consolekeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedIndex++;
                        break;
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Backspace:
                        break;
                    case ConsoleKey.Escape:
                        esc = true;
                        break;

                }
            }
        }
    }
}