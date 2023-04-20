using System;
using System.ComponentModel.Design;

namespace StudentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  id");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter age");
            int age = Convert.ToInt16(Console.ReadLine());
            double marks1, marks2, marks3, total, avg, per;
            Console.WriteLine("Enter marks1");
            marks1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks2");
            marks2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter marks3");
            marks3 = Convert.ToDouble(Console.ReadLine());
            total = (marks1 + marks2 + marks3);
            avg = total / 3;
            per = (total / 300) * 100;
            Console.WriteLine("Total marks are " +  total);
            Console.WriteLine("Average is " + avg);
            Console.WriteLine("Percentage is " +  per);
            if (per > 50 )
            {
                Console.WriteLine("Result is PASS");
                if (per > 90)
                {
                    Console.WriteLine("A Grade");
                }
                else if (per > 80 && per < 89) 
                {
                    Console.WriteLine("B Grade");
                }
                else if (per > 60 && per < 79) 
                {
                    Console.WriteLine("C Grade");
                }
                else if (per > 50 && per < 59) 
                {
                    Console.WriteLine("D Grade");
                }

             
            }
            
            else
            {
                Console.WriteLine("Result is FAIL");
                Console.WriteLine("E Grade");
            }





        }
    }
}