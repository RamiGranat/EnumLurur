using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLurum
{
    enum Menu
    {
        Add, Subtract, Multiply, Divide, End
    }
    class Program
    {

        static void Main(string[] args)
        {
            StartMathProgram();
        }

        private static void StartMathProgram()
        {
            bool loopa = true;
            do
            {
                Console.Clear();
                PrintMenuWithEnums();
                loopa = MenuChoice(loopa);
            } while (loopa);
            Console.ReadLine();
        }

        private static bool MenuChoice(bool loopa)
        {
            int tal;
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                Menu menu = (Menu)tal;
                switch (menu)
                {
                    case Menu.Add:
                        AddMethod();
                        break;
                    case Menu.Subtract:
                        Console.WriteLine(Menu.Subtract);
                        break;
                    case Menu.Multiply:
                        Console.WriteLine(Menu.Multiply);
                        break;
                    case Menu.Divide:
                        Console.WriteLine(Menu.Divide);
                        break;
                    case Menu.End:
                        Console.WriteLine(Menu.End);
                        loopa = false;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Something went wrong, please try again.");
                        break;
                }
                System.Threading.Thread.Sleep(3000);
            }
            //Läs in ett tal
            //Omvandla talet till en enum
            //Switcha på enumet
            //Vi får nog loopa detta
            return loopa;
        }

        private static void AddMethod()
        {
            Console.WriteLine(Menu.Add);
            int tal1, tal2;
            Console.WriteLine("Skriv in två tal som du vill addera");
            if (int.TryParse(Console.ReadLine(), out tal1) && int.TryParse(Console.ReadLine(), out tal2))
            {
                Console.WriteLine("{0}+{1}={2}", tal1, tal2, tal1 + tal2);
            }
        }

        private static void PrintMenuWithEnums()
        {
            int counter = 0;
            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
            Console.WriteLine("Please enter a number from the list above.");
        }
    }
}


