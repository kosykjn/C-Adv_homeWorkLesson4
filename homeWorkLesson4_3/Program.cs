using System;
using System.Linq;

namespace homeWorkLesson4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[30];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
            }

            Console.WriteLine("Целочисленная последовательность:");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            var firstPositivNumber = from x in arr
                                     where x >= 0
                                     orderby x ascending
                                     select x;

            var lastNegativeNumber = from x in arr
                                     where x < 0
                                     orderby x descending
                                     select x;

            Console.WriteLine(new string('-',20));

            Console.WriteLine($"Первое положительное число: {firstPositivNumber.First()}");

            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"Последнее отрицательное число: {lastNegativeNumber.Last()}");

            Console.ReadKey();
        }
    }
}
