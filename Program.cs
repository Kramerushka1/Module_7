using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.6.12
    /// </summary>   
    /// С учётом полученных знаний по наследованию обобщений, дополните схему классов автомобиля, 
    /// добавив классы для электромобиля и бензинового — ElectricCar и GasCar.
    /// Подумайте, какой класс или классы можно сделать абстрактными.
    /// Сделайте абстрактными их и их члены(по возможности).
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart { }
    }
    class ElectricCar : Car<ElectricEngine> 
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { } 
    class Battery : CarPart{ }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    class Engine { }
    class CarPart { }
}
