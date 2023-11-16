namespace Module_7
{
    /// <summary>
    /// Задание 7.2.14
    /// </summary>
    /// Для следующего класса напишите индексатор, 
    /// для типа параметра используйте int:

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }
}
