namespace Largestof3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt16(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }

        }
    }
}