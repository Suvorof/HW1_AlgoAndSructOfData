using System;

namespace Task10
{
    class Program
    {
        static void Main()
        {
            // Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечётные цифры.
            // Если имеются, то вывести True, если нет - вывести False.
            // Константин Суворов. Санкт-Петербург.

            Console.Write("Пожалуйста введите целое число N > 0: ");
            int wholeNumber = Convert.ToInt32(Console.ReadLine());
            bool result = IsThereOddNumber(wholeNumber);
            Console.WriteLine($"{result}");
            Console.WriteLine("Для выхода нажмите любую клавишу.");
            Console.ReadKey();
            
        }

        static bool IsThereOddNumber(int N)
        {
            int residual = 0; // остаток
            int evenNumberCounter = 0; // счётчик чётных чисел
            int oddNumberCounter = 0; // счётчик нечётных чисел

            while(N != 0)
            {
                residual = N % 10;
                N /= 10;

                if (residual % 2 == 0)
                    evenNumberCounter++;
                else
                    oddNumberCounter++;
            }

            if (oddNumberCounter != 0)
                return true;
            else
                return false;
        }
    }
}
