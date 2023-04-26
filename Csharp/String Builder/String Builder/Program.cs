namespace String_Builder
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Gud mrng ");
            //sb.Append("Good Morning");
            //sb.Insert(11, "All");
            sb.Append("My name Sirisha");
            sb.Insert(17, "is ");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
        }
    }
}