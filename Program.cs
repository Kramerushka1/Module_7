using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.6.10
    /// </summary>   
    /// Переименуйте универсальные параметры в более читаемые, например, TEngine и TPart.
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart { }
    }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { } 
    class Battery : CarPart{ }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    class Engine { }
    class CarPart { }
}
