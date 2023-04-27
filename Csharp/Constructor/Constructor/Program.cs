namespace Constructor
{
    class Demo
    {
        public  Demo()
        {
            Console.WriteLine("This is a Constructor");
        }
        public void show()
        {
            Console.WriteLine("This is a show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.show();

        }
    }
}