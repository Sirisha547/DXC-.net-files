using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(47);
            list.Add("Welcome");
            list.Add(6.12f);
            list.Add(true);
            list.Add(false);

            Console.WriteLine($"count before inserting : {list.Count}");
            //Console.WriteLine(list.Count);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            list.Insert(3, "Sirisha");

            Console.WriteLine("inserted successfully");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"count after inserting : {list.Count}");

            //list.Clear();
            //Console.WriteLine(list.Count);
            Console.WriteLine(list[3]);

        }

    }
}