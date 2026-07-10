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
            //Aufgabe4();
            //Aufgabe5();
            //Aufgabe6();
            //Aufgabe7();
            //Aufgabe8();
            Aufgabe9();
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


            if (alter < 18)
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
            //boolean Gültig = true
            //for-schleife: geh das Array alterSpieler durch von i = 0 bis Array.Length i++
            //WENN: (alterSpieler[i] >= 18)
            // {    
            //      
            //      Gültig = false;
            //      break;
            // }
            //WENN Gültig:
            //Ausgabe: Die Aufstellung ist Gültig
            //SONST:
            //Ausgabe: Die Aufstellung ist Ungültig



            int[] Stamm11 = new int[11];
            Random zufall = new Random();
            for (int i = 0; i < Stamm11.Length; i++)
                Stamm11[i] = zufall.Next(1, 19);

            bool Gültig = true;

            for (int i = 0; i < Stamm11.Length; i++)
            {
                if (Stamm11[i] >= 18)
                {
                    Gültig = false;
                    break;
                }
            }
            if (Gültig)
            {
                Console.WriteLine("Stamm 11 Gültig");
            }
            else
                Console.WriteLine("Stamm11 Ungültig");






        }

        static void Aufgabe5()
        {
            //Schreiben Sie einen Pseudocode, der das Gewicht(in kg)
            //und die Größe(in m) eines Patienten einliest.
            //Berechnen Sie den BMI mit der Formel:
            //BMI = Gewicht / (Größe * Größe)
            //Wenn der BMI größer als 25 ist, geben Sie "Übergewicht"
            //aus, ansonsten geben Sie "Normalgewicht" aus.

            //Pseudocode:
            //in main:
            //Gewicht in (kg) und Größe in (m) eines Patienten einlesen:
            //BMI aus eingelesene Größe und Gwicht ausrechen und ausgeben
            //außerhalb von main:
            //Funktion bauen:
            //  double bmi = gewicht / (größe * größe);
            //  WENN: (BMI > 25)
            //  {Ausgabe: "Übergewicht"}
            //  SONST:
            //  Ausgabe: "Normalgewicht"
            // return bmi;
            //Funktion zum einlesen bauen:
            //Gewicht und Größe einlesen mit ReadDouble();
            //Ausführung in main:




            Console.WriteLine("Geben Sie Ihr Gewicht in kg und Ihre Größe in m an");

            var (kg, größe) = ReadDouble();
            double bmi = BMI(kg, größe);
            Console.WriteLine($"BMI: {bmi}");

        }
        static double BMI(double gewicht, double größe)
        {
            double bmi = gewicht / (größe * größe);

            if (bmi > 25)
            {
                Console.WriteLine("Übergewicht");
            }
            else
            {
                Console.WriteLine("Normalgewicht");
            }
            return bmi;
        }
        static (double kg, double größe) ReadDouble()
        {
            double kg = double.Parse(Console.ReadLine());
            double größe = double.Parse(Console.ReadLine());
            return (kg, größe);
        }

        static void Aufgabe6()
        {
            //Gegeben ist ein Array freieTermine mit der Dauer der
            //freien Terminslots in Minuten(z.B. [15, 30, 10, 45]).
            //Ein Patient benötigt einen Termin von 37 Minuten.
            //Schreiben Sie einen Pseudocode, der den ersten Slot
            //findet, der groß genug ist.
            //Geben Sie den Index des Slots aus.Wenn kein passender
            //Slot gefunden wird, geben Sie "-1" aus.


            //Pseudocode:

            //Ausgabe:"Wie viele min werden für patient x benötigt?"
            //min einlesen
            //variable x erstellen wo die eingabe in min gespeichert wird 
            //for-schleife für das Array freieTermine
            //gehe das array durch und gucke jeden freien slot an
            //while-schleife: wiederhole solange terminslot kleiner als x 
            //{
            //  ausgabe: freieTermine[i] = "-1"
            //}
            //WENN: terminslot >= x - diesen terminslot merken
            //{
            //  ausgabe: ($"{freieTermine[i]} der Terminslots kann gebucht werden");
            //}
            //ENDE:

            int[] freieTermine = new int[10];
            Random zufall = new Random();
            for (int i = 0; i < freieTermine.Length; i++)
            {
                freieTermine[i] = zufall.Next(15, 100);
            }
            Console.Write("Wie viele Min werden für Patient x benötigt? ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Terminslots:");
            Console.WriteLine();

            for (int i = 0; i <= freieTermine.Length; i++)
            {
                
                while (freieTermine[i] < min)
                {
                    Console.WriteLine("-1");
                    i++;
                }
                if (freieTermine[i] >= min)
                {
                    Console.WriteLine($"{freieTermine[i]}min: der Terminslot kann gebucht werden");
                    break;
                }



            }


        }
        static void Aufgabe7()
        {
            //Gegeben sind zwei Arrays gleicher Länge:
            //kostenProStueck und anzahlVerwendet.
            //Schreiben Sie einen Pseudocode, der die Gesamtkosten
            //der Baugruppe berechnet.
            //Wenn die Gesamtkosten 1000 Euro übersteigen, wird ein
            //Mengenrabatt von 5 % auf die Gesamtkosten gewährt.
            //Geben Sie die «nalen Kosten aus.

            //Pseudocode:
            //kostenProStueck[...], anzahlVerwendet[...]
            // variable Summer erstellen und = 0 setzen
            //for-schleife gehe kosten[] durch nehme jede zahl aus dem index:
            //Rechnung der Gesamtkosten: summe = summe +  kosten[i] x anzahl[i]
            //WENN: Gesamtkosten größer 1000 kommt ein Rabatt von 5% darauf.
            //Ausgabe: alle gesamtkosten ausgeben und wenn vorhanden den rabatt

            double[] kosten = new double[]{ 19.99, 24.55, 50, 100, 199.99 };
            double[] anzahl = new double[] { 10, 20, 50, 100, 200 };

            double summe = 0;
         
            for (int i = 0; i < kosten.Length; i++)

                summe += kosten[i] * anzahl[i];
                
            if (summe > 1000)
            {
                double MitRabatt = summe * 0.95;
                Console.WriteLine($"{MitRabatt} Mit Rabatt");
            }
            else
                Console.WriteLine(summe);
            
           



        }
        static void Aufgabe8()
        {
            //Schreiben Sie einen Pseudocode, der eine bestimmte
            //anzahlEier gleichmäßig auf eine anzahlKinder verteilt.
            //Geben Sie aus, wie viele Eier jedes Kind bekommt und wie
            //viele Eier als Rest übrig bleiben.
            //Hinweis: Denken Sie an die Operatoren für
            //Ganzzahldivision und Modulo.

            //Pseudocode:

            //eingabe: anzahl der Kinder
            //eingabe: anzahl der eier 
            //variable int Kinder erstellen
            //variable int Eier erstellen 
            //Rechnung:Eier =  Eier / Kinder
            //Variable Rest und berechnen Eier % Kinder 
            //Ausgabe: Jedes Kind bekommt x Eier und x bleiben übrig 
            //


            Console.WriteLine("Anzahl Kinder eingeben");
            int Kinder = int.Parse(Console.ReadLine());
            Console.WriteLine("Anzahl eier eingeben");
            int Eier = int.Parse(Console.ReadLine());

            int EierProKind = Eier / Kinder ;
            int Rest = Eier % Kinder ;
            

            Console.WriteLine($"Jedes Kind bekommt {EierProKind} Eier und {Rest} bleiben übrig");





        }
        static void Aufgabe9()
        {
            //Gegeben ist ein Array gefundeneEier, das speichert, wie
            //viele Eier jedes Kind gefunden hat.
            //Schreiben Sie einen Pseudocode, der das Maximum in
            //diesem Array findet.
            //Geben Sie am Ende aus: "Gewinner hat X Eier gefunden",
            //wobei X das gefundene Maximum ist.

            //Pseudocode:
            //Gegeben Array gefundeneEier[] {1..2..3..4..5}
            //Variable GrößteZahl erstellen und auf 0 setzen;
            //For-Schleife: Für Array gefundeneEier 
            //Gehe durch das Array und prüfe ob gefundeneEier[i] > Größte
            //WENN: gefundeneEier[i] > Größte
            //DANN: Größte = gefundeneEier[i]
            //Ausgabe: Gewinner hat {Größte} Eier gefunden.

            int[] gefundeneEier = new int[10];
            Random zufall = new Random();
            for(int i = 0;i < gefundeneEier.Length;i++)
            gefundeneEier[i] = zufall.Next(1, 21);

            int Größte = 0;
            for(int i = 0; i < gefundeneEier.Length; i++)
            {
                if(gefundeneEier[i] > Größte )
                {
                    Größte = gefundeneEier[i];
                }
                
                Console.WriteLine($"Kind {i+1}: {gefundeneEier[i]} Eier");

            }
            Console.WriteLine();
            Console.WriteLine($"Gewinner hat {Größte} Eier gefunden");



        }






    }
}   






