using System.Data;

namespace Inheritance
{
    class ArithmeticOperators
    {
        public ArithmeticOperators()
        {
            Console.WriteLine("This is ArithmeticOperators constructor inside super class ");
        }
            
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a,int b)
        {
            return a * b;
        }
        public int Divide(int a,int b)
        {
            return a / b;
        }
    }
    class LogicalOperators : ArithmeticOperators
    {
        public LogicalOperators()
        {
            Console.WriteLine("This is LogicalOperators constructor inside derived class ");
        }
        public bool LogicalAnd(bool a, bool b)
        {
          if (a && b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LogicalOr(bool a, bool b)
        {
            if (a || b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
    class ComparisonOperators : LogicalOperators
    {
        public ComparisonOperators()
        {
            Console.WriteLine("This is ComparisonOperators constructor inside derived class ");
        }
        public void Equal(int a,int b)
        {
            if (a == b)
            {
                Console.WriteLine("a equals b");
            }
        }
        public void Greater(int a, int b)
        {
            if(a>b)
            {
                Console.WriteLine("a is greater than b");
            }
            else
            {
                Console.WriteLine("b is greater");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparisonOperators CO = new ComparisonOperators();
        }
    }
}