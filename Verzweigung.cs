using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Verzweigung
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            //Aufgabe12();
            //Aufgabe21();
            //Aufgabe22();
            //Aufgabe31();
            //Aufgabe41();
            //Aufgabe42();
            //BonusAufgabeSwitchCase();
            //Aufgabe51();
            //Aufgabe52();


        }


        static void Aufgabe11()
        {
            //Aufgabe11
            //Erstellen Sie ein Programm, welches als Eingabe die Stückzahl und Einzelpreis einer Ware vom 
            //Anwender erfragt. Bei einer Abnahme von mehr als 10 Stück gibt es 5 % Rabatt, bei mehr als 50 Stück
            //gibt es 10 % Rabatt auf den Kaufpreis der Ware.
            //Das Programm soll den Gesamtpreis ausrechnen und ausgegeben.

            Console.WriteLine("Bitte Stückzahl der Ware eingeben");
            int stückzahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitte Einzelpreis der Ware eingeben");
            double einzelpreis = double.Parse(Console.ReadLine());

            if (stückzahl > 50)
            {
                einzelpreis *= 0.90; // 10 % Rabatt
            }

            else if (stückzahl > 10)
            {
                einzelpreis *= 0.95; // 5 % Rabatt
            }

            double Gesamtpreis = stückzahl * einzelpreis;

            Console.WriteLine($"Gesamzpreis: {Gesamtpreis}");
        }

        static void Aufgabe12()
        {

            //Schreiben Sie ein Programm, das die Ausgabe  
            //      “Antworten sie mit Ja(j oder J) oder Nein(n oder N):“ erzeugt. 
            //Lesen Sie ein Zeichen von der Tastatur ein und geben Sie je nach eingegebenem Buchstaben
            //folgende Ausgabe aus:  
            //     „Sie haben mit nein geantwortet“ oder
            //     „Sie haben mit ja geantwortet“ oder aber 
            //     „Sie haben eine falsche Eingabe gemacht.“ 
            Console.WriteLine("\"Antworten Sie mit Ja (j oder J) oder Nein (n oderN)\"");

            string eingabe = Console.ReadLine();

            if (eingabe == "j" || eingabe == "J")
            {
                Console.WriteLine("\"Sie haben mit Ja geantwortet\"");
            }
            else if (eingabe == "n" || eingabe == "N")
            {
                Console.WriteLine("\"Sie haben mit Nein geantwortet\"");
            }
            else
            {
                Console.WriteLine("\"Sie haben eine falsche Eingabe gemacht\"");
            }
            // zwei if : mehrere unabhängige Prüfungen   (mehrere richtige möglich)
            // else if : eine einzige Entscheidungskette (nur ein richtig)
        }

        static void Aufgabe21() 
        {
            Console.WriteLine("Bitte eine Zahl zwischen 10 und 100 eingeben");
            int eingabe = int.Parse(Console.ReadLine());

            if (eingabe >=10 == eingabe <= 100) 
            {
                Console.WriteLine("Richtig!");
            }
            else 
            {
                Console.WriteLine("Falsch!");
            }
            
        }


        static void Aufgabe22()
        {

            int aktien10 = 20;
            int aktien2 = 10;

            Console.WriteLine("Dauer der Betriebszugehörigkeit");
            int betriebszugehörigkeit = int.Parse(Console.ReadLine());

            Console.WriteLine("gekündigtes Arbeitsverhältnis?");
            string gekündigtesarbeitsverhätnis = Console.ReadLine();

            if (gekündigtesarbeitsverhätnis == "ja")
            {
                Console.WriteLine("Keine Aktien");
            }

            else if (gekündigtesarbeitsverhätnis == "nein" && betriebszugehörigkeit >= 10)
            {
                Console.WriteLine($"Anzah der Aktien: {aktien10}");
            }

            else if (gekündigtesarbeitsverhätnis == "nein" && betriebszugehörigkeit < 10 &&
                betriebszugehörigkeit >= 2)
            {
                Console.WriteLine($"Anzahl der Aktien: {aktien2}");
            }

            else if (gekündigtesarbeitsverhätnis != "ja" && gekündigtesarbeitsverhätnis != "nein")
            {
                Console.WriteLine("Ungültige Eingabe");
            }

            else
            {
                Console.WriteLine("Keine Aktien");
            }

        }

        static void Aufgabe31() 
        {
            //Mein Code:

            //Console.WriteLine("Geben Sie ihr Körpergewicht in kg an");
            //double gewicht = double.Parse(Console.ReadLine());

            //Console.WriteLine("Geben Sie ihre Körpergröße in Metern an");
            //double größe = double.Parse(Console.ReadLine());

            //Console.WriteLine("Geben Sie ihr Alter an");
            //int alter = int.Parse(Console.ReadLine());

            //double bmi = gewicht / (größe * größe);
            //Console.WriteLine("DEBUG BMI: " + bmi);
            //Console.WriteLine("DEBUG ALTER: " + alter);

            //if (alter >=19 && alter <= 24 && bmi >=19 && bmi <= 24) 
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else if (alter >= 25 && alter <= 34 && bmi >= 20 && bmi <= 25)
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else if (alter >= 35 && alter <= 44 && bmi >= 21 && bmi <= 26)
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else if (alter >= 45 && alter <= 54 && bmi >= 22 && bmi <= 27)
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else if (alter >= 55 && alter <= 64 && bmi >= 23 && bmi <= 28)
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else if (alter > 64 && bmi >= 24 && bmi <=29)
            //{
            //    Console.WriteLine("Gesunder BMI!");
            //}

            //else 
            //{
            //    Console.WriteLine("Ungesunder BMI!");
            //}
            //----------------------------------------------------------------

            // ChatGPT:

            Console.WriteLine("Geben Sie ihr Körpergewicht in kg an");
            double gewicht = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie ihre Körpergröße in Metern an");
            double größe = double.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie ihr Alter an");
            int alter = int.Parse(Console.ReadLine());

            double bmi = gewicht / (größe * größe);

            bool gesund = false;

            if (alter >= 19 && alter <= 24)
                gesund = bmi >= 19 && bmi <= 24;
            else if (alter >= 25 && alter <= 34)
                gesund = bmi >= 20 && bmi <= 25;
            else if (alter >= 35 && alter <= 44)
                gesund = bmi >= 21 && bmi <= 26;
            else if (alter >= 45 && alter <= 54)
                gesund = bmi >= 22 && bmi <= 27;
            else if (alter >= 55 && alter <= 64)
                gesund = bmi >= 23 && bmi <= 28;
            else if (alter > 64)
                gesund = bmi >= 24 && bmi <= 29;

            if (gesund)
                Console.WriteLine("Gesunder BMI!");
            else
                Console.WriteLine("Ungesunder BMI!");
        }

        static void Aufgabe41() 
        {
            Console.WriteLine("Wir prüfen jetzt ob eine Zahl Gerade oder Ungerade ist :)\nBist du Bereit?");
            Console.ReadLine();
            Console.WriteLine("Wirklich Bereit??");
            Console.ReadLine();
            Console.WriteLine("Gebe nun eine Zahl von 1 - 100 ein");
            int eingabe = int.Parse(Console.ReadLine());
            if (eingabe % 2 == 0)
                Console.WriteLine($"{eingabe}  Die Zahl ist Gerade!");
            else
                Console.WriteLine($"{eingabe}  Die Zahl ist Ungerade!");
        }

        static void Aufgabe42()
        {
            //double silber = 60.6;
            //double kupfer = 56.8;
            //double aluminium = 36.0;
            //double messing = 13.3;


            //Console.WriteLine("Länge in Meter eingeben");
            //double länge = double.Parse(Console.ReadLine());

            //Console.WriteLine("Durchmesser in mm eingeben");
            //double durchmesser = double.Parse(Console.ReadLine());

            //Console.WriteLine("Material eingeben");
            //double material = double.Parse(Console.ReadLine());

            //if (material == silber) 
            //{
            //    double a = 3.14 * (durchmesser * durchmesser) / 4;
            //    double r = länge / silber * a;

            //}


            Console.WriteLine("Länge in Meter:");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Durchmesser in mm:");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Material (Silber, Kupfer, Aluminium, Messing):");
            string material = Console.ReadLine();

            double k = 0;

            switch (material.ToLower())
            {
                case "silber":
                    k = 60.6;
                    break;

                case "kupfer":
                    k = 56.8;
                    break;

                case "aluminium":
                    k = 36.0;
                    break;

                case "messing":
                    k = 13.3;
                    break;

                default:
                    Console.WriteLine("Ungültiges Material");
                    return;
            }

            double a = Math.PI * d * d / 4;

            double r = l / (k * a);

            Console.WriteLine($"Widerstand: {r:F4} Ohm");
        }

        static void BonusAufgabeSwitchCase() 
        {
            Console.WriteLine("Farbauswahl: \"Rot\" \"Blau\" \"Grün\" \"Gelb\"");
            string eingabe = Console.ReadLine();

            switch (eingabe.ToLower())
            {
                case "rot":
                    break;

                case "blau":
                    break;
                case "grün":
                    break;
                case "gelb":
                    break;
            }
            Console.WriteLine($"Rosen sind {eingabe}");

        }

        static void Aufgabe51()
        {
            //Mein Code:
            //Console.WriteLine("Gib eine Zahl von -100 bis 100 ein");
            //int x = int.Parse(Console.ReadLine());
            //int y = x;

            //if (x <= 0)
            //{
            //    y = y - x * 2;
            //}

            //Console.WriteLine($"Der Betrag ist {y}");

            //ChatGPT:

            Console.WriteLine("Gib eine Zahl ein:");
            int x = int.Parse(Console.ReadLine());

            int betrag;

            if (x < 0)
                betrag = -x;
            else
                betrag = x;

            Console.WriteLine($"Der Betrag ist {betrag}");


        }
        static void Aufgabe52()
        {
            Console.WriteLine("Erste Zahl eingeben:");
            double zahl1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zweite Zahl eingeben:");
            double zahl2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Operator wählen\n+, -, *, /");
            string eingabe = Console.ReadLine();

            double ergebnis = 0;

            switch (eingabe)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;

                case "-":
                    ergebnis = -zahl1 - zahl2;
                    break;

                case "*":
                    ergebnis = (zahl1 * zahl2);
                    break;
                case "/":
                    ergebnis = (zahl1 / zahl2);
                    break;

            }
            Console.WriteLine(ergebnis);
        }




        


        






        
        


        
    }
}
        
    

