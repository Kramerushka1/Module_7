using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.6.2
    /// </summary>    
    /// Создайте класс-обобщение Car для автомобиля. 
    /// Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый). 
    /// Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
    /// В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Car<T>
    {
        public T Engine;
    }
    class ElectricEngine
    {

    }
    class GasEngine
    {

    }
}
