using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Pseudocode
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            Aufgabe4();
        }

        static void Aufgabe1()
        {
            //Schreiben Sie einen Pseudocode, der das Einkommen
            //einer Person einliest.Wenn das Einkommen ≤ dem
            //Grundfreibetrag von 10.908 Euro ist, beträgt die Steuer 0
            //Euro.Andernfalls: auf den Betrag über dem Freibetrag
            //werden pauschal 14 % Steuern erhoben.Geben Sie die
            //berechnete Steuer aus.

            //Pseudocode:

            //Ausgabe: "Geben Sie Ihr Einkommen ein" 
            //int Einkommen = Int.Parse(Console.ReadLine));
            //double Steuer = 0;
            //double Freibetrag = 10908
            //Verzweigung: if (Einkommen >10908 Euro)
            //                 { Steuer = (Einkommen - Freibetrag) * 14 / 100;
            //                 Ausgabe: Der Steuerbetrag beträgt (Steuer)}
            //            else
            //              {Ausgabe: Der Steuerbetrag beträgt 0 Euro}


            Console.WriteLine("Geben Sie Ihr einkommen ein");
            int Einkommen = int.Parse(Console.ReadLine());
            double Steuer = 0;
            double Freibetrag = 10908;
            if (Einkommen > 10908)
            {
                Steuer = (Einkommen - Freibetrag) * 14 / 100;
                Console.WriteLine($"Der Steuerbetrag beträgt {Steuer}");
            }
            else
            {
                Console.WriteLine($"Der Steuerbetrag beträgt 0 Euro");
            }



        }

        static void Aufgabe2()
        {
            //Gegeben ist ein Array einkommenListe mit den
            //Einkommen von 5 Personen.Schreiben Sie Pseudocode,
            //der für jede Person die Steuer berechnet und in ein neues
            //Array steuerListe speichert.Regeln:
            //Bis 10.908 €: 0 %
            //Über 10.908 € bis 60.000 €: 14 % auf den Betrag über
            //10.908 €
            //Über 60.000 €: 14 % auf die Spanne bis 60.000 € plus
            //42 % auf den Betrag über 60.000 €.

            //Pseudocode:
            //Erstelle Array steuerliste mit 5 Elementen
            //for-schleife i von 0 bis array.Length 
            //    wiederhole -> einkommen = einkommenListe[i]
            //wenn einkommen <= 10908 dann
            //        steuer = 0
            //sonst wenn - einkommen <= 60000 dann
            //        steuer = (einkommen - 10908) * 0.14
            //sonst
            //        steuer = (60000 - 10908) * 0.14
            //                 + (einkommen - 60000) * 0.42
            //ende

            double[] einkommensliste = { 10000, 20000, 65000, 45000, 100000 };

            double[] steuerliste = new double[5];

            for (int i = 0; i < steuerliste.Length; i++)
            {
                double einkommen = einkommensliste[i];

                if (einkommen <= 10908)
                {
                    steuerliste[i] = 0;
                }
                else if (einkommen <= 60000)
                {
                    steuerliste[i] = (einkommen - 10908) * 14 / 100.0;
                }
                else
                {
                    steuerliste[i] = (60000 - 10908) * 14 / 100.0
                                   + (einkommen - 60000) * 42 / 100.0;
                }
            }

            for (int i = 0; i < steuerliste.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}: Einkommen = {einkommensliste[i]} - Steuer = {steuerliste[i]:F2}");
            }


        }

        static void Aufgabe3()
        {
            //Ein Sportverein gewährt Jugendlichen unter 18 Jahren
            //einen Rabatt von 50 % auf den Grundbeitrag.
            //Schreiben Sie einen Pseudocode, der das Alter und den
            //Grundbeitrag einliest.
            //Berechnen Sie den finalen Beitrag unter Berücksichtigung
            //des Rabatts und geben Sie diesen aus.

            //Pseudecode:
            //lese das alter ein
            //WENN: alter < 18 
            //lese den Grundbeitrag ein 
            //berechnen des finalen beitrags unter berücksichtigung  des rabatts
            //DANN: Grundbeitrag = Grundbeitrag - Grundbetrag / 2
            //Ausgabe: Berechneter Rabatt
            //SONST
            //Ausgabe: Kein Rabatt for you

            Console.WriteLine("Alter eingeben:");
            int alter = int.Parse(Console.ReadLine());


            if(alter < 18)
            {
                Console.WriteLine("Grundbeitrag angeben");
                int Grundbeitrag = int.Parse(Console.ReadLine());
                int Rabatt = Grundbeitrag - Grundbeitrag / 2;
                Console.WriteLine($"Der errchnete Rabatt beträgt {Rabatt}");
            }
            else
            {
                Console.WriteLine("Kein Rabatt for you");
            }
        }

        static void Aufgabe4()
        {
            //Für ein Jugendturnier muss eine Mannschaft aus 11
            //Spielern bestehen.
            //Gegeben ist ein Array alterSpieler mit dem Alter der 11
            //Spieler.
            //Schreiben Sie einen Pseudocode, der prüft, ob alle Spieler
            //unter 18 Jahre alt sind.
            //Wenn ja, geben Sie "Aufstellung gültig" aus.Wenn
            //mindestens ein Spieler 18 oder älter ist, geben Sie
            //"Aufstellung ungültig" aus.

            //Pseudocode:
            //Prüfen ob alle Spieler im Array alterSpieler unter 18 sind
            //Variable boolean einfügen
            //boolean Gültig = false;
            //for-schleife: geh das Array alterSpieler durch von i = 0 bis Array.Length i++
            //WENN: (alterSpieler[i] < 18)
            // {    
            //      
            //      Ausgabe: ("Die Aufstellung ist Gültig")    
            // }
            //SONST: Ausgabe: ("Die Aufstellung ist nicht Gültig")
            //
            // 




        //    bool Gültig = false;
        //    int[] alterSpieler = new int[11];
        //    for (int i = 0; i <= alterSpieler.Length; i++)
        //    {
        //        Random zufall = new Random();
        //        alterSpieler[i] = zufall.Next(10,20);
        //    }
        //    for (int i = 0;i <= alterSpieler.Length; i++)
        //    {
        //        if (alterSpieler[i] < 18)
        //        {
        //            Console.WriteLine("Die Aufstellung ist Gültig");
                    
        //        }
        //        else
        //        {
        //            Console.WriteLine("Die Aufstellung ist Ungültig");
        //        }

        //    }


        //}







    }
        

}   


