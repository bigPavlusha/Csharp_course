using System;

namespace new_task1
{
    public abstract class Transport //базовый класс для всех остальных, не предполагаю, что он будет создан сам по себе
    {
        public string Color;
        public int Year;
        public int Weight;

        protected Transport()
        {
            Color = "Unknown";
            Year = 0;
            Weight = 0;
        }

        protected Transport(string color, int year, int weight)
        {
            Color = color;
            Year = year;
            Weight = weight;
        }
        public abstract void Information();

    }

    class Train : Transport
    {
        public int Сarriages;
        public Train(string color, int year, int weight, int carriages) : base(color, year, weight)
        {
            Сarriages = carriages;
        }

        public override void Information()
        {
            Console.WriteLine("Train");
            Console.WriteLine($"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}");
            Console.WriteLine($"Сarriages: {Сarriages}\n");
        }
    }

    class Car : Transport
    {
        public string Mark;
        public Car(string color, int year, int weight, string mark) : base(color, year, weight)
        {
            Mark = mark;
        }

        public override void Information()
        {
            Console.WriteLine("Car");
            Console.WriteLine($"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}");
            Console.WriteLine($"Mark: {Mark}\n");
        }
    }

    class Truck : Car 
    { 
        public int LoadCapacity;
        public Truck(string color, int year, int weight, string mark, int loadCapacity) : base(color, year, weight, mark)
        {
            LoadCapacity = loadCapacity;
        }

        public override void Information()
        {
            Console.WriteLine("Truck Car");
            Console.WriteLine($"Mark: {Mark}\n"+
                              $"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}\n");
            Console.WriteLine($"LoadCapacity: {LoadCapacity}\n");
        }
    }

    class Passenger : Car
    {
        public string PassengerType;
        public Passenger(string color, int year, int weight, string mark, string passengerType) : base(color, year, weight, mark)
        {
            PassengerType = passengerType;
        }

        public override void Information()
        {
            Console.WriteLine("Passenger Car");
            Console.WriteLine($"Mark: {Mark}\n" +
                              $"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}\n");
            Console.WriteLine($"PassengerType: {PassengerType}\n");
        }
    }
}
