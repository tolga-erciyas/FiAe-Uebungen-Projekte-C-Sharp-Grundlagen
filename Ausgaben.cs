using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Ausgaben
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            //Aufgabe12();
            //Aufgabe13();
            //Aufgabe14();
            //Aufgabe31();
            //Aufgabe32();
            //Aufgabe33();
            //Aufgabe41();
            //Aufgabe42();
            //Aufgabe51();
            //Aufgabe52();
            //Aufgabe61();
            //Aufgabe62();
            //ZeigeNachricht();
            //string text = GetText(); 
            //Console.WriteLine(text);
            // Der Rückgabewert der Methode GetText() wird in der Variable text gespeichert.
        }
        static void Aufgabe11()
        {
            //Erstellen Sie ein Programm, welches Ihren Namen, Ihre Telefonnummer und Ihre E-Mail Adresse
            //(oder andere Daten) in je einer Zeile auf dem Bildschirm ausgibt.

            string name = "Tolga";
            int a = 123456789;
            string email = "lala@lala.de";

            Console.WriteLine($"{name}\n{a}\n{email}");
        }

        static void Aufgabe12()
        {
            //Schreiben Sie ein Programm, das folgendes Menü ausgibt:
            //******Meine Musiktitel******
            //N = Neuen Eintrag hinzufügen
            //L = Eintrag löschen
            //F = Titel finden
            //A = Alle Einträge anzeigen
            //B = Programm beenden
            //Ihre Wahl:

            Console.WriteLine("****** Meine Musiktitel ******");
            Console.WriteLine(" N  =  Neuen Eintrag hinzufügen");
            Console.WriteLine(" L  =  Eintrag löschen");
            Console.WriteLine(" F  =  Titel finden");
            Console.WriteLine(" A  =  Alle Einträge anzeigen");
            Console.WriteLine(" B  =  Programm beenden");

            Console.Write("Ihre Wahl: ");
            string wahl = Console.ReadLine();

            Console.WriteLine("Du hast gewählt: " + wahl);
        }

        static void Aufgabe13()
        {   //Erstellen Sie mit Steuerzeichen ein Programm, welches mit maximal zwei Console.WriteLine
            //Befehlen folgende Ausgabe erzeugt:
            //J
            //u
            //s
            //t for F
            //u
            //n

            Console.WriteLine("//J\n//u\n//s");
            Console.WriteLine("t for F\nu\nn");
        }

        static void Aufgabe14()
        {
            //Erstellen Sie ein Programm, welches exakt die folgenden Ausgaben erzeugt:
            //a) 
            //“It is impossible to make anything foolproof“ 
            //      “because fools are so ingenious(Murphy).“ 
            //wobei die Einrückung mit zwei Tabs erfolgen soll. 
            //b) 
            //Datei nicht gefunden: “C:\Docs\Sprueche.doc“ 
            //Hinweis: Verwenden Sie Escape - Sequenzen zur Ausgabe von Sonderzeichen oder Steuerzeichen. 

            Console.WriteLine("\"It is impossible to make anything foolproof\"\n\t\t\"because fools are so ingenious(Murphy).\"");

            Console.WriteLine("Datei nicht gefunden:\"C:\\Docs\\Sprueche.doc\"");
        }

        static void Aufgabe31()
        {
            //Erstellen Sie ein Programm, welches eine Temperatur in Grad Celsius von der Tastatur abfragt. Die
            //eingegebene Temperatur soll in Grad Fahrenheit und in Grad Kelvin umgerechnet werden. 
            //Verwenden Sie als Datentyp double.
            //Formeln: 
            //Fahrenheit = Celsius * 9 / 5 +32
            //Kelvin = Celsius + 273,15
            //32
            //Geben Sie die berechneten Werte anschließend wieder aus.  
            //Zur Kontrolle: 10° Celsius sind 50° Grad Fahrenheit und 283,15 Kelvin.

            Console.WriteLine("Bitte Temperatur in Celsius eingeben");
            double Celsius = double.Parse(Console.ReadLine());


            double Fahrenheit = (Celsius * 9) / 5 + 32;

            Console.WriteLine("Fahrenheit " + Fahrenheit);

            double Kelvin = Celsius + 273.15;

            Console.WriteLine("Kelvin " + Kelvin);
        }

        static void Aufgabe32()
        {
            //Erstellen Sie ein Programm, welches den Benzinverbrauch eines Autos in Liter pro 100 km berechnet. 
            //Der Benutzer gibt hierzu den Benzinverbrauch in Liter und die damit zurückgelegte Strecke in 
            //Kilometer ein. Das Ergebnis soll nach folgender Formel berechnet werden:  
            //Verbrauch = Liter / Strecke * 100
            //Geben Sie dieses Ergebnis aus!

            Console.WriteLine("Benzinverbrauch eingeben");
            double liter = int.Parse(Console.ReadLine());

            Console.WriteLine("Strecke eingeben");
            double Strecke = int.Parse(Console.ReadLine());

            double Durchschnittsverbrauch = liter / Strecke * 100;
            Console.WriteLine("Durchschnittsverbrauch = " + Durchschnittsverbrauch);

            // Alternativ mit Schleife 

            //while (true)
            //{
            //    Console.WriteLine("Benzinverbrauch eingeben:");
            //    double liter = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Strecke eingeben:");
            //    double strecke = double.Parse(Console.ReadLine());

            //    double verbrauch = (liter / strecke) * 100;
            //    Console.WriteLine("Durchschnittsverbrauch = " + verbrauch);

            //    Console.WriteLine("Nochmal? (j/n)");
            //    string antwort = Console.ReadLine();

            //    if (antwort == "n")
            //    {
            //        break;
            //    }
            //}
        }

        static void Aufgabe33()
        {
            //Erstellen Sie ein Programm, welches mittels des Durchmessers einer Kugel(D) das Volumen(V) und
            //die Oberfläche(M) berechnet und diese Werte ausgibt.Den Wert für Pi können Sie mit 3,14
            //annehmen oder die Konstante Math.PI verwenden!

            //Formeln:
            // V = Pi * D^3 / 6 
            // M = Pi * D^2


            Console.WriteLine("Kugeldurchmesser angeben in cm");
            double Kugeldurchmesser = double.Parse(Console.ReadLine());

            double V = 3.14 * Kugeldurchmesser * Kugeldurchmesser * Kugeldurchmesser / 6;
   
            double M = 3.14 * Kugeldurchmesser * Kugeldurchmesser;

            Console.WriteLine("Oberfläche = " + M + " cm\nVolumen = " + V + " cm");



            //Console.WriteLine("Kugeldurchmesser angeben in cm");
            //decimal kugeldurchmesser = decimal.Parse(Console.ReadLine());


        }

        static void Aufgabe41()
        {
            //Auf einem Kindergeburtstag werden Überraschungseier an die Kinder verteilt, so dass jedes Kind
            //gleich viele Eier erhalten soll.Schreiben Sie ein Programm, das zunächst die Anzahl der Kinder und
            //dann die Anzahl der Eier einliest.Anschließend gibt das Programm die Anzahl der Eier pro Kind und
            //die Anzahl der übrig gebliebenen Eier aus, wobei die letzte Anzahl mittels der Modulo - Division
            //ermittelt wird.

            Console.WriteLine("Kinder?");
            int kinder = int.Parse(Console.ReadLine());
            Console.WriteLine("Eier?");
            int eier = int.Parse(Console.ReadLine());

            int y = eier / kinder;
            int x = eier % kinder;


            Console.WriteLine($"Jedes Kind erhält {y} Eier");
            Console.WriteLine($"Restliche Eier {x}");
        }

        static void Aufgabe42()
        {

            double r = 93;
            double l = 11;
            double f = 50;

            double z = Math.Sqrt(r * r + (2 * Math.PI * f * l) * (2 * Math.PI * f * l));
            //Math.Sqrt ist in C# eine Methode der Klasse Math, die die Quadratwurzel einer Zahl berechnet.

            Console.WriteLine(z);
        }

        static void Aufgabe51()
        {
            double a = 3.0;
            double b = 3.5;
            Console.WriteLine($"{a}\n{b}");

            double summe = a + b;
            double differenz = b - a;
            double produkt = a * b;
            double quotient = b / a;

            Console.WriteLine($"Summe = {summe}\nDifferenz = {differenz}\nPrpdukt = {produkt}\nQuotient = {quotient}");
        }

        static void Aufgabe52()
        {

            int brutto = 50000;
            double steuersatz = 0.19;
            double netto = brutto / (1 + steuersatz);
            double mehrwertsteuer = brutto - netto;

            Console.WriteLine($"Netto = {netto}\nMehrwertsteuer = {mehrwertsteuer}");
        }


        static void Aufgabe61()
        {

            Console.WriteLine("Bitte Centbetrag eingeben:");
            double cent = double.Parse(Console.ReadLine());

            double euro = cent / 100;

            Console.WriteLine($"Cent:{cent}\nEuro:{euro}");
        }


        //Bonusaufgabe: Methode ohne und mit Rückgabewert.
       static void ZeigeNachricht() //-> Methode erstellt(Kein Rückgabewert!)
        {
            Console.WriteLine("Daten gespeichert!");
        }


        static string GetText() //-> Methode erstellt (Mit Rückgabewert)
        {
            return "Daten gespeichert!";
        }

        static void Aufgabe62() 
        {
            Console.WriteLine("Länge eines Zeitraums in Sekunden:");
            int sekunden = int.Parse(Console.ReadLine());

            // Tage 24*60*60 = 86400
            int tage = sekunden / 86400;
            sekunden = sekunden % 86400;

            // Stunden 60*60 = 3600
            int stunden = sekunden / 3600;
            sekunden = sekunden % 3600;

            // Minuten 60 
            int minuten = sekunden / 60;

            // Restsekunden 60 
            int restsek = sekunden % 60;


            Console.WriteLine($"Tage: {tage}\nStunden: {stunden}\nMinuten: {minuten}\nSekunden: {restsek}");

        }



    }
}       



    

    


























































































    

