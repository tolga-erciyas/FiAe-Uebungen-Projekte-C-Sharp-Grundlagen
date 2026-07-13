using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Sparschwein
    {
        static void Main(string[] args)
        {
            /*Erstellen Sie zuerst ein Klassendiagramm für die Aufgabe!
            Definieren Sie eine Klasse PiggyBank zur Verwaltung der Münzen in einem Sparschwein.  
            Die Klasse besitzt folgende Attribute:
            • Jeweils einen Zähler für die vier Arten von Geldstücken(Anzahl 1 - Cent, 10 - Cent,
            50 - Cent und 1 - Euro Stücke).
            • Die maximale Anzahl Geldstücke, die in das Sparschwein passen.
            • Ein Flag, um anzuzeigen, dass das Sparschwein aufgebrochen wurde.
            Die Klasse PiggyBank hat folgende Methoden: 
            • Ein Konstruktor mit einem Argument für die maximale Anzahl von Münzen, die
            in das Sparschwein passen.
            • Add1Cents() „wirft“ eine übergebene Anzahl von 1 - Cent - Münzen in das
            Sparschwein und liefert den Return-Wert 0, falls alle Münzen in das Sparschwein
            passen.Wenn das Sparschwein überläuft, liefert die Methode die Anzahl der
            Münzen, die nicht mehr in das Sparschwein passen, als Rückgabewert zurück.
            • Add10Cents(), Add50Cents() und Add1Euros() analog zur Methode Add1Cents(). 
            • Shake() gibt aus wie voll das Sparschwein in etwa ist. Die Methode gibt folgende
            Information aus: Leer, etwa ein Drittel voll, etwa halb voll, etwa zwei Drittel voll, 
            Voll.
            • IsBroken() liefert true, wenn das Sparschein aufgebrochen ist, sonst false.
            • BreakInto() bricht das Sparschwein auf und liefert den angesparten Geldbetrag
            in Cents zurück. Die Zähler für die Geldstücke werden wieder auf 0 gesetzt.*/

            /* Klasse: Piggybank
             * -----------------------
             * Attribute:
             * - anzahl1cents:   int
             * - anzahl10cents:  int
             * - anzahl50cents:  int
             * - anzahl100cents: int
             * - MaximaleAnzahl: int
             * - istAufgebrochen: bool
             * ------------------------
             * Methoden:
             * + PiggyBank(maxMuenzen: int)
             * + Add1Cents(anzahl : int): int     
             * + Add10Cents(anzahl : int): int
             * + Add50Cents(anzahl : int): int
             * + Add100Cents(anzahl : int): int
             * + Shake():  string 
             * + isBroken(): bool
             * + BreakInto(): int */

            Piggybank p = new Piggybank(100);
            int übrig = p.Add100Cents(250);
            Console.WriteLine($"so viel Cents übrig {übrig}");

        }
        class Piggybank
        {
            private int anzahl1cents;
            private int anzahl10cents;
            private int anzahl50cents;
            private int anzahl100cents;
            private int maximaleAnzahl;
            private bool istaufgebrochen;
            
            public Piggybank(int maxMuenzen)
            {
                anzahl1cents = 0;
                anzahl10cents = 0;
                anzahl50cents = 0;
                anzahl100cents = 0;
                maximaleAnzahl = maxMuenzen;
                istaufgebrochen = false;
            }

            public int Add1Cents(int anzahl)
            {
                int inhalt = anzahl1cents + anzahl10cents + anzahl50cents + anzahl100cents;
                int freierplatz = maximaleAnzahl - inhalt;
                if (anzahl <= freierplatz) // 5 münzen platz(if anzahl <= 5 münzen)
                {
                    anzahl1cents = anzahl1cents + anzahl; // alles passt → alle rein
                    return 0;
                }
                else
                {
                    anzahl1cents = anzahl1cents + freierplatz; // nur so viele, wie Platz ist
                    return anzahl - freierplatz; // Rest kommt zurück
                }
                   

            }
            public int Add10Cents(int anzahl)
            {
                int inhalt = anzahl1cents + anzahl10cents + anzahl50cents + anzahl100cents;
                int freierplatz = maximaleAnzahl - inhalt;
                if (anzahl <= freierplatz) // 5 münzen platz(if anzahl <= 5 münzen)
                {
                    anzahl10cents = anzahl10cents + anzahl; // alles passt → alle rein
                    return 0;
                }
                else
                {
                    anzahl10cents = anzahl10cents + freierplatz; // nur so viele, wie Platz ist
                    return anzahl - freierplatz; // Rest kommt zurück
                }


            }
            public int Add50Cents(int anzahl)
            {
                int inhalt = anzahl1cents + anzahl10cents + anzahl50cents + anzahl100cents;
                int freierplatz = maximaleAnzahl - inhalt;
                if (anzahl <= freierplatz) // 5 münzen platz(if anzahl <= 5 münzen)
                {
                    anzahl50cents = anzahl50cents + anzahl; // alles passt → alle rein
                    return 0;
                }
                else
                {
                    anzahl50cents = anzahl50cents + freierplatz; // nur so viele, wie Platz ist
                    return anzahl - freierplatz; // Rest kommt zurück
                }


            }
            public int Add100Cents(int anzahl)
            {
                int inhalt = anzahl1cents + anzahl10cents + anzahl50cents + anzahl100cents;
                int freierplatz = maximaleAnzahl - inhalt;
                if (anzahl <= freierplatz) // 5 münzen platz(if anzahl <= 5 münzen)
                {
                    anzahl100cents = anzahl100cents + anzahl; // alles passt → alle rein
                    return 0;
                }
                else
                {
                    anzahl100cents = anzahl100cents + freierplatz; // nur so viele, wie Platz ist
                    return anzahl - freierplatz; // Rest kommt zurück
                }


            }

            public string Shake()
            {
                int inhalt = anzahl1cents + anzahl10cents + anzahl50cents + anzahl100cents;
                double prozent = (double)inhalt / maximaleAnzahl * 100;

                if (prozent >= 100)
                {
                    return ("Voll");
                }
                else if (prozent > 66)
                {
                    return("2/3 Voll");
                }
                else if (prozent > 33)
                {
                    return("Halb Voll");
                }
                else if (prozent > 0)
                {
                    return ("1/3 Voll");
                }
                else
                {
                    return("Leer");
                }
            }
            public bool isBroken()
            {
                if (istaufgebrochen)
                    return true;
                else
                    return false;
            }
            public int BreakInto()
            {   
                istaufgebrochen = true;
                int inhalt = //inhalt = x. Der Wert x liegt jetzt in inhalt.
                anzahl1cents * 1 + anzahl10cents * 10 + anzahl50cents * 50 + anzahl100cents * 100;

                anzahl1cents = 0;
                anzahl10cents = 0;
                anzahl50cents = 0;
                anzahl100cents = 0;
                //alle zähler auf 0 inhalt bleibt x 

                return inhalt; //gibt x zurück
                
            }



        }





    }
}
