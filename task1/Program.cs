using System;

namespace task1
{
    class Program
    {
        public static int Main(string[] args)
        {
            int value1 = -1; //Первое значение
            int value2 = -1; //Второе значение
            bool isValidA = false, isValidB = false; //Переменные получения данных из консоли
            int summaIntervala = 0; //Сумма значений
            int countValue = 0; //Количество занчений
            double meanValue; //Среднее значение

            if (args.Length == 1) //Если внесено только 1 значени
            {
                isValidA = Int32.TryParse(args[0], out value1);
            }

            if (args.Length == 2) //Если внесено 2 значения
            {
                isValidA = Int32.TryParse(args[0], out value1);
                isValidB = Int32.TryParse(args[1], out value2);
            }

            Console.WriteLine("Расчёт среднего значения в промежутке a-b");
            if (isValidA & isValidB) //Если оба значения из консоли
            {
                Console.WriteLine("Значения a, b - получены из консоли");
            }
            else if (isValidA) //Если только 1 значение из консоли
            {
                Console.WriteLine("Значение a - получено из консоли, введите значение b");
                isValidB = Int32.TryParse(Console.ReadLine(), out value2);
                while (!isValidB) //Цикл проверки валидности значения
                {
                    Console.WriteLine("Некорректное значение b, повторите ввод");
                    isValidB = Int32.TryParse(Console.ReadLine(), out value2);
                }
            }
            else //Если значений из консоли не получено
            {
                Console.WriteLine("Введите значения a и b");
                isValidA = Int32.TryParse(Console.ReadLine(), out value1);
                while (!isValidA) //Цикл проверки валидности значения
                {
                    Console.WriteLine("Некорректное значение a, повторите ввод");
                    isValidA = Int32.TryParse(Console.ReadLine(), out value1);
                }
                isValidB = Int32.TryParse(Console.ReadLine(), out value2);
                while (!isValidB) //Цикл проверки валидности значения
                {
                    Console.WriteLine("Некорректное значение b, повторите ввод");
                    isValidB = Int32.TryParse(Console.ReadLine(), out value2);
                }

            }

            for (int i = Math.Min(value1, value2); i <= Math.Max(value1, value2); i++) //Цикл расчёта суммы и количества значений
            {
                summaIntervala += i;
                countValue++;
            }

            meanValue = (1.0 * summaIntervala) / countValue; //Расчёт итогового значения

            Console.WriteLine($"Среднее значение элементов в интервале {value1}-{value2} = {meanValue}"); //Результат пользователю
            Console.ReadKey();
            return 1; //Значение функции (отладка для работы с консолью)
        }
    }
}
