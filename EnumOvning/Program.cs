using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOvning
{
    enum Menu
    {
        ett, tvau, avsluta
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool loopa = true;
            do
            {
                PrintMenu();
                loopa = MenuChoice(loopa);
            } while (loopa);
        }

        private static void PrintMenu()
        {
            int counter = 0;
            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
        }

        private static bool MenuChoice(bool loopa)
        {
            int tal;
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                Menu menu = (Menu)tal;
                switch (menu)
                {
                    case (Menu.ett):
                        Console.WriteLine(Menu.ett);
                        break;
                    case (Menu.tvau):
                        Console.WriteLine(Menu.tvau);
                        break;
                    case (Menu.avsluta):
                        Console.WriteLine(Menu.avsluta);
                        loopa = false;
                        break;
                    default:
                        Console.WriteLine("You wrote an invalid number, please try again.");
                        break;
                }
            }
                        return loopa;
        }
    }
}
