using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hauptzahlen = new int[20]; // Array
            int temp = 0;
            Boolean Check = false;

            Random Zufallszahl = new Random(); // Zufallszahl-Generator

            for(int i = 0; i <= 19;) // Schleife zum 20 random Zahlen ausgeben
            {
                temp = Zufallszahl.Next(1, 21); // Temp wird mit Zufallszahl befüllt

                for(int y = 0; y <= 19; y++)
                {
                    if(temp == hauptzahlen[y])
                    {
                        Check = false;
                        y = 20;
                    }
                    else
                    {
                        Check = true;
                    }
                }

                if(Check == true)
                {
                    hauptzahlen[i] = temp;
                    i++;
                    Check = false;
                }

            }

            for(int i = 0; i <= 19; i++)
            {
                Console.Write(hauptzahlen[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
