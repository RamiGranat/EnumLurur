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
            bool loopa = true;
            do
            {
                Console.Clear();
            PrintMenuWithEnums();
                int tal;
                if (int.TryParse(Console.ReadLine(), out tal))
                {
                    Menu menu = (Menu)tal;
                    switch (menu)
                    {
                        case Menu.Add:
                            Console.WriteLine(Menu.Add);
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
                    System.Threading.Thread.Sleep(4000);
                }
                //Läs in ett tal
                //Omvandla talet till en enum
                //Switcha på enumet
                //Vi får nog loopa detta
            } while (loopa);
            Console.ReadLine();
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


