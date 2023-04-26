using MyLibrary;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value:");
            int a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("enter the value:");
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Choice");
            int c = Convert.ToInt16(Console.ReadLine());
            Calculator calc = new Calculator();
            switch (c)
            {
                case 1:
                    Console.WriteLine(calc.Sum(a,b));
                    break;
                case 2:
                    Console.WriteLine(calc.Subract(a,b));
                    break;
                case 3:
                    Console.WriteLine(calc.Multiply(a,b));
                    break;
                case 4:
                    Console.WriteLine(calc.Divide(a,b));
                    break;

            }
            Console.ReadKey();
        }
    }
}