using System;

namespace CountOfSymbolA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите слово");
            string input = Console.ReadLine();

            int count = 0;
            foreach (var letter in input.ToCharArray())
            {
                if (letter == 'a' || letter == 'A' || letter == 'а' || letter == 'А')
                    count++;
            }

            Console.WriteLine("Количество букв \"а\" в слове равно: " + count);
            Console.ReadKey();
        }
    }
}
