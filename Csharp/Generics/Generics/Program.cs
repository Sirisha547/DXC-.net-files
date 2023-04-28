namespace Generics
{
    class Demo<S>
    {
        S num;
        public void Set(S x)
        {
            num = x;
        }
        public S Get()
        {
            return num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo<int> d = new Demo<int>();
            d.Set(11);
            Console.WriteLine(d.Get());
        }
    }
}