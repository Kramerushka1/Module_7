﻿using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.5.9
    /// </summary>    
    /// Для класса int создайте 2 метода расширения: GetNegative() и GetPositive().
    /// Метод GetNegative должен возвращать отрицательное значение переменной(если оно положительно), либо саму переменную(если оно отрицательно или равно 0).
    /// Метод GetPositive должен, наоборот, возвращать положительное значение(если оно отрицательно), либо саму переменную(если оно положительно или равно 0).
    /// Иными словами, для вашего метода должен будет корректно выполняться следующий код:




    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0

        }
    }
    static class IntExtensions
    {
        public static int GetNegative(this int value)
        {
            if (value <= 0)
            {
                return value;
            }
            else
            {
                return 0 - value;
            }
        }
        public static int GetPositive(this int value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                return 0 - value;
            }
        }
    }
}
