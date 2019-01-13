using System;

namespace Task14
{
    class Program
    {
        static void Main()
        {
            // * Автоморфные числа.  Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. Например, 25^2 = 625.
            // Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.
            // Константин Суворов. Санкт-Петербург.

            Console.Write("Введите натуральное число N: ");
            int naturalNumber = Convert.ToInt32(Console.ReadLine()); // число по которое выводятся автоморфные числа
            int exponent = 2; // показатель степени
            for (int i = 2; i <= naturalNumber; i++)
            {
                double resultPower = Power(i, exponent);
                int resultNumberOfDigits = NumberOfDigits(i);
                long resultSeparator = Separator(resultPower, resultNumberOfDigits);
                long resultReverse = Reverse(resultSeparator);
                if ( i == resultReverse)
                    Console.WriteLine($"Число {i} является автоморфным так как оно равно последним цифрам своего квадрата {resultPower}.");
            }
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }

        static double Power (int a, int b) // Метод возведения в степень
        {
            double p = 1;
            double indetermination = 0;

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Ноль в степени ноль - это математическая неопределённость.\n Основание и показатель степени должны быть целыми числами.");
                return indetermination;
            }

            else if (a > 0 && b == 0)
                return p;

            else if (a < 0 && b == 0)
                return p;

            else if (a > 0 && b > 0)
            {
                while (b != 0)
                {
                    p *= a;
                    b--;
                }
                return p;
            }

            else if (a > 0 && b < 0)
            {
                while (b != 0)
                {
                    p = p * 1 / a;
                    b++;
                }
                return p;
            }
            else
                return indetermination;
        }

        static int NumberOfDigits(double N) // Метод подсчёта количества знаков в возводимом в квадрат числе
        {
            int n = Convert.ToInt32(N);
            int counter = 0;
            int residual = 0;

            while (n != 0)
            {
                residual = n / 10;
                n = residual;
                counter++;
            }
            return counter;
            
        }

        static long Separator (double Power, int NumberOfDigits) // Метод отделения с конца возведённого в квадарт числа того кол-ва знаков, которое вернул метод NumberOfDigits()
        {
            long n = Convert.ToInt64(Power);
            long result = 0;

            while (NumberOfDigits != 0)
            {
                result = result * 10 + n % 10;
                n /= 10;
                NumberOfDigits--;
            }
            return result;
        }

        static long Reverse (long N) // Метод переворачивающий число, получившееся в методе Separator()
        {
            long result = 0;

            while (N != 0)
            {
                result = result * 10 + N % 10;
                N /= 10;
            }
            return result;
        }
    }
}
