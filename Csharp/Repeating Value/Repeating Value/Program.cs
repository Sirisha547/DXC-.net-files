using System.Globalization;
using System.Net.Http.Headers;

namespace Repeating_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int[] j = new int[max + 1];
            for (int i = 0; i <= max; i++)
            {
                j[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                j[arr[i]]++;
            }
            int k = 0;
            for (int i = 0; i <= max; i++)
            {
                if (j[i] > k)
                {
                    k = j[i];
                }
            }
            Console.WriteLine("Elements that occur most frequently:");
            for (int i = 0; i <= max; i++)
            {
                if (j[i] == k)
                {
                    Console.WriteLine(i);




                }
            }

        }
    }
}