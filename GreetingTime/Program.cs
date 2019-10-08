using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (DateTime.Now)
            {
                case DateTime time when time.Hour > 9 && time.Hour <= 12:
                    Console.WriteLine("Good morning, guys");
                    break;
                case DateTime time when time.Hour > 12 && time.Hour <= 15:
                    Console.WriteLine("Good day, guys");
                    break;
                case DateTime time when time.Hour > 15 && time.Hour <= 22:
                    Console.WriteLine("Good evening, guys");
                    break;
                case DateTime time when time.Hour > 22 || time.Hour <= 9:
                    Console.WriteLine("Good night, guys");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
