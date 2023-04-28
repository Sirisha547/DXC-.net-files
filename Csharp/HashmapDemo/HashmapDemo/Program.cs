using System.Collections;

namespace HashmapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); // stores data in key value pairs
            ht.Add(4, "Sirisha");
            ht.Add(5, "Jayaa");
            ht.Add(1, "Appu");
            ht.Add(3, "Keerthana");
            ht.Add(2, "Lakshmi");

            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item);
            }


        }
    }
}