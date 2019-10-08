using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyArray();
            ThreeElementsArray();
            FindMaxValue();
            Console.ReadKey();
        }

        static int[] EmptyArray()
        {
            return new int[0];
        }

        static void ThreeElementsArray()
        {
            object[] array = new object[3];
            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            array[0] = (int)array[0] + 10;
            array[2] += ", guys!";

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void FindMaxValue()
        {
            int[] array = new int[13];
            int maxValue = 0;
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            Console.WriteLine("Массив:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Максимальное значение в массиве: " + maxValue + ".");
        }
    }
}
