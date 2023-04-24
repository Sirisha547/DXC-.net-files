// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0, y;
while (x > 0)
{
    y = x % 10;
    sum = sum + y;
    x = x / 10;

}
Console.WriteLine("sum of digits is " + sum);

