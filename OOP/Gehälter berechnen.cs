using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Einstieg1.OOP
{
    internal class Gehälter_berechnen
    {
        static void Main(string[] args)
        {
            /**Aufgabe Gehaltsberechnung**
             * 
            Erstellen Sie zuerst ein Klassendiagramm für die Aufgabe!
            Sie entwickeln für eine Firma eine Software zur Gehaltsberechnung in der
            Personalabteilung.
            Es gibt drei Arten von Mitarbeitern: 
            • Angestellte
            • Externe Mitarbeiter 
            • Praktikanten
            Für jeden Mitarbeiter werden der Name, Vorname und die zur Gehaltsberechnung
            notwendigen Daten gespeichert. 
            Angestellte werden nach Tarifgruppen und Alter bezahlt.Es gibt die folgenden vier
            Tarifgruppen:*/

            /* A    2560€
             * B    3000€
             * C    3200€
             * D    5400€
             * 
             * Die Formel für das Gehalt eines Angestellten lautet:
             * 
             * Gehalt = Tarifgruppe * (1+Alter-25/100)
             * 
             * Externe Mitarbeiter werden nach geleisteten Projektstunden bezahlt. Für jede 
                Projektstunde wird ein Betrag von 75 € bezahlt. 
                Die Praktikanten bekommen eine monatliche Vergütung, je nach Abteilung in der diese 
                tätig sind. Es gibt drei Abteilungen: Entwicklung, Vertrieb und Produktion. Ein 
                Praktikant aus dem Vertrieb bekommt monatlich 820 €, ein Praktikant aus der 
                Produktion 710 € und einer aus der Entwicklung 935 €. 
                Legen Sie einige Mitarbeiter mit entsprechenden Werten an und geben Sie die Gehälter 
                aus.*/


            /* Klasse: Mitarbeiter
             * --------------------------------
             * Attribute:
             * - Name:  string
             * - Vorname: string
             * --------------------------------
             * 
             * 
             * Klasse:Angestellte : Mitarbeiter
             * --------------------------------
             * Attribute:
             * - Tarifgruppe: string
             * - Alter:       int
             * --------------------------------
             * Methode:
             * + Gehalt (Tarifgruppe : string, Alter: int)
             * --------------------------------
             * 
             * 
             * Klasse: Externe Mitarbeiter: Mitarbeiter
             * --------------------------------
             * Attribute:
             * - ProjektStd:    int
             * - LohnProStd:    double
             * --------------------------------
             * Methode:
             * + Gehalt (ProjektStd: int, LohnProStd: double
             * --------------------------------
             * 
             * 
             * Klasse: Praktikant: Mitarbeiter
             * --------------------------------
             * Attribute:
             * - Abteilung: string
             * --------------------------------
             * Methode:
             * + Gehalt(Abteilung: double) */

            // 1. Angestellter: Alle Daten direkt im Konstruktor übergeben!
            // (Keine 5 Zeilen Zuweisung mehr nötig)
            Angestellter Sano = new Angestellter();
            Sano.name = "Sano";
            Sano.vorname = "Manjiro";
            Sano.Alter = 25;
            Sano.Tarifgruppe = "A";
            double GehaltSano = Sano.BerechneGehalt(); // Nutzt jetzt die Daten aus dem Objekt
            Console.WriteLine(Sano.vorname + " " + Sano.name + " " + GehaltSano + " Euro");


            ExterneMitarbeiter Itachi = new ExterneMitarbeiter();
            Itachi.name = "Uchiha";
            Itachi.vorname = "Itachi";
            Itachi.projektstd = 50;
            double ItachiGehalt = Itachi.GehaltExtern();
            Console.WriteLine(Itachi.vorname + " " + Itachi.name + " " +  ItachiGehalt + " Euro");


            Praktikant Sasuke = new Praktikant();
            Sasuke.name = "Uchiha";
            Sasuke.vorname = "Sasuke";
            Sasuke.Abteilung = "Entwicklung";
            double SasukeGehalt = Sasuke.GehaltPraktikant();
            Console.WriteLine(Sasuke.vorname + " " +  Sasuke.name + " " + SasukeGehalt + " Euro ");
        }
    }
    class Mitarbeiter
    {
        public string name { get; set; }
        public string vorname { get; set; }
    }
    class Angestellter : Mitarbeiter
    {
        public string Tarifgruppe { get; set; }
        public int Alter { get; set; }

        public double gehalt {  get; set; }

 
        public double BerechneGehalt()
        {
            // Variable vorab definieren, damit sie im gesamten Code nutzbar ist
            double gehalt = 0;
            

            switch (Tarifgruppe)
            {
                case "A":
                    gehalt = 2560; 
                    break;
                case "B":
                    gehalt = 3000; 
                    break;
                case "C":
                    gehalt = 3200; 
                    break;
                case "D":
                    gehalt = 5400; 
                    break;
            }

            
            return gehalt * (1 + (Alter - 25.0) / 100.0);
        }

    }
    class ExterneMitarbeiter : Mitarbeiter
    {
        public int projektstd { get; set; }
        public double lohnprostd { get; set; }

        public double GehaltExtern()
        {
            lohnprostd = 75;

            return projektstd * lohnprostd;
        } 

    }
    class Praktikant : Mitarbeiter
    {
        public string Abteilung { get; set; }
        public double Gehalt { get; set; }

        public double GehaltPraktikant()
        {
            double gehalt = 0;

            switch (Abteilung)
            {
                case "Entwicklung":
                    gehalt = 935;
                        break;
                case "Vertrieb":
                    gehalt = 820;
                        break;
                case "Produktion":
                    gehalt = 710;
                    break;
            }
            return gehalt;
        }


    }






}
