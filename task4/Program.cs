using System;
using System.Diagnostics;

namespace task4
{
    class GenerateElemenysClass
    {
        public string Name;
        public string Street;
        public string Number;
    }

    struct GenerateElemenysStruct
    {
        public string Name;
        public string Street;
        public string Number;
    }

    class Program
    {
        static int Main(string[] args)
        {
            long memorySizeStart, memorySizeTotalArray, memorySizeTotalClass, memorySizeTotalStruct; //Переменные хранения объема памяти
            Random randomCount = new Random(); //Рандомный выбор из диапазона
            int randomValue; //Значение рандомного выбора
            string nameAdress, nameStreet, nameNumber; //Адресат, Улица, Номер дома
            Stopwatch timeWatch = new Stopwatch(); //Рассчёт времени выполнения
            TimeSpan timeArray, timeClass, timeStruct; //Хранение времени


            Console.WriteLine("{0,-8} | {1,-10} {4,-20} | {2,-10} {4,-20} | {3,-10} {4,-20} |",  //Шапка табицы
                "Элементы", "Массив", "Класс", "Структура", ""); 
            Console.WriteLine("{0,-8} | {1,-10} {2,-20} | {1,-10} {2,-20} | {1,-10} {2,-20} |",
                    "", "Memory", "Time");

            for (int i = 1; i < 5; i++) //Головной цикл анализа
            {
                int startRandomInterval = 9 * Convert.ToInt32(Math.Pow(10, i)); //Начало интервала
                int endRandomInterval = 10 * Convert.ToInt32(Math.Pow(10, i)); //Конец интервала
                randomValue = randomCount.Next(startRandomInterval, endRandomInterval); //Рандомное значение из интервала
                memorySizeStart = GC.GetTotalMemory(true);
                timeWatch.Start();
                Array[] ArrayAdressBook = new Array[randomValue];
                for (int j = 0; j < randomValue; j++) //Цикл оценки массива
                {
                    nameAdress = "Name" + i;
                    nameStreet = "Street" + i;
                    nameNumber = "Number" + i;
                    ArrayAdressBook[j] = new string[] { nameAdress, nameStreet, nameNumber };
                }
                memorySizeTotalArray = GC.GetTotalMemory(true) - memorySizeStart;
                timeWatch.Stop();
                timeArray = timeWatch.Elapsed;

                GenerateElemenysClass[] ArrayAdressBookClass = new GenerateElemenysClass[randomValue];
                memorySizeStart = GC.GetTotalMemory(true);
                timeWatch.Start();
                for (int j = 0; j < randomValue; j++) //Цикл оценки класса
                {
                    nameAdress = "Name" + i;
                    nameStreet = "Street" + i;
                    nameNumber = "Number" + i;
                    GenerateElemenysClass note = new GenerateElemenysClass { Name = nameAdress, Street = nameStreet, Number = nameNumber };
                    ArrayAdressBookClass[j] = note;
                }
                memorySizeTotalClass = GC.GetTotalMemory(true) - memorySizeStart;
                timeWatch.Stop();
                timeClass = timeWatch.Elapsed;

                GenerateElemenysStruct[] ArrayAdressBookStruct = new GenerateElemenysStruct[randomValue];
                memorySizeStart = GC.GetTotalMemory(true);
                timeWatch.Start();
                for (int j = 0; j < randomValue; j++) //Цикл оценки структуры
                {
                    nameAdress = "Name" + i;
                    nameStreet = "Street" + i;
                    nameNumber = "Number" + i;
                    GenerateElemenysStruct note = new GenerateElemenysStruct { Name = nameAdress, Street = nameStreet, Number = nameNumber };
                    ArrayAdressBookStruct[j] = note;
                }
                memorySizeTotalStruct = GC.GetTotalMemory(true) - memorySizeStart;
                timeWatch.Stop();
                timeStruct = timeWatch.Elapsed;

                Console.WriteLine("{0,-8} | {1,-10} {2,-20} | {3,-10} {4,-20} | {5,-10} {6,-20} |",  //Вывод данных
                    randomValue, memorySizeTotalArray, timeArray,
                                 memorySizeTotalClass, timeClass,
                                 memorySizeTotalStruct, timeStruct);

            }

            return 0;
        }
    }
}
