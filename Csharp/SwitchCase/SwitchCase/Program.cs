namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operator");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case '+':
                    {
                        Console.WriteLine("Result is : " + (x + y));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Result is : " + (x - y));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("Result is : " + (x * y));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("Result is : " + (x / y));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine("Result is : " + (x % y));
                        break;
                    }
                default :
                    {
                        Console.WriteLine("Invalid Operator");
                        break;
                    }




            }
            
           

            

            

        }
    }
}