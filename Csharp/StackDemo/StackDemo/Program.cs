using System.Collections;

namespace StackDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack();
            a.Push(1);
            a.Push(2);
            a.Push(3);
            a.Push(4);

            

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(a.Contains(30));

            
            Console.WriteLine(a.Peek());//returns the top of the stack

            Console.WriteLine(a.Equals(1));

            //a.Pop();
            //Console.WriteLine("After Remove with Pop Method");

            //foreach (var item in a)
            //{
            // Console.WriteLine(item);
            //}
            //Console.WriteLine($"{s.Pop()} is popped out");
        } 
    }
}