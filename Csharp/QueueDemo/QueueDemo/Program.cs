using System.Collections;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Queue z = new Queue();
                z.Enqueue(100);
                z.Enqueue(200);
                z.Enqueue(300);
                z.Enqueue(400);

                Console.WriteLine(z.Contains(4));
                foreach (var item in z)
                {
                    Console.WriteLine(item);
                }

                z.Dequeue();
                Console.WriteLine("After removing");
                foreach (var item in z)
                {
                    Console.WriteLine(item);
                }
            
        }
    }
}