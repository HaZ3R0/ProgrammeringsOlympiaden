using System;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift2_Tre_i_rad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");

            string talttext = Console.ReadLine();
            int tal = int.Parse(talttext);
            int svar = 0;

            for (int i = 1; i <= tal; i++)
            {
                int treigtal = (i * (i + 1) * (i + 2));
                int sum = (svar + treigtal);
                string sumtext = sum.ToString();
                string sumtext2 = (sumtext + " ");
                while (treigtal <= tal)
                {
                    Console.Write(sumtext2);
                    Console.WriteLine("Du får räkna själv hur många tal det är så funkar det");
                    break;
                }
            }
        }
    }
}