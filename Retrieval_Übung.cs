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

            /*int[] gefundeneEier = new int[] {2,4,6,8,10,12,14,16,18,20};
            int Größte = 0; 
            for(int i = 0; i < gefundeneEier.Length; i++)
            {
                if(gefundeneEier[i] > Größte)
                    Größte = gefundeneEier[i];

            }
            Console.WriteLine($"Der Gewinner hat {Größte} Eier gefunden");

            ----------------------------------------------------------------*/

            /* Lies eine Zahl ein und prüfe, ob sie eine Primzahl ist.
             * Eine Primzahl ist nur durch 1 und sich selbst teilbar. Gib aus, ob die Zahl prim ist oder nicht.*/

            /* bool läuft = true;
             while (läuft)
             {
                 Console.WriteLine();
                 Console.WriteLine("Gib eine zahl ein");
                 int zahl = int.Parse(Console.ReadLine());
                 bool primzahl = true;
                 for (int i = 2; i < zahl; i++)
                 {
                     if (zahl % i == 0)             // geht dieser Teiler auf?
                     {
                         primzahl = false;          // dann ist es KEINE Primzahl
                         break;                     // einer reicht, Schleife stoppen
                     }
                 }
                 // NACH der Schleife das Urteil:
                 if (primzahl)
                     Console.WriteLine("Primzahl");



                 else
                     Console.WriteLine("keine Primzahl");
             }
            ------------------------------------------------------------------------*/

            /*int[] spieler = new int[] { 9, 8, 10, 12, 14, 16, 17, 17, 17, 15};
            bool gültig = true;
            int x = 18;
            for (int i = 0; i < spieler.Length; i++)
            {
                if (spieler[i] >= x)
                {
                    gültig = false;
                    break;
                }

            }
            if (gültig)
            {
                Console.WriteLine("Alle Spieler sind unter 18");
            }
            else
            {
                Console.WriteLine("Es gibt Spieler die 18 oder älter sind");*/
            int alter = 20;
            string Gruppe = alter >= 18 ? "Erwachsen" : "Minderjährig";
            Console.WriteLine(Gruppe);

        }






















    
        
    }
}
