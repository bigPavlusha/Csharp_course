using System;

namespace task1
{
    class Program
    {
        public static int Main(string[] args)
        {
            int a = -1;
            int b = -1;
            bool isValidA = false, isValidB = false;
            int summaIntervala = 0;
            int countValue = 0;
            double meanValue;

            if (args.Length == 1)
            {
                isValidA = Int32.TryParse(args[0], out a);
            }

            if (args.Length == 2)
            {
                isValidA = Int32.TryParse(args[0], out a);
                isValidB = Int32.TryParse(args[1], out b);
            }

            Console.WriteLine("Расчёт среднего значения в промежутке a-b");
            if (isValidA & isValidB)
            {
                Console.WriteLine("Значения a, b - получены из консоли");
            }
            else if (isValidA)
            {
                Console.WriteLine("Значение a - получено из консоли, введите значение b");
                isValidB = Int32.TryParse(Console.ReadLine(), out b);
                while (!isValidB)
                {
                    Console.WriteLine("Некорректное значение b, повторите ввод");
                    isValidB = Int32.TryParse(Console.ReadLine(), out b);
                }
            }
            else 
            {
                Console.WriteLine("Введите значения a и b");
                isValidA = Int32.TryParse(Console.ReadLine(), out a);
                while (!isValidA)
                {
                    Console.WriteLine("Некорректное значение a, повторите ввод");
                    isValidA = Int32.TryParse(Console.ReadLine(), out a);
                }
                isValidB = Int32.TryParse(Console.ReadLine(), out b);
                while (!isValidB)
                {
                    Console.WriteLine("Некорректное значение b, повторите ввод");
                    isValidB = Int32.TryParse(Console.ReadLine(), out b);
                }

            }

            for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
            {
                summaIntervala += i;
                countValue++;
            }

            meanValue = (1.0 * summaIntervala) / countValue;

            Console.WriteLine($"Среднее значение элементов в интервале {a}-{b} = {meanValue}");
            Console.ReadKey();
            return 1;
        }
    }
}
