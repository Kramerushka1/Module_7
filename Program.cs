namespace Module_7
{
    /// <summary>
    /// Задание 7.3.3
    /// </summary>
    /// Создайте классы для следующих объектов компьютера: 
    ///     процессор (Processor), 
    ///     материнская карта (MotherBoard), 
    ///     видеокарта (GraphicCard). 
    /// Унаследуйте их от класса ComputerPart.
    /// Добавьте в класс ComputerPart абстрактный метод Work без параметров и с типом void.



    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    
    abstract class ComputerPart
    {
        public abstract void Work ();
    }
    class Processor : ComputerPart
    {
        public abstract void Work() { }
    }
    class MotherBoard : ComputerPart
    {
        public abstract void Work() { }
    }
    class GraphicCard : ComputerPart
    {
        public abstract void Work() { }
    }
}
