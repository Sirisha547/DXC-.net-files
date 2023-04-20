namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double Perimeter = 2 * (num1 + num2);
            Console.WriteLine(Perimeter);

        }
    }
}