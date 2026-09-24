using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Aufgaben_Dateien
    {
        static void Main(string[] args)
        {   //1.
            //File.WriteAllText("pfad.txt", "Manjiro Sano");
            //File.WriteAllText("pfad.text", "Kyojuro Rengoku");
            //File.WriteAllText("pfad.txt", "Kyotaka Ayanokoji");
            //File.WriteAllText("pfad.text", "Subaru Natski");
            //File.WriteAllText("pfad.t", "Satoru Gojo");
            //File.WriteAllText("pfad.txt", "Satoru Gojo");

            //2.
            //Console.WriteLine("Dateiname eingeben:");
            //string dateiname = Console.ReadLine();
            ////C: \Users\ita2 - tn22\source\repos\Einstieg1\bin\Debug\pfad.txt
            //string inhalt = File.ReadAllText(dateiname);
            //Console.WriteLine(inhalt);

            //3.
            //FileStream -> Klasse || fs -> Objekt
            //FileStream fs = new FileStream(@"pfad_zur_datei\primzahlen.txt", FileMode.Create);
            //StreamWriter schreiben = new StreamWriter(fs);

            //for (int zahl = 2; zahl <= 1000; zahl++)
            //{
            //    bool primzahl = true;

            //    for (int i = 2; i < zahl; i++)
            //    {
            //        if (zahl % i == 0)
            //        {
            //            primzahl = false;
            //            break;
            //        }
            //    }

            //    if (primzahl)
            //    {
            //        schreiben.WriteLine(zahl);
            //    }
            //}

            //schreiben.Close();
            //fs.Close();

            //4.

            //Console.WriteLine("Text eingeben:");
            //string text = Console.ReadLine();
            //Random rnd = new Random();
            //string verschluesselt = "";

            //foreach (char c in text)
            //{
            //    verschluesselt += c;
            //    verschluesselt += (char)rnd.Next(33, 127);
            //    verschluesselt += (char)rnd.Next(33, 127);
            //}
            //File.WriteAllText("verschluesselt.txt", verschluesselt);

            //Zusatz.
            //Console.WriteLine("Bitte Text eingeben");
            //string text = Console.ReadLine();
            //int zähler = 0;
            //string buchstabe = "";

            //foreach (char c in text)
            //{
            //    char klein = char.ToLower(c);

            //    if (klein == 'a' || klein == 'e' || klein == 'i' || klein == 'o' || klein == 'u')
            //    {
            //        zähler++;
            //        buchstabe += klein;
            //    }

            //    char groß = char.ToUpper(c);

            //    if (groß == 'a' || groß == 'e' || groß == 'i' || groß == 'o' || groß == 'u')
            //    {
            //        zähler++;
            //        buchstabe += groß;
            //    }
                
            //}
            //Console.WriteLine($"Text: {text} || Anzahl_Vokale: {zähler} ({buchstabe})");



        }
    }
}
