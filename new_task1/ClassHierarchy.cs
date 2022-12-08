using System;

/*
 * Использовал статью https://habr.com/ru/sandbox/152884/ в качестве примера
 */

namespace new_task1
{
    public abstract class Transport //базовый класс для всех остальных, не предполагаю, что он будет создан сам по себе
    {
        public string Color;
        public int Year;
        public int Weight;

        protected Transport() //Констурктор при неизвестных входных данных
        {
            Color = "Unknown";
            Year = 0;
            Weight = 0;
        }

        protected Transport(string color, int year, int weight) //Конструктор с известными входными данными
        {
            Color = color;
            Year = year;
            Weight = weight;
        }
        public abstract void Information(); //Метод вывода на экран информация, дополнительно переопределю ToString()
    }

    class Train : Transport //Поезд, наследую от транспорта
    {
        public int Сarriages; //Количество вагонов состава
        public Train(string color, int year, int weight, int carriages) : base(color, year, weight) //Конструктор
        {
            Сarriages = carriages;
        }

        public override void Information() //Переопределяю метод
        {
            Console.WriteLine("Train");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Weight: {Weight}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Сarriages: {Сarriages}\n");
        }

        public override string ToString() //Переопределил метод ToString()
        {
            return $"Type : Train, color : {Color}, year : {Year}, weight : {Weight}, carriages : {Сarriages}";
        }
    }

    class Car : Transport //Автомобиль, наследую от транспорта
    {
        public string Mark; //Маорка автомобиль
        public Car(string color, int year, int weight, string mark) : base(color, year, weight) //Констурктор
        {
            Mark = mark;
        }

        public override void Information()
        {
            Console.WriteLine("Car");
            Console.WriteLine($"Year: {Year}\n" +
                              $"Weight: {Weight}\n" +
                              $"Color: {Color}");
            Console.WriteLine($"Mark: {Mark}\n");
        }

        public override string ToString() //Переопределил метод ToString()
        {
            return $"Type : Car, color : {Color}, year : {Year}, weight : {Weight}, mark : {Mark}";
        }
    }

    class Truck : Car //Грузовик, наследую от автомаобиля
    { 
        public int LoadCapacity; //Загрузка грузовика
        public Truck(string color, int year, int weight, string mark, int loadCapacity) : base(color, year, weight, mark) //Конструктор
        {
            LoadCapacity = loadCapacity;
        }

        public override void Information() //Переопределяю метод
        {
            Console.WriteLine("Truck Car");
            Console.WriteLine($"Mark: {Mark}\n"+
                              $"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}\n");
            Console.WriteLine($"LoadCapacity: {LoadCapacity}\n");
        }

        public override string ToString() //Переопределил метод ToString()
        {
            return $"Type : Car, Subtype : Truck, color : {Color}, year : {Year}, weight : {Weight}, load capacity : {LoadCapacity}";
        }
    }

    class Passenger : Car //Легковой автомобиль
    {
        public string PassengerType; //Тип лекгового автомобиля
        public Passenger(string color, int year, int weight, string mark, string passengerType) : base(color, year, weight, mark) //Конструктор
        {
            PassengerType = passengerType;
        }

        public override void Information() //Переопределяю метод
        {
            Console.WriteLine("Passenger Car"); 
            Console.WriteLine($"Mark: {Mark}\n" +
                              $"Year: {base.Year}\n" +
                              $"Weight: {base.Weight}\n" +
                              $"Color: {base.Color}\n");
            Console.WriteLine($"PassengerType: {PassengerType}\n");
        }

        public override string ToString() //Переопределил метод ToString()
        {
            return $"Type : Car, Subtype : Passenger Car, color : {Color}, year : {Year}, weight : {Weight}, passenger type : {PassengerType}";
        }
    }
}
