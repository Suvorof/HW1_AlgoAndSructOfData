using System;

namespace Task13
{
    class Program
    {
        static void Main()
        {
            // Написать функцию, генерирующую случайное число от 1 до 100.
            // - с использованием стандартной функции rand()
            // - без использования стандартной функции rand()
            // Константин Суворов. Санкт-Петербург.

            //Console.WriteLine(GenerateDigit());
            //Console.ReadKey();

            string result = AlternativeGenerateDigit();
            Console.WriteLine($"{result}");
            Console.ReadKey();
        }

        static int GenerateDigit()
        {
            Random rnd = new Random();
            return rnd.Next(100);
        }

        static string AlternativeGenerateDigit()
        {
            int m, b, a, x;
            int[] nums = new int[100];
            string str = null;
            m = 100; // Вершина последовательности
            b = 3;
            a = 2;
            x = 1;
            int i;
            int modulus = 100;

            for (i = 0; i < modulus; i++)
            {
                x = (a * x + b) % m;
                nums[i] = x;
                str += $"{Convert.ToString(nums[i])} ";
            }

            return str;
        }
    }
}
