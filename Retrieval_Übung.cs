using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Retrieval_Übung
    {
        static void Main(string[] args)
        {
            /*Pseudecode:
             * Array gefundeneEier[] mit Zahlen gegeben
             * int Variable Größte erstellen
             * int Größte = 0;
             * for-Schleife: gefundeneEier[] durchgehen
             * i = beginne bei 0, zähle durch jeden platz im array
             * WENN: gefundeneEier[i] größer als Größte 
             * DANN: Größte = gefundeneEier[i]
             * Ausgabe() Gewinner hat (Größte) Eier gefunden.*/

            int[] gefundeneEier = new int[] {2,4,6,8,10,12,14,16,18,20};
            int Größte = 0; 
            for(int i = 0; i < gefundeneEier.Length; i++)
            {
                if(gefundeneEier[i] > Größte)
                    Größte = gefundeneEier[i];

            }
            Console.WriteLine($"Der Gewinner hat {Größte} Eier gefunden");
        }
    }
}
