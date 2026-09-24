using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Einstieg1.OOP
{
    internal class Würfelspiel
    {
        static void Main(string[] args)
        {
            /* Aufgabe
             * Schreiben Sie ein Programm für ein einfaches Würfelspiel. Jeder Spieler wirft seinen Würfel 
                fünf Mal. Die gewürfelten Zahlen werden aufsummiert und der Spieler mit der höchsten 
                Summe gewinnt. Definieren Sie dazu die Klasse Player mit einem Attribut score zur 
                Darstellung des Punktestandes und ein Attribut name für den Namen des Spielers. Überlegen 
                Sie sich geeignete Konstruktoren. Außerdem soll die Klasse die folgenden Methoden haben:

            
                Gamble() „wirft“ einen Würfel fünf Mal, gibt jede gewürfelte Zahl (eine Zufallszahl) 
                aus und bildet die Summe der Zahlen. Die Methode hat keinen Übergabeparameter 
                und keinen Rückgabewert.
            
                GetScore() liefert den Punktestand eines Spielers zurück. Die Methode hat keinen 
                Übergabeparameter.*/

            /*Innerhalb von Main() sollen zwei Objekte der Klasse Player angelegt werden. Generieren Sie
            für beide Spieler zwei sinnvolle Namen. Nachdem die Methode Gamble() für beide Spieler
            aufgerufen wurde, werden die Punktestände verglichen um den Gewinner zu ermitteln.Der
            Name des Gewinners wird anschließend ausgegeben.*/

            /*Klassendiagramm:
             * ----------------
             * Player:
             * ----------------
             * + Name:        string
             * + Punktestand: int 
             * ----------------
             * + Gamble(): void 
             * + GetScor(): int */

            Player Player1 = new Player();
            Player1.Name = "King";
            Player1.Gamble();
            Console.WriteLine($"Player {Player1.Name} hat {Player1.GetScore()} Punkte ");

            Console.WriteLine();

            Player Player2 = new Player();
            Player2.Name = "Smith";
            Player2.Gamble();
            Console.WriteLine($"Player {Player2.Name} hat {Player2.GetScore()} Punkte ");

            Console.WriteLine();

            if(Player1.Punktestand > Player2.Punktestand)
            {
                Console.WriteLine($"{Player1.Name} ist mit {Player1.Punktestand} Punkten der Gewinner");
            }
            else
                Console.WriteLine($"{Player2.Name} ist mit {Player2.Punktestand} Punkten der Gewinner");
        }
    }
    class Player
    {
        public string Name;
        public int Punktestand = 0;
        Random Zufallszahl = new Random();

        public void Gamble()
        {            
            int[] Würfe = new int[5];
            int gamble = 0;
            for (int i = 0; i < Würfe.Length; i++)
            {
                Würfe[i] = Zufallszahl.Next(1, 7);
                Console.Write(Würfe[i] + " ");
                gamble += Würfe[i];
            }            

            Punktestand = gamble;
        }

        public int GetScore()
        {
            return Punktestand;
        }

    }

}
