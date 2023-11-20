using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.5.5
    /// </summary>    
    /// Создайте класс Helper и определите в нем статический метод Swap типа void, 
    /// который принимает 2 переменные типа int и меняет их значения местами.
    /// Иными словами, для вашего метода должен будет корректно выполняться следующий код:


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Obj
    {
        public string Name;
        public string Description;

        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj ()
        {
            Parent = "System.Object";
            DaysInWeek = 7;
            MaxValue = 2000;
        }
    }
}
