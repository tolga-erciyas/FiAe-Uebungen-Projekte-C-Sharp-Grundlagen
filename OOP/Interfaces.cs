using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            Biene Maya = new Biene();
            Maya.Fliegen();
            Fledermaus Dracula = new Fledermaus();
            Dracula.Fliegen();

            Person2 max = new Person2();
            Bild bildZeitung = new Bild();

            Person2 sano = new Person2();
            Person2 lisa = new Person2();

            CNN DieZeit = new CNN();
            Console.WriteLine();
            DieZeit.Anmelden(lisa);

            DieZeit.SendeNachricht("Wichtige Nachricht!");
            lisa.EmpfangeNachricht("Die Welt ist in Ordnung\nDöner wird billiger!");
            sano.EmpfangeNachricht("Gaming wird teurer");

            Console.WriteLine();
            Temperatur temperatur = new Temperatur();
            temperatur.Celsius = 10.0;
            Console.WriteLine(temperatur.Fahrenheit);
            ((IFahrenheit)temperatur).Ausgabe(); // wir rufen es auf dieser weise auf weil es mehrere interfaces mit dem selben namen Ausgabe() gibt-
            // und wir wissen wollen welche ausgabe von welchem interface wir brauchen.
            ((ICelsius)temperatur).Ausgabe();
            ((IKelvin)temperatur).Ausgabe();
            //temperatur.Fahrenheit();

            int[] Wasserpegel = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           

        }
    }
    /*Aufgabe 1 
        Entwickeln Sie ein Interface namens IFliegen, dass eine Methode Fliegen() deklariert. Diese 
        Methode soll keinen Rückgabewert besitzen und keine Parameter erwarten. Entwickeln Sie 
        dann eine Klasse namens Biene, die das Interface IFliegen implementiert. Geben Sie in der zu 
        implementierenden Methode „Summsumm“ auf der Standardausgabe aus. Entwickeln Sie 
        dann eine Klasse namens Fledermaus, die ebenfalls das Interface IFliegen implementiert. 
        Geben Sie in der zu implementierenden Methode „Flatterflatter“ auf der Standardausgabe 
        aus.

        Legen Sie jeweils eine Biene, eine Fledermaus an und testen Sie Ihre 
        Methoden.*/
    public interface IFliegen
    {
        void Fliegen();

    }

    class Biene
    {
        public void Fliegen()
        {
            Console.WriteLine("Summsumm");
        }
    }
    class Fledermaus : IFliegen
    {
        public void Fliegen()
        {
            Console.WriteLine("Flatterflatter");
        }
    }

    /*Aufgabe 2 
        Menschen sind an wichtigen Ereignissen interessiert. Um Objekten Nachrichten aus 
        verschiedenen Quellen zukommen zu lassen, können diese das Interface 
        INachrichtenEmpfänger verwenden: */
    interface INachrichtenEmpfänger
    {
        // Übergabe einer neuen Nachricht 
        void EmpfangeNachricht(string nachricht);
    }

    /*Eine empfangene Nachricht wird vom Nachrichten-Empfänger im einfachsten Fall auf dem 
      Bildschirm ausgegeben. 
      Nachrichten können wiederum von verschiedenen Quellen erzeugt werden, z.B. Webseiten, 
      TV, Radio oder Zeitungen. Die Fähigkeit, Nachrichten zu versenden, lässt sich somit auch in 
      ein Interface INachrichtenQuelle abstrahieren:*/
    interface INachrichtenQuelle
    {
        // Interessierte können sich bei der Quelle anmelden 
        // (falls sie noch nicht angemeldet sind) 
        void Anmelden(INachrichtenEmpfänger empfänger);

        // Angemeldete können sich bei der Quelle wieder abmelden 
        // (falls sie angemeldet sind) 
        void Abmelden(INachrichtenEmpfänger empfänger);

        // neue Nachricht wird an alle angemeldeten Empfänger übergeben 
        // (Aufruf deren Methode EmpfangeNachricht) 
        void SendeNachricht(string nachricht);

    }
    /*Etwas umständlich an dieser Struktur ist, dass sich ein Nachrichten-Empfänger bei jeder 
    Nachrichten-Quelle anmelden muss, von der er neue Nachrichten zugeschickt bekommen 
    möchte. 
    Günstiger wäre ein Vermittler, der sich bei mehreren Nachrichten-Quellen anmeldet und alle 
    Nachrichten, die er von den Quellen bekommt, direkt an Nachrichten-Empfänger 
    weiterleitet, die sich bei ihm angemeldet haben. Ein Vermittler ist damit sowohl Nachrichten
    Empfänger als auch Nachrichten-Quelle.

    Legen Sie mindestens ein Objekt von einer Klasse Person an, welches das Interface 
    INachrichtenEmpfänger implementiert. 
    Legen Sie verschiede Klassen für Nachrichten-Quellen an, die das Interface 
    INachrichtenQuelle implementieren. Legen Sie von jeder Klasse mindestens ein Objekt 
    an. 

    Definieren Sie anschließend eine Klasse Vermittler, die die beiden Interfaces 
    INachrichtenEmpfänger und INachrichtenQuelle implementiert. 
    Testen Sie Ihren Code indem Sie mehrere Quellen bei dem Vermittler anmelden, eine oder 
    mehrere Personen bei dem Vermittler anmelden und bei den Quellen Nachrichten erzeugen.*/

    /*Klassendiagram
     * 
     * Person : INachrichtenEmpfänger
     * ------------------------------
     * + EmfpangeNachricht(string nachricht) : void 
     * ------------------------------
     * Bild : INachrichtenQuelle
     * ------------------------------
     * + Anmelden() : void 
     * + Abmelden() : void 
     * + SendeNachricht(string nachricht) : void 
     * ------------------------------
     * CNN : INachrichtenQuelle
     * ------------------------------
     * + Anmelden() : void 
     * + Abmelden() : void 
     * + SendeNachricht() : void 
     * ------------------------------
     * RadioMk : INachrichtenQuelle
     * ------------------------------
     * + Anmelden() : void 
     * + Abmelden() : void 
     * + SendeNachricht() : void 
     * ------------------------------
     * Vermittler : INachrichtenEmpfänger, INachrichtenQuelle
     * ------------------------------
     * + Anmelden() : void 
     * + Abmelden() : void 
     * + SendeNachricht() : void 
     * + Empfangenachricht() : void*/

    class Person2 : INachrichtenEmpfänger
    {
        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine(nachricht);
        }
    }
    class Bild : INachrichtenQuelle
    {
        INachrichtenEmpfänger[] empfängerListe = new INachrichtenEmpfänger[10];
        int anzahl = 0;
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {

            empfängerListe[anzahl] = empfänger;  // neuen Empfänger an die nächste freie Stelle schreiben
            anzahl = anzahl + 1;                 // Zähler um eins erhöhen
            Console.WriteLine("Sie sind Angemeldet");
        }
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("Sie sind Abgemeldet");
        }
        public void SendeNachricht(string nachricht)
        {
            for (int i = 0; i < anzahl; i++)
            {
                empfängerListe[i].EmpfangeNachricht(nachricht);
            }
        }

    }
    class CNN : INachrichtenQuelle
    {
        INachrichtenEmpfänger[] empfängerListe = new INachrichtenEmpfänger[10];
        int anzahl = 0;
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {

            empfängerListe[anzahl] = empfänger;  // neuen Empfänger an die nächste freie Stelle schreiben
            anzahl = anzahl + 1;                 // Zähler um eins erhöhen
            Console.WriteLine("Sie sind Angemeldet");
        }
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("Sie sind Abgemeldet");
        }
        public void SendeNachricht(string nachricht)
        {
            for (int i = 0; i < anzahl; i++)
            {
                empfängerListe[i].EmpfangeNachricht(nachricht);
            }
        }

    }
    class RadioMk : INachrichtenQuelle
    {
        INachrichtenEmpfänger[] empfängerListe = new INachrichtenEmpfänger[10];
        int anzahl = 0;
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {

            empfängerListe[anzahl] = empfänger;  // neuen Empfänger an die nächste freie Stelle schreiben
            anzahl = anzahl + 1;                 // Zähler um eins erhöhen
            Console.WriteLine("Sie sind Angemeldet");
        }
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("Sie sind Abgemeldet");
        }
        public void SendeNachricht(string nachricht)
        {
            for (int i = 0; i < anzahl; i++)
            {
                empfängerListe[i].EmpfangeNachricht(nachricht);
            }
        }

    }
    class Vermittler : INachrichtenQuelle, INachrichtenEmpfänger
    {
        INachrichtenEmpfänger[] empfängerListe = new INachrichtenEmpfänger[10];
        int anzahl = 0;
        public void Anmelden(INachrichtenEmpfänger empfänger)
        {

            empfängerListe[anzahl] = empfänger;  // neuen Empfänger an die nächste freie Stelle schreiben
            anzahl = anzahl + 1;                 // Zähler um eins erhöhen
            Console.WriteLine("Sie sind Angemeldet");
        }
        public void Abmelden(INachrichtenEmpfänger empfänger)
        {
            Console.WriteLine("Sie sind Abgemeldet");
        }
        public void SendeNachricht(string nachricht)
        {
            for (int i = 0; i < anzahl; i++)
            {
                empfängerListe[i].EmpfangeNachricht(nachricht);
            }
        }
        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine(nachricht);
        }

    }
    /*Aufgabe 3:
     *  Schreiben Sie drei Schnittstellen für die Verwendung von Temperaturwerten in Celsius, 
        Fahrenheit und Kelvin. Jedes Interface besitzt ein Property für den Temperaturwert (z.B. 
        double Celsius {get; set;} ) und eine Methode Ausgabe() welche die Temperatur 
        auf der Konsole (mit der richtigen Maßeinheit) ausgibt. 
     * 
     *  Die Getter sollen den Temperaturwert jeweils in Celsius, Fahrenheit und Kelvin zurückliefern  
        (z.B. 1 Grad Fahrenheit = (Grad Celsius * 9) / 5 + 32).
        Die Setter sollen den Temperaturwert immer in Grad Celsius speichern (z.B. 1 Grad Celsius = 
        (Grad Fahrenheit - 32) * 5 / 9)

        Hinweis Kelvin: 1 Kelvin = Grad Celsius + 273,15.
        Schreiben Sie eine Klasse Temperatur, welche alle drei Schnittstellen implementiert und ein 
        Attribut temperatur besitzt. In dem Attribut temperatur wird immer ein Celsiuswert 
        gespeichert. Testen Sie Properties und die Ausgabe-Methoden. Testen Sie Ihre 
        Implementierungen in der Main-Methode.
    
        Zur Kontrolle: 10° Celsius sind 50° Fahrenheit und 283,15 Kelvin. */

    /* Klassendiagramm:
     * ----------------
     * Temperatur : IFahrenheit, ICelsius, IKelvin
     * ----------------
     * - Temperatur : double
     * ----------------
     * IFahrenheit (Interface):
     * -----------------------
     * Fahrenheit : double {get; set;}
     * -----------------------
     * Ausgabe() : void
     * -----------------------
     * ICelsius (Interface):
     * -----------------------
     * Celsius : double {get; set;}
     * -----------------------
     * Ausgabe() : void
     * -----------------------
     * IKelvin (Interface):
     * -----------------------
     * Kelvin : double {get; set;}
     * -----------------------
     * Ausgabe() : void */

    public interface IFahrenheit
    {
        double Fahrenheit { get; set; }
        void Ausgabe(); // Methoden im Interface Automatisch Public !!!

    }
    public interface ICelsius
    {
        double Celsius { get; set; }
        void Ausgabe();
    }
    public interface IKelvin
    {
        double Kelvin { get; set; }
        void Ausgabe();
    }
    public class Temperatur : IFahrenheit, ICelsius, IKelvin
    {
      

        public double Celsius { get; set; }
        public double Fahrenheit
        {
            get { return (Celsius * 9) / 5 + 32; }
            set { Celsius = (value - 32) * 5 / 9; }
        }
        public double Kelvin
        {
            get { return Celsius + 273.15; }
            set { Celsius = (value - 273.15); }
        }



        void IFahrenheit.Ausgabe() { Console.WriteLine(Fahrenheit + " Fahrenheit"); }
        void ICelsius.Ausgabe() { Console.WriteLine(Celsius + " Celsius"); }
        void IKelvin.Ausgabe() { Console.WriteLine(Kelvin + " Kelvin"); }

    }
    /* Aufgabe 4:
     * 
     *  Nicht weit von hier fließt der Fluss Ruhr, der einmal der Industrieregion Ruhrgebiet den 
        Namen gegeben hat, durch eine idyllische Landschaft. In den Ruhrwiesen weiden heute 
        Wasserbüffel.  

        Im Verlauf des Jahres steigt und fällt der Wasserstand des Flusses. Beim Normalstand haben 
        die Büffel ideale Bedingungen, fällt der Wasserstand auf 0,3 m oder weniger, wird es für die 
        Tiere zu trocken und sie müssen zusätzlich getränkt werden. Steigt der Wasserstand auf eine 
        Höhe von 5 bis 7 m, werden die Ruhrwiesen überschwemmt und die Büffel sollten in den 
        Stall gebracht werden. Bei einer Wasserhöhe ab 7 m müssten die Büffel im Fluss schwimmen. 
        Dann wird es allerhöchste Zeit, sie vom Fluss zu entfernen.
    
        Am Flussufer führt ein Rad- und Wanderweg vorbei. Besonders die Mitglieder des 
        Wandervereins nutzen diesen Weg. Fällt der Wasserstand auf einen Meter oder weniger, ist 
        es möglich, den Fluss zu durchqueren. Ab 6 m Wasserhöhe ist der Wanderweg 
        überschwemmt.  

        Auf einem Damm durchquert eine Straße die Ruhrwiesen. Ab einem Wasserstand von 9 m ist 
        die Straße überschwemmt und die Straßenwacht muss die Straße sperren. Für das Aufheben 
        der Sperre ist dann eine andere Behörde zuständig, d.h. sie führt nichts durch wenn der 
        Spiegel wieder sinkt.

        Aufgabe:  

        Schreiben Sie ein Programm, das den Wasserstand zufällig innerhalb sinnvoller Grenzen 
        steigen und fallen lässt. Drei Beobachter sollen den Wasserstand beobachten:
    
        • Beobachter Nr.1 passt auf die Wasserbüffel auf 
        • Beobachter Nr.2 kontrolliert den Wanderweg für den Wanderverein 
        • Beobachter Nr.3 hat die Straße für die Straßenwacht im Auge
    
        Bei Handlungsbedarf schreiben diese Beobachter eine passende Meldung auf die Konsole.*/

    /* Klassendiagramm
     * ------------------------
     * Fluss: IBeobachter1,IBeobachter2,IBeobachter3
     * ---------------
     * Wasserstand : int (enum)
     * ------------------------
     * IBeobachter1 (Interface):
     * ------------------------
     * AufBüffelAufpassen() : void
     * Ausgabe() : void
     * ------------------------
     * IBeobachter2 (Interfaces):
     * ------------------------
     * WanderwegKontrolle() : void
     * Ausgabe() : void 
     * ------------------------
     * IBeobachter3 (Interface)
     * ------------------------
     * KontrolleStraße() : void
     * Ausgabe() : void */

    public enum Wasserstand
    {
        Niedrig,
        Mittel,
        Hoch

    }
    public interface IBeoachter1
    {
        void AufBüffelAufpassem();
        
    }
    public interface IBeobachter2
    {
        void WanderWegKontrolle();
       

    }
    public interface IBeobachter3
    {
        void KontrolleStraße();
        
    }
    class Fluss : IBeoachter1, IBeobachter2, IBeobachter3
    {
        double wasserstand;
        public Fluss()
        {
            
            Random zufall = new Random();
            wasserstand = zufall.NextDouble() * 10;
        }    
        
        Wasserstand aktuellerZustand;

        public void AufBüffelAufpassem()
        {   

            if (wasserstand <= 0.3)
            {
                aktuellerZustand = Wasserstand.Niedrig;
            }
            else if (wasserstand >= 7)
            {
                aktuellerZustand = Wasserstand.Hoch;
            }
            else
            {
                aktuellerZustand = Wasserstand.Mittel;
            }
        }

        public void WanderWegKontrolle()
        {
            if (wasserstand <= 1.0)
            {
                aktuellerZustand = Wasserstand.Niedrig;
            }
            else if(wasserstand >= 6.0)
            {
                aktuellerZustand = Wasserstand.Hoch;
            }
        }
        public void KontrolleStraße()
        {
            if( wasserstand >= 9.0)
            {
                aktuellerZustand = Wasserstand.Hoch;
            }
            else
            {
                aktuellerZustand = Wasserstand.Niedrig;
            }
        }








    }











}
