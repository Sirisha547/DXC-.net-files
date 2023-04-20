namespace SI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P;
            double T, R;
            Console.WriteLine("Enter Principle Amount:");
            P = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Time:");
            T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate of interest:");
            R = Convert.ToDouble(Console.ReadLine());
            double SI = (P * T * R) / 100;
            Console.WriteLine(SI);
        }
    }
}