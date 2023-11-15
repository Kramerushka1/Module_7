namespace Module_7
{
    /// <summary>
    /// Задание 7.1.5
    /// </summary>
    /// Для следующего списка объектов создайте схему классов (объявите нужные классы и установите связи между ними):
    ///     Apple(яблоко);
    ///     Banana(банан);
    ///     Pear(груша);
    ///     Potato(картофель);
    ///     Carrot(морковь).

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Food { }
    class Fruit : Food { }
    class Vegetable : Food { }
    class Apple : Fruit { }
    class Banana : Fruit { }
    class Pear : Fruit { }
    class Potato : Vegetable { }
    class Carrot : Vegetable { }
}