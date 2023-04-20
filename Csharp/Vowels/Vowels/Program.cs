using System.ComponentModel.Design;

namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char vowel = Convert.ToChar(Console.ReadLine());
            if (vowel == 'A' || vowel == 'E' || vowel == 'I' || vowel == 'O' || vowel == 'U' || vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u') 
            {
                Console.WriteLine("Character is Vowel");
            }
            else
            {
                Console.WriteLine("It's a Consonant");
            }
        }
    }
}