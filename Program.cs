namespace Module_7
{
    /// <summary>
    /// Задание 7.2.4
    /// </summary>
    /// Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass.
    /// Переопределите данное свойство, ограничив занесения в него чисел меньше 0.

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if (value >= 0)
                {
                    Counter = value;
                }
            }
        }
    }
        
}
