using System;

namespace Task12
{
    class Program
    {
        static void Main()
        {
            // Написать функцию нахождения максимального из трёх чисел.
            // Константин Суворов. Санкт-Петербург.

            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите тертье число: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double result = MaximumOfThreeDigits(a, b, c);

            Console.WriteLine($"Максимальным из трёх введённых Вами чисел - является: {result}.");
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
        }

        static double MaximumOfThreeDigits (double firstDigit, double secondDigit, double thirdDigit)
        {
            double max = firstDigit;

            if (secondDigit > firstDigit && secondDigit > thirdDigit)
            {
                max = secondDigit;
                return max;
            }
            else if (thirdDigit > firstDigit && thirdDigit > secondDigit)
            {
                max = thirdDigit;
                return max;
            }
            else
                return max;
        }
    }
}
