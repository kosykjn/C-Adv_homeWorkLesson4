using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWorkLesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientColection = new List<Client>
            {
                new Client {Id = 1, Year = 1990, Mounth = 10, Hour = 140 },
                new Client {Id = 2, Year = 1991, Mounth = 1, Hour = 130 },
                new Client {Id = 3, Year = 1993, Mounth = 7, Hour = 135 },
                new Client {Id = 4, Year = 1998, Mounth = 5, Hour = 130 }
            };

            var clientWhithMinHour = from client in clientColection
                                     where client.Hour == clientColection.Min(a => a.Hour)
                                     select client;

            Console.WriteLine("Клиенты с минимальным количеством часов:");

            foreach (var item in clientWhithMinHour)
            {
                Console.WriteLine($"ID: {item.Id} Месяц: {item.Mounth} Год: {item.Year}");
            }

            var lastClient = clientWhithMinHour.Last();

            Console.WriteLine(new string('-', 20));

            Console.WriteLine($"ID:{lastClient.Id} Месяц: {lastClient.Mounth} Год: {lastClient.Year}");

            Console.ReadKey();
        }
    }
}
