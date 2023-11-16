namespace Module_7
{
    /// <summary>
    /// Задание 7.2.3
    /// </summary>
    /// Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров, 
    /// который будет выводить сообщение "Метод класса BaseClass" в консоль, 
    /// а затем переопределите его в DerivedClass, 
    /// чтобы он выводил сообщение "Метод класса DerivedClass".

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
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}