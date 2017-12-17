using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyClone
{
    static class UI
    {

        public static void RetryMessage()
        {
            Console.WriteLine("Please try again. Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }
        public static void AlertNewElement(string elementResult)
        {
            Console.WriteLine("You've created {0}! Press any key to continue", elementResult);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
