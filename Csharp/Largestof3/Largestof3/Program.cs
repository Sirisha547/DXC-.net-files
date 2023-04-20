namespace Largestof3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value a :");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value b :");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value c :");
            int c = Convert.ToInt16(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > c)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }




                    
            
                    
      
            

        }
    }
}