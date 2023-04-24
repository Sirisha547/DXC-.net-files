// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Runtime.CompilerServices;

Console.WriteLine("SINO\tCelsius\t\t\tFahrenheit ");
for (int i = 0, C = 0; C <= 100; i++, C = C + 10)
{
    double Fahrenheit = ((C * 9) / 5) + 32;
    Console.WriteLine($"{i}\t\t\t{C}\t\t\t{Fahrenheit}");
}
