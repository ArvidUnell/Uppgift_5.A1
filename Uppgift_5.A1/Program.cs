using System;
namespace Uppgift_5_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = { "Hakuna matata.", "Missilen vet var den är under alla omständigheter","Jag är en astronaut" };

            foreach (string mening in meningar)
            {
                Console.WriteLine(mening + "\n");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}