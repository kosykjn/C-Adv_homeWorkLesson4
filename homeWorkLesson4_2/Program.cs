using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWorkLesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var carColection = new List<CarInfo>
            {
                new CarInfo{CarMark = "BMW", CarModel = "X5", YearOfCarManufacture = 2018, Color = "Black"},
                 new CarInfo{CarMark = "Mercedes", CarModel = "S500", YearOfCarManufacture = 2016, Color = "White"},
                new CarInfo{CarMark = "BMW", CarModel = "M5", YearOfCarManufacture = 2015, Color = "White"},
                 new CarInfo{CarMark = "Mazda", CarModel = "RX7", YearOfCarManufacture = 2017, Color = "Red"}
            };

            var buyerInfo = new List<BuyerInfo>
            { 
                new BuyerInfo {CarModel = "X5", BuyerName = "Vasya", TelephoneNumberBuyer = 32145678},
                new BuyerInfo {CarModel = "RX7", BuyerName = "Petya", TelephoneNumberBuyer = 36804050},
                new BuyerInfo {CarModel = "S500", BuyerName = "Olya", TelephoneNumberBuyer = 43214321},
            };

            var fullInfoBuyer = from car in carColection
                                join buyer in buyerInfo on car.CarModel equals buyer.CarModel
                                select new {
                                    Name = buyer.BuyerName, 
                                    Telephone = buyer.TelephoneNumberBuyer,
                                    car.CarMark, car.CarModel,
                                    car.YearOfCarManufacture,
                                    car.Color
                                };

            foreach (var buyer in fullInfoBuyer)
            {
                Console.WriteLine($"Имя:{buyer.Name} Номер мобильного:{buyer.Telephone}");
                Console.WriteLine($"Марка авто: {buyer.CarMark}; Модель : {buyer.CarModel}; " +
                    $"Год выпуска: {buyer.YearOfCarManufacture}; Цвет: {buyer.Color};");
                Console.WriteLine(new string('-',20));
            }

            Console.ReadKey();
        }
    }
}
