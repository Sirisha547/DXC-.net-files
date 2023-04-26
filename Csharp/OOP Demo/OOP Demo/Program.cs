namespace OOP_Demo
{
    class Calculator
    {
        public void Show()
        {
            Console.WriteLine("This is show Method");
        }
        public void Name()
        {
            Console.WriteLine("This is Sirisha");
        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public int Cube(int x)
        {
            return x * x * x;
        }
        public int Multiply(int c, int d, int e =5)
        {
            return c * d * e;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Show();
            cal.Name();
            cal.Add(11, 47);
            int res = cal.Cube(5);
            Console.WriteLine(res);
            int m = cal.Multiply(1, 2);
            Console.WriteLine(m);
        }
    }
}