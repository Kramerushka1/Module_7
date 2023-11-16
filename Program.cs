namespace Module_7
{
    /// <summary>
    /// Задание 7.2.5
    /// </summary>
    /// Вернитесь к заданию 7.2.3 и дополните его код так, 
    /// чтобы для вызова следующего следующего кода в консоль выводилось 2 сообщения 
    ///     сначала "Метод класса BaseClass", 
    ///     а затем "Метод класса DerivedClass" 



    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display(); 
            Console.WriteLine("Метод класса DerivedClass");
        }
    }

}
