using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1._2_Rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int row = 0; row < 39; row++) // Skriver ut 39 rader/gör detta 39 gånger
            {
                // Switch-satsen byter färger beroende på vilken rad det är
                switch (row % 3)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;  // Färgar var tredje rad gul
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta; // Färgar var tredje rad magenta
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;  // Färgar övriga rader gröna
                        break;
                }

                for (int col = 0; col < 25; col++) // Skriver ut 25 kolumner/gör detta 25 gånger
                {
                    string printOut = "* ";
                    if (row % 2 == 0)
                    {
                        Console.Write("{0} ", printOut); // Skriv ut "" + "* "
                    }
                    else
                    {
                        Console.Write(" {0}", printOut); // Högerjustera varannan rad 

                    }
                }
                Console.WriteLine(); //Byter rad
            }
        }
    }
}
