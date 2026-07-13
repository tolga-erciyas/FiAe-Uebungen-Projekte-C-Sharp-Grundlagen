using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Einstieg1
{
    internal class Filiale_
    {
        static void Main(string[] args)
        {
            /*Erstellen Sie zuerst ein Klassendiagramm für die Aufgabe!
            Definieren Sie eine Klasse Filiale. Eine Filiale hat einen Namen, einen Warenbestand sowie
            eine Kasse.Die Klasse soll eine Methode besitzen, welche alle Informationen zu einer Filiale
            auf der Konsole ausgibt. 
            Zudem sollen zwei Methoden zum Einkauf und zum Verkauf existieren.  
            Beim Einkauf wird Geld aus der Kasse entfernt(10) und der Warenbestand um eins erhöht. 
            Der Einkauf soll nur möglich sein, wenn noch genug Geld in der Kasse ist.
            Beim Verkauf wird Geld zur Kasse hinzugefügt(20) und der Warenbestand um eins
            verringert.Der Verkauf soll nur möglich sein, wenn noch Waren vorhanden sind. 
            Legen Sie mindestens ein Filiale - Objekt an und testen Sie alle Methoden.*/

            /*Klassendiagramm:
             * ---------------
             ** Klasse: Filiale
             * ---------------
             ** Attribute:  
             * - Namen:        string 
             * - Warenbestand: int
             * - Kasse:        int 
             * ---------------
             ** Methode:
             * + Filiale(name : string, warenbestand : int, kasse : int)
             * + Info():          void
             * + Einkauf():       void
             * + Verkauf():       void*/

            Filiale Sano = new Filiale("Sano", 1000, 1000);
            
            Sano.Einkauf();
            Sano.Einkauf();
            Sano.Einkauf();
            Sano.Einkauf();
            Sano.Verkauf();
            Sano.Verkauf();
            Sano.Info();

        }

            class Filiale

        {
            private string name;
            private int warenbestand;
            private int kasse;

            public Filiale(string name, int lagerbestand, int kasse)
            {
                this.name = name;
                this.warenbestand = lagerbestand;
                this.kasse = kasse;
            }

            public void Info()
            {
                Console.WriteLine(name);
                Console.WriteLine(warenbestand);
                Console.WriteLine(kasse);

            }
            public void Einkauf()
            {
                if (kasse >= 10)
                {
                    kasse = kasse - 10;
                    warenbestand = warenbestand + 1;
                }
            }
            public void Verkauf()
            {
                if (warenbestand >= 1)
                {
                    kasse = kasse + 20;
                    warenbestand = warenbestand - 1;
                }


            }
        
        }
    }



}            
           

 
            

        
    

