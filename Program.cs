namespace Module_7
{
    /// <summary>
    /// Задание 7.1.4
    /// </summary>
    /// Для следующего класса Employee создайте 2 наследника: ProjectManager и Developer
    /// Класс ProjectManager должен содержать строковое поле ProjectName, 
    /// а класс Developer — строковое поле ProgrammingLanguage
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager : Employee
    {
        public string ProjectName;
    }
    class Developer : Employee
    {
        private string ProgrammingLanguage;
    }
}