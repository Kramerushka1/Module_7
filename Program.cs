namespace Module_7
{
    /// <summary>
    /// Задание 7.1.6
    /// </summary>
    /// Реализуйте конструктор, заполняющий поля для следующего класса:

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }

}