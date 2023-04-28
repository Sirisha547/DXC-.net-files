namespace OverrideDemo
{
    class C1
    {
        public virtual void Display()
        {
            Console.WriteLine("This is Display Method inside class C1");
        }
    }
    class C2 : C1
    {
        public override void Display()
        {
            Console.WriteLine("This is Display Method inside class C2");
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            C1 c2 = new C2();
            c2.Display();
        }
    }
}