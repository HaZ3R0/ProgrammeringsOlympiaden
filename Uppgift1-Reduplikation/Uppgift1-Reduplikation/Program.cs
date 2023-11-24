using System;
namespace Uppgift1Reduplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ordet?");
            string ord = Console.ReadLine();
            Console.WriteLine("antal upprepningar?");
            string antaltext = Console.ReadLine();
            int antal = int.Parse(antaltext);

            if (antal > 9)
            {
                Console.WriteLine("Du kan max skriva ordet 9 gånger");
            }

            else if (ord.Length > 9)
            {
                Console.WriteLine("Ordet får inte ha mer än 9 bokstäver");
            }
            else
            for (int i = 0; i < antal; i++)
            {
                Console.Write(ord);
            }
        Console.ReadKey();
        }
    }
}