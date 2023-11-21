using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.6.9
    /// </summary>   
    /// Установите ограничения на универсальные типы в классе Car. 
    /// Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine, 
    /// а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).
    /// Для этого вам может понадобиться использовать один из ранее изученных принципов ООП.
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Car<T1> where T1 : Engine
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart { }
    }
    class ElectricEngine : Engine { }
    class GasEngine : Engine { } 
    class Battery : CarPart{ }
    class Differential : CarPart { }
    class Wheel : CarPart { }
    class Engine { }
    class CarPart { }
}
