using System;

namespace Einstieg1.OOP
{
    internal class Assoziation_Aufgabe1
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1 
            Schreiben sie eine Klasse Person mit Attributen für den Nachnamen, Vornamen und
            das Alter. Schreiben Sie einen Konstruktor, welcher alle Eigenschaften beim Anlegen
            des Objektes initialisiert.Alle Eigenschaften der Klasse sollen nur durch Methoden
            lesbar sein.Lediglich der Nachname soll mittels einer Methode änderbar sein. Zudem
            soll die Klasse eine Adresse speichern können. Eine Adresse soll als eigene Klasse mit
            Straße und Hausnummer, PLZ und Ort gespeichert werden. Es soll eine Möglichkeit
            geben der Person eine Adresse hinzuzufügen bzw.durch Hinzufügen einer neuen
            Adresse die alte Adresse zu ändern.Person und Adresse sollen jeweils eine Methode
            zur Ausgabe aller Daten auf der Konsole implementieren.*/

            /*Erstellen Sie im Hauptprogramm mindestens eine Person mit einer Adresse und testen Sie
            alle Methoden. 

            Schreiben Sie eine Klasse Hund. Die Klasse Hund hat einen Namen. Zudem besitzt die
            Klasse zwei Methoden zum Füttern und Gassi gehen(machen jeweils eine
            Konsolenausgabe).Der Hund soll nur nach dem Füttern Gassi gehen.Eine
            Ausgabemethode soll den Namen ausgeben und auch Informationen darüber, ob der
            Hund schon gefüttert wurde.Eine Person muss mit dem Hund Gassi gehen.Nur
            Personen die älter als 16 Jahre sind, dürfen mit dem Hund Gassi gehen.

            Erweitern Sie die Klasse Person um einen Hund. 

            Testen Sie alle Methoden der Klasse Hund mit einem Personen-Objekt aus Teil 1.*/

            /* Klassendiagramm:
             * 
             * ADRESSE:
             * ----------------
             * - Straße:         string
             * - Hausnummer:     int
             * - PLZ:            int 
             * - Ort:            string  
             * ----------------
             * + Adresse (Straße, Hausnummer, Plz, Ort)
             * + GetInfo()       string
             * 
             * #############################################
             * 
             * PERSON:
             * ----------------
             * - Nachnamen:      string
             * - Vornamen:       string
             * - Alter:          int 
             * - Adresse:        Adresse
             * ----------------
             * + Person (Adresse, Nachname, Vorname, Alter)
             * + SetAdresse()    void
             * + GetInfo()       void
             * + GetAlter()      void
             * + GetVorname()    void
             * + GetNachname()   void
             * + GetAdresse()    Adresse 
             * + SetNachname()   void
             * 
             * ############################################
             * 
             * HUND:
             * ---------------
             * - Name:      string
             * - Gefüttert: bool
             * - Person:    Person
             * ---------------
             * + Füttern(): void
             * + Gassi():   void
             * + Info():    void
             */

            Adresse a1 = new Adresse("Informatikstraße", 12, 44135, "Dortmund");

            Person1 p1 = new Person1(a1, "Sano", "Manjiro", 33);
            Person1 p2 = new Person1(a1, "Sano", "Shinijiro", 16);

            p1.GetInfo();
            p1.SetNachname("Gojo");
            Console.WriteLine();
            //p1.GetInfo();
            //p1.GetAdresse();
            Console.WriteLine();
            Hundi doggy = new Hundi("Doggy", p1);
            doggy.Info();
            doggy.Gassi(p1);
            doggy.Füttern();
            doggy.Info();
            doggy.Gassi(p1);
            doggy.Gassi(p2);
            p1.GassiGehen(doggy);
            p2.GassiGehen(doggy);

        }
    }
    class Adresse
    {
        string Straße;
        int Hausnummer;
        int PLZ;
        string Ort;
        public Adresse(string straße, int hausnummer, int plz, string ort)
        {
            Straße = straße;
            Hausnummer = hausnummer;
            PLZ = plz;
            Ort = ort;
        }
        public string GetInfo()
        {
            return $"Straße  : {Straße} {Hausnummer}\nPlz     : {PLZ}\nOrt     : {Ort}";
        }
    }
    class Person1
    {
        string Nachname;
        string Vorname;
        int Alter;
        Adresse Adresse;

        public Person1(Adresse adresse, string nachname, string vorname, int alter)
        {
            Adresse = adresse;
            Nachname = nachname;
            Vorname = vorname;
            Alter = alter;
        }

        public void SetAdresse(Adresse adresse)
        {
            Adresse = adresse;
        }
        public int GetAlter()
        {
            return Alter;
        }
        public void GetVorname()
        {
            Console.WriteLine(Vorname);
        }
        public void GetNachname()
        {
            Console.WriteLine(Nachname);
        }
        public void SetNachname(string neuerNachname)
        {
            Nachname = neuerNachname;
        }
        public void GetAdresse()
        {
            Console.WriteLine(Adresse.GetInfo());
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name    : {Vorname} {Nachname}\nAlter   : {Alter}\n{Adresse.GetInfo()} ");
        }
        public void GassiGehen(Hundi hund)
        {
            hund.Gassi(this);
        }

    }
    class Hundi
    {
        string Name;
        bool Gefüttert;
        Person1 _person;


        public Hundi(string name, Person1 person)
        {
            Name = name;
            _person = person;
        }
        public void Füttern()
        {
            Gefüttert = true;
            Console.WriteLine("Der Hund wird Gefüttert!");
        }
        public string Futterstatus()
        {
            if (Gefüttert)
            {
                return "gefüttert";
            }
            else
            {
                return "nicht gefüttert";
            }
        }
        public void Gassi(Person1 person)
        {
            _person = person;

            if (Gefüttert && _person.GetAlter() > 16)
            {
                Console.WriteLine("Der Hund geht Gassi!");
            }
            else if (Gefüttert && _person.GetAlter() <= 16)
            {
                Console.WriteLine("Der Hund darf nicht Gassi mit der Person, sie ist zu jung!");
            }
            else
            {
                Console.WriteLine("Der Hund wurde noch nicht gefüttert und darf deshalb nicht Gassi!");
            }
        }
        public void Info()
        {
            Console.WriteLine($"HundeName: {Name}");
           
            Console.WriteLine($"Futterstatus: Der Hund wurde {Futterstatus()}");

        }
    }



}
