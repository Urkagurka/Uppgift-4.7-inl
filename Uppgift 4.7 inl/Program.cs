using System;

namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en text");
            string text = Console.ReadLine();
            Console.WriteLine("Skriv in ett heltal");
            int rum = int.Parse(Console.ReadLine());
            for (int i = 0; i < text.Length; i++)
            {
                string bokstav = text[i].ToString();
                for (int j = 0; j < rum; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(bokstav);
            }
        }
    }
}