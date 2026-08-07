using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Einstieg1.OOP
{
    internal class Datenkapselung
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1 
             * 
             Implementieren Sie eine Klasse Socke mit den folgenden Attributen:
              Farbe
              Trocken
              Sauber

              Welche Datentypen sind sinnvoll?

              Fügen Sie der Klasse Socke folgende Methoden hinzu:
              Trockne() 
              Wasche()
              Ausgabe()
              SetFarbe()

              Implementieren Sie Trockne() und Wasche() so, dass der interne Zustand trocken geändert
              wird.Überlegen Sie dazu, welche internen Zustände die Methoden Trockne() und Wasche()
              ändern sollen/müssen.

              Die Methode Ausgabe() gibt eine Meldung in folgender Form aus: z.B. "Die Socke mit der 
              Farbe Rot ist sauber und trocken." 

              Legen Sie innerhalb der Main()-Methode mindestens ein Socke-Objekt an und testen Sie alle
              Methoden.*/

            /*Klassendiagramm:
             * 
             * Socke
             * -------------------
             * - Farbe: string
             * - Trocken: bool
             * - Sauber: bool
             * -------------------
             * + Trockne(): void
             * + Wasche(): void
             * + Ausgabe(): void
             * + SetFarbe(farbe: string): void
             */

            /*Socke meineSocke = new Socke();
            meineSocke.SetFarbe("Rot");
            meineSocke.Wasche();
            meineSocke.Trockne();
            meineSocke.Ausgabe();*/

            /*Socke meineneuesocke = new Socke();
             meineneuesocke.Trocken = true; <- geht nicht wegen private einstellung
            -----------------------------------------------------------------------*/

            /*Aufgabe 2
             * 
            Definieren Sie eine Klasse Mensch.Ein Mensch hat einen Namen und ein Alter.Ein Mensch
            kann sich mit seinem Namen und Alter vorstellen.Und einmal im Jahr hat er Geburtstag
            (erhöht das Alter um eins). Implementieren Sie die entsprechenden Variablen und Methoden
            (Vorstellen() und Geburtstag()).Erzeugen Sie dann mindestens ein Objekt vom Typ Mensch, an
            dem Sie die Funktionalität des Programms testen, d.h.die Methoden einmal aufrufen.*/

            /*Klassendiagramm:
             * 
             * Mensch
             * -------------------
             * - name : string
             * - alter : int 
             * -------------------
             * + vorstellen(): void
             * + gebursttag(): void
             * + SetAlter():   void
             * + SetName():    void
             * */

            /*Mensch Sano = new Mensch();
            Sano.SetAlter(33);
            Sano.SetName("Manjiro Sano");
            Sano.vorstellen();
            Sano.Geburtstag();
            Mensch sasuke = new Mensch("Uchiha Sasuke", 33);
            sasuke.vorstellen();
            sasuke.Geburtstag();*/

            //----------------------------------------------------------------------------



        }
    }
}
class Socke
{
    string Farbe;
    bool Trocken;
    bool Sauber;

    public void Trockne()
    {
        Trocken = true;
    }
    public void Wasche()
    {
        Sauber = true;
        Trocken = false;
    }
    public void Ausgabe()
    {
        string trockenStatus = Trocken ? "trocken" : "nicht trocken";
        string sauberStatus = Sauber ? "sauber" : "nicht sauber";

        Console.WriteLine($"Die Socke mit der Farbe {Farbe} ist {sauberStatus} und {trockenStatus}.");
    }
    public void SetFarbe(string farbe)
    {
        Farbe = farbe;
    }
}
class Mensch
{
    string Name;
    int Alter;

    public Mensch(string name, int alter)   // ← der Konstruktor
    {
        Name = name;
        Alter = alter;
    }

    public void vorstellen()
    {
        Console.WriteLine($"Hallo mein Name ist {Name} und ich bin {Alter} Jahre alt");
    }

    public void Geburtstag()
    {
        Alter = Alter + 1;
    }

    public void SetAlter(int alter)
    {
        Alter = alter;
    }

    public void SetName(string name)
    {
        Name = name;
    }
}



