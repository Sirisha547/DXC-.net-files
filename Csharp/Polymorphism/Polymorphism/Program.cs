namespace Polymorphism
{
    class Exercise
    {
        public void Multiply(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Multiply(int a,int b,int c)
        {
            Console.WriteLine(a*b*c);

        }
        public void Multiply(float x, int y)
        {
            Console.WriteLine(x*y);
        }
        public void Multiply(int a, float b)
        {
            Console.WriteLine(a*b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercise e = new Exercise();
            e.Multiply(1,2);
            e.Multiply(3,4,5);
            e.Multiply(6.7f,8);
            e.Multiply(9,10.11f);

        }
    }
}