using System;
namespace Uppgift_5._1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            string antal = Console.ReadLine();
            int xheltal = int.Parse(antal);
            string[] x = new string[xheltal];
            for(int i = 0; i < xheltal; i++)
            {
                Console.WriteLine("Skriv in ett hel tal");
                x[i] = Console.ReadLine();
            }
            int counter = 0;
            for (int i = 0;i < xheltal; i++)
            {
                counter++;
                Console.WriteLine($"Tal {counter} | {x[i]}");
            }
            Console.ReadKey();
        }
    }
}