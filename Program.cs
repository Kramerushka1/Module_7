using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.5.3
    /// </summary>    
    /// Создайте класс Helper и определите в нем статический метод Swap типа void, 
    /// который принимает 2 переменные типа int и меняет их значения местами.
    /// Иными словами, для вашего метода должен будет корректно выполняться следующий код:


    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1, ref num2);

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
        }
    }
    class Helper
    {
        public static void Swap(ref int num1, ref int num2)
        {
            (num1, num2) = (num2, num1);
        }
    }
}
