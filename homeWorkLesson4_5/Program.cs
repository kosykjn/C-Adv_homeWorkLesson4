using System;
using System.Collections.Generic;

namespace homeWorkLesson4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dictionary = new Dictionary<string, string>
            {
                {"Cat", "Кошка"},
                {"Dog","Собака"},
                {"House","Дом"},
                {"Bag","Сумка"},
                {"Finger","Палец"},
                {"Telephone","Телефон"},
                {"Small","Небольшой"},
                {"Pen","Ручка"},
                {"Father","Отец"},
                {"Girl","Девочка"}
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}  - {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
