namespace Module_7
{
    /// <summary>
    /// Задание 7.2.4
    /// </summary>
    /// Измените свойство Counter так, чтобы его можно было переопределить в классе DerivedClass. 
    /// Переопределите данное свойство, ограничив занесения в него чисел меньше 0.

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
        private int counter;
        public override int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Pанесения в него чисел меньше 0 невозможно");
                }
                else
                {
                    counter = value;
                }
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
