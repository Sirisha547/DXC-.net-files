namespace CelsiustoFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temp in Celsius:");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = ((Celsius * 9) / 5) + 32;
            Console.WriteLine(Fahrenheit);
        }
    }
}