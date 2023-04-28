using System.Data;
using System.Threading.Channels;

namespace Interface
{
    interface ImyInterface
    {
        void Sum(int a, int b);
        void Multiply(int a, int b);
    }
    class Demo
    {
        public void show()
        {
            Console.WriteLine("This is show Method");
        }
    }
    class C1 : Demo, ImyInterface
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            C1 c1 = new C1();
            c1.Sum(10, 20);
            c1.Multiply(10, 20);
            c1.show();
        }
    }
}