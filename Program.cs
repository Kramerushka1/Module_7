using System.Threading.Channels;

namespace Module_7
{
    /// <summary>
    /// Задание 7.6.6
    /// </summary>    
    /// Реализуйте класс-обобщение Record, у которого будут два универсальных параметра: 
    ///     один — для идентификатора записи (Id), 
    ///     другой — для значения записи (Value). 
    /// Также в классе реализуйте поле Date типа DateTime.

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    /*
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
    */
    class Record <T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
}
