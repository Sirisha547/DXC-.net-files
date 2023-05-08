namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Sirisha","Jaya", "Sukanya", "Abhita", "Hema", "Kaviya", "Pravallika", "Ramya", "Tina", "Ziya" };

            //foreach (var item in names)
            //{
            //  Console.WriteLine(item);
            //}

            //var query = from s in names where s.StartsWith('S') select s;
            //var query = from s in names orderby s descending select s;
            //var query = from s in names orderby s ascending select s;
            //var query = from s in names where s.EndsWith('a') select s;
            //var query = from s in names where s.Length%2!=0 select s;
            var query = from s in names where s.Length%2==0 select s;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}