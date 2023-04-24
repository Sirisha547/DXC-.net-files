namespace Largestnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, 4, 5, 6, 8, 2, 3, 1 };
            int largest = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                    largest = arr[i];
            }
            Console.WriteLine($"Largest number is {largest}");
        }
    }
}