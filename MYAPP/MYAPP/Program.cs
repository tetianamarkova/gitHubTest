using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("Shall we begin? (yes/no)");
            string key = Console.ReadLine();

            string answer = "";

            if (key == "yes")
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("What do you want?");
                    Console.WriteLine("1 - Add user");
                    Console.WriteLine("2 - Remove user");
                    Console.WriteLine("3 - Sort");
                    Console.WriteLine("4 - Print");
                    Console.WriteLine("5 - To file");
                    Console.WriteLine("6 - From file");
                    Console.WriteLine("7 - Exit");

                    answer = Console.ReadLine();
                    Console.Clear();

                    switch (answer)
                    {
                        case "1":
                            menu.Add();
                            break;
                        case "2":
                            menu.Remove();
                            break;
                        case "3":
                            menu.Sort();
                            break;
                        case "4":
                            menu.Print();
                            break;
                        case "5":
                            menu.SaveToFile();
                            break;
                        case "6":
                            menu.LoadFromFile();
                            break;

                    }


                } while (answer != "7");
            }
        }
    }
}
