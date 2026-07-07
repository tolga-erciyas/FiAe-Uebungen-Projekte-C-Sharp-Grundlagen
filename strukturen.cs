using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class strukturen
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            Aufgabe12();
        }
        static void Aufgabe11()
        {
            //Schreiben Sie ein Programm, das eine Struktur für die Erfassung von Personen.Die Struktur
            //bietet Speicherplatz für den Vornamen, den Nachname, einen Steuersatz und ein Brutto
            //Gehalt.Die möglichen Steuersätze sind 10 %, 20 % und 30 %.

            //Legen Sie zunächst fünf „Personen“ an.Achten Sie darauf, dass jeder Steuersatz mindestens
            //einmal vorkommt.
            //Erweitern Sie das Programm um eine Funktion, die das Netto-Gehalt berechnet.



            Person p1;
            p1.Vorname = "John";
            p1.Nachname = "Snow";
            p1.Steuersatz = 10;
            p1.Brutto = 3000.0;
            
            Person p2;
            p2.Vorname = "King";
            p2.Nachname = "Kong";
            p2.Steuersatz = 30;
            p2.Brutto = 6000.0;

            Person p3;
            p3.Vorname = "Manjiro";
            p3.Nachname = "Sano";
            p3.Steuersatz = 20;
            p3.Brutto = 5000.0;

            Person p4;
            p4.Vorname = "Satoru";
            p4.Nachname = "Gojo";
            p4.Steuersatz = 10;
            p4.Brutto = 9000.0;

            Person p5;
            p5.Vorname = "Kiyotaka";
            p5.Nachname = "Ayanakoji";
            p5.Steuersatz = 30;
            p5.Brutto = 50000.0;

            double netto = NettoGehalt(p1.Steuersatz, p1.Brutto);

            Console.WriteLine($"Name: {p1.Vorname} {p1.Nachname}" +
                $"\nSteuersatz: {p1.Steuersatz}" +
                $"\nBrutto: {p1.Brutto}\nNetto: {netto}");

        }
        struct Person
        {
            public string Vorname;
            public string Nachname;
            public int Steuersatz;
            public double Brutto;
        }

        static double NettoGehalt(int Steuersatz, double Brutto)
        {
            return Brutto * (100 - Steuersatz) / 100.0;

        }

        static void Aufgabe12()
        {
            //Brainstorming:
            // WAS VERLANGT DIE AUFGABE?
            //-ich soll ein programm schreiben welches einen jahreskalender aus der unten erstellten struct erstellt.
            //-ich soll ein arary 365 elemente erstellen und dann befüllen mit den tagen
            //-ich soll davon ausgehen das der feb immer 28 tage hat
            //- ausgabe soll sein- tag: 1 monat 1 jahr: 2026 
            //WAS BRAUCHE ICH FÜR DIE AUFGABE?
            //-ich brauche schon mal ein array mit 365 elementen wo ich die tage reinpacke
            //-ich brauche aufjedenfall eine schleife um das array durchzugehen
            //- ich brauche 3 variablen, tag,monat,jahr wobei ich tag und monat vom array hole, jahr bleibt gleich
            //-ich muss wissen wie viele tage jeder monat hat
            //-ich brauche einen startwert z.B januar 31 tage, dann feb 28 und die restichen 10 teile ich durch die übrigen teile

            //Pseudeocode:
            //1.struct Datum erstellen mit 3 int variablen,tag,monat,jahr
            //2.(in main) das arary erstellen mit 365 elementen

            Datum[] kalender = new Datum[365];
            int[] tageImMonat = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            int pos = 0;

            for (int m = 1; m <= 12; m++)
            {
                for (int t = 1; t <= tageImMonat[m - 1]; t++)
                {
                    kalender[pos].tag = t;
                    kalender[pos].monat = m;
                    kalender[pos].jahr = 2026;
                    pos = pos + 1;
                }
            }
            for (int i = 0; i < kalender.Length; i++)
            {
                Console.WriteLine($"Tag: {kalender[i].tag} Monat: {kalender[i].monat} Jahr: {kalender[i].jahr}");
            }

        }

        struct Datum
        {
            public int tag;
            public int monat;
            public int jahr;
        }










    }
}
