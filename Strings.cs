using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Einstieg1
{
    internal class Strings
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            //Aufgabe14();
            //Aufgabe24();
            Aufgabe25();
        }

        static void Aufgabe11()
        {
            //Schreiben Sie ein Programm mit den Variablen „vorname“ und „nachname“ jeweils vom Typ „string“. 
            //Initialisieren Sie diese beiden Variablen mit Ihrem Vor-und Nachnamen.Erzeugen Sie eine weitere
            //Variable „name“. Der Inhalt dieser Variablen soll die Kombination aus der Variablen vorname und der
            //Variablen nachname sein. Geben Sie den Inhalt dieser Variablen aus.
            //Erweitern Sie das Programm anschließend so, dass es die Länge des  kompletten Namens ausgibt.
           

            string nachname = "Müller";
            string vorname = "Max";
            string name = nachname + " " + vorname;
            Console.WriteLine($"{name}\n" + name.Length + " " + "Zeichen");
            
        }


        static void Aufgabe14()
        {
            //Schreiben Sie ein Programm, das den Benutzer nach einem Kennwort fragt. Dieses Kennwort soll
            //sicher sein.Zunächst bezeichnen wir ein Kennwort als sicher, wenn es mindestens 10 Zeichen
            //beinhaltet.Schreiben Sie eine Funktion, die überprüft, ob das Kennwort diese Anforderung erfüllt. Im
            //Hauptprogramm soll dieses Ergebnis ausgewertet werden.Falls es nicht sicher ist, teilen Sie dem
            //Benutzer mit, wie viele Zeichen fehlen.



            Console.WriteLine("Geben Sie ein Kennwort ein:" +
                "\nMindestens 10 Zeichen lang:" +
                "\nMindestens 1 Großbuchstabe:" +
                "\nMindestens 1 Kleinbuchstabe:" +
                "\nMindestens 1 Sonderzeichen:");

            string eingabe = Console.ReadLine();

            bool sicher = IstSicher(eingabe);
            

            if (sicher)
            {
                Console.WriteLine("Das Kennwort ist sicher.");
            }
            else
            {
                
                Console.WriteLine($"Das Kennwort ist nicht sicher.");
            }



        }
        static bool IstSicher(string kennwort)
        {
            bool hatGross = false;
            bool hatKlein = false;
            bool hatZiffer = false;
            bool hatSonderzeichen = false;

            foreach (char c in kennwort)
            {
                if (char.IsUpper(c))
                    hatGross = true;
                else if (char.IsLower(c))
                    hatKlein = true;
                else if (char.IsDigit(c))
                    hatZiffer = true;
                else
                    hatSonderzeichen = true;
            }

            return kennwort.Length >= 10 &&
                   hatGross &&
                   hatKlein &&
                   hatZiffer &&
                   hatSonderzeichen;
        }

        static void Aufgabe24()
        {
            //Schreiben Sie ein Programm, das eine positive Ganzzahl als binäre Ziffernfolge darstellt.
            //Die Ganzzahl wird dezimal von der Tastatur eingelesen. Die entsprechende binäre
            //Ziffernfolge ist in einem String zu speichern, der an der Konsole ausgegeben wird.
            //Hinweis: Zur Konvertierung verwenden Sie die Modulo Division durch 2 und
            //anschließend die Ganzzahldivision durch 2.

            Console.WriteLine("Geben Sie eine Ganzzahl ein");
            int eingabe = int.Parse(Console.ReadLine());

            string binaer = "";
            int zahl = eingabe;
            while(zahl > 0)
            {
                int rest = zahl % 2;
                binaer = rest + binaer;
                zahl = zahl / 2;
            }
            Console.WriteLine("Binärdarstellung: " + binaer);


        }
        static void Aufgabe25()
        {
            Console.Write("Geben Sie einen Text ein: ");
            string text = Console.ReadLine();

            Console.WriteLine("ASCII-Codes:");

            foreach (char zeichen in text)
            {
                Console.WriteLine($"{zeichen} -> {(int)zeichen}");
            }
        }




    }   

}
