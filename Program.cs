namespace Module_7
{
    /// <summary>
    /// Задание 7.2.12
    /// </summary>
    /// Для класса Obj перегрузите операторы + и -, 
    /// чтобы результатом работы оператора был новый экземпляр класса Obj, 
    /// а операции производились над полем Value.

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }
}
