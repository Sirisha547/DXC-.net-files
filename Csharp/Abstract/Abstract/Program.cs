namespace Abstract
{
    abstract class C1
    {
        public abstract void Add(int x,int y);
        public abstract void Multiply(int x, int y);
    }
    class C2 :C1
    {
        public override void Add(int x, int y)
        {
            Console.WriteLine(x + y); ;
        }
        public override void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C2 p = new C2();
            p.Add(1, 2);
            p.Multiply(1, 2);

        }
    }
}