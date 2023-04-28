using System.Collections;

namespace SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(4, "training");
            s.Add(1, "Welcome");
            s.Add(3, "Dotnet");
            s.Add(2, "to");
            s.Add(5, "sessions");

            Console.WriteLine(s[3]);
            Console.WriteLine(s.GetKey(1));

            foreach (var item in s.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {s[item]}");
            }
        }
    }
}