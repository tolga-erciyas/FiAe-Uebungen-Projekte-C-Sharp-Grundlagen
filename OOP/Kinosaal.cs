using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Kinosaal
    {
        static void Main(string[] args)
        {
            /* Klassendiagramm:
             * 
             * Kinosaal:
             * 
             * - freie_plätze: int
             * - belegte_plätze: int 
             * - ticketpreis: double
             * - preiskategorie: int 
             * --------------
             * + Buchen_Beenden(): void
             * + Rückmeldung(): void
             * + freie_plätze_info(): void
             * + Ausgabe_Summe_Tickets(): void
             * --------------
             * 
             * Kunde
             * --------
             * Kino kino;*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Kino kino = new Kino();
            kino.Sitzplätze_Befüllen();

            //Assoziation
            Kunde kunde = new Kunde();
            kunde.kino = kino; //Das ist der Verweis, der dem Feld kino im Kunde-Objekt überhaupt erst ein konkretes Kino-Objekt zuweist,
            //damit Kunde auf die Methoden von Kino zugreifen kann 
            kunde.kino.Buchen_Beenden();

            //Vererbung
            Person Sano = new Person();
            Sano.Sitzplätze_Befüllen();
            Sano.Buchen_Beenden();
        }
        class Kino
        {
            int[,] preis = new int[6, 10];
            string[,] sitzplätze = new string[6, 10];
            bool[,] gebucht = new bool[6, 10];
            int freie_plätze;
            int belegte_plätze;
            double ticketpreis;
            int preiskategorie;

            public void Buchen_Beenden()
            {
                bool weiter = true;

                while (weiter)
                {
                    Console.WriteLine("1.Platz wählen - Tippe 1:\n2.Kategorie wählen - Tippe 2:\n3.Beenden Tippe 3:");
                    Console.WriteLine();
                    string menüwahl = Console.ReadLine();
                    switch (menüwahl)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int platz = 0; platz < 6; platz++)
                            {
                                for (int reihe = 0; reihe < 10; reihe++)
                                {
                                    Console.Write(sitzplätze[platz, reihe].ToString().PadLeft(4) + "    ");
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                                Console.ResetColor();

                                //Console.WriteLine("Platz eingeben (z.B. A1):");
                                //string eingabe = Console.ReadLine();
                                //char buchstabe = eingabe[0];
                                //int gewählteReihe = buchstabe - 'A';
                                //int gewählteSpalte = int.Parse(eingabe.Substring(1)) - 1;
                                //sitzplätze[gewählteReihe, gewählteSpalte] = 1;
                                //Console.WriteLine("Buchung erfolgreich!");
                                bool weitereBuchung = true;
                                while (weitereBuchung)
                            {
                                Console.WriteLine("Platz eingeben (z.B. A1):");
                                string eingabe = Console.ReadLine();
                                char buchstabe = eingabe[0];
                                int gewählteReihe = buchstabe - 'A';
                                int gewählteSpalte = int.Parse(eingabe.Substring(1)) - 1;
                                sitzplätze[gewählteReihe, gewählteSpalte] = "●";
                                gebucht[gewählteReihe, gewählteSpalte] = true;

                                Console.WriteLine("Weiteren Platz buchen?: (j/n)");
                                string antwort = Console.ReadLine();
                                weitereBuchung = (antwort == "j");
                            }

                            for (int platz = 0; platz < 6; platz++)
                            {
                                for (int reihe = 0; reihe < 10; reihe++)
                                {
                                    if (gebucht[platz, reihe])
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    else
                                        Console.ForegroundColor = ConsoleColor.Green;

                                    Console.Write(sitzplätze[platz, reihe].PadLeft(4) + "    ");
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            Console.ResetColor();
                            break;

                        case "2":
                            
                            Console.WriteLine("(Premium_Sitzplatz/Normaler_Sitzplatz: (p/n) ? )");
                            string eingabe1 = Console.ReadLine();

                            int gesuchterPreis = (eingabe1 == "p") ? 10 : 8;
                            //Das ist der ternäre Operator: Bedingung ? WertWennWahr : WertWennFalsch — eine kompakte if/else-Zuweisung in einer Zeile.
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int platz = 0; platz < 6; platz++)
                            {
                                for (int reihe = 0; reihe < 10; reihe++)
                                {
                                    if (preis[platz, reihe] == gesuchterPreis)
                                        Console.Write(sitzplätze[platz, reihe].PadLeft(4) + "    ");
                                    else
                                        Console.Write("    " + "    ");
                                }
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            Console.ResetColor();
                            break;

                        case "3":
                            weiter = false;
                            break;
                    }
                }
            }
            public void Sitzplätze_Befüllen()
            {
                for (int platz = 0; platz < 6; platz++)
                    for (int reihe = 0; reihe < 10; reihe++)
                    {
                        sitzplätze[platz, reihe] = "●";
                        preis[platz, reihe] = 8;
                    }
                        

                for (int reihe = 0; reihe < 10; reihe++)
                {
                    sitzplätze[4, reihe] = "●";
                    sitzplätze[5, reihe] = "●";
                    preis[4, reihe] = 10;
                    preis[5, reihe] = 10;
                }
            }
        }
        class Kunde
        {
            public Kino kino; // Assoziation -- Klasse Kunde hat ein Feld vom Typ Klasse Kino - Kunde kann darüber auf Kino zugreifen
        }
        class Person : Kino
        {

        }


    }
}
