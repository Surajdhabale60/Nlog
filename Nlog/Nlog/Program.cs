using NlogProject;

namespace NLogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            AddNumber add = new AddNumber();
            Console.WriteLine("Result is : " + add.Sum(a,b));
        }
    }
}