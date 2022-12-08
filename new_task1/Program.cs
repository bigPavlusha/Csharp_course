using System;

namespace new_task1
{
    class Program
    {
        static int Main(string[] args)
        {
            Passenger ladaHatchback = new Passenger("Голубой", 2018, 1100, "Lada", "Хэтчбэк");
            Passenger vwSedan = new Passenger("Черный", 2020, 1300, "Volkswagen", "Седан");
            Passenger chevrolet4WD = new Passenger("Черный", 2018, 1100, "Сhevrolet", "Полный привод");
            Train lastochka = new Train("Фирменная РЖД", 2015, 270000, 5);
            Truck volvoTruck = new Truck("Синий", 2020, 18000, "Volvo FM", 18000);
            Truck unknownTruck = new Truck("UnknownTruck", 0);

            TransportList trList = new TransportList();
            trList.AddToListing(ladaHatchback);
            trList.AddToListing(lastochka);
            trList.AddToListing(unknownTruck);

            foreach (Transport item in trList)
            {
                Console.WriteLine(item.ToString());
            }

            trList.DeleteFromListing(ladaHatchback);
            trList.AddToListing(vwSedan);
            trList.AddToListing(volvoTruck);
            trList.AddToListing(chevrolet4WD);

            foreach (Transport item in trList)
            {
                Console.WriteLine(item.ToString());
            }

            return 0;
        }
    }
}
