using System;

namespace Task11
{
    class Program
    {
        static void Main()
        {
            // С клавиатуры вводятся числа, пока не будет введён 0. Подсчитать среднее арифметическое всех положительных чисел, оканчивающихся на 8.
            // Константин Суворов. Санкт-Петербург.

            double resultAverageAndEightDigit = AverageAndEightDigit();
            Console.WriteLine($"Среднее арифметическое среди чисел >0 и оканчивающихся на 8 - равно: {resultAverageAndEightDigit:0.##}.");
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }

        static double AverageAndEightDigit()
        {
            double result = 0;
            int counter = 0, N = 0;
            do
            {
                Console.WriteLine("Вводите числа. Чтобы закончить подсчёт введите 0: ");
                N = Convert.ToInt32(Console.ReadLine());

                if (N > 0 && N % 10 == 8)
                {
                    result = result + N;
                    counter++;
                }

            } while (N != 0);

            result = result / counter;
            return result;
        }
    }
}
