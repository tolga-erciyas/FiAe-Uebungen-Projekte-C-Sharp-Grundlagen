using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Funktionen
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe11();
            Aufgabe12();
        }

        static void Aufgabe1()
        {
            Console.WriteLine("Gebe 2 Zahlen ein:");
            int a = ReadInt();
            int b = ReadInt();

            int kleinere = Min(a, b);
            int größere = Max(a, b);

            Console.WriteLine("Min: " + kleinere);
            Console.WriteLine("Max: " + größere);

            Console.ReadLine(); // damit das Fenster offen bleibt
        }

        static int Min(int a, int b)
        {
            if (a <= b)
                return a;
            else
                return b;
        }

        static int Max(int a, int b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }

        static int ReadInt()
        {
            int zahl = int.Parse(Console.ReadLine());
            return zahl;
        }

        static void Aufgabe12()
        {
            //Schreiben Sie ein Programm, dass eine Entfernung in Kilometer vom Benutzer entgegennimmt. 
            //Schreiben Sie dann eine Funktion, die den Kilometerwert entgegennimmt und in Meilen umrechnet. 
            //Dieser Wert soll auf der Konsole ausgegeben werden. Eine Meile entspricht 1,609344 km.
            //Ändern Sie anschließend diese Funktion so, dass der Wert in Meilen nicht mehr ausgegeben sondern
            //an den „Aufrufer“ zurückgegeben wird. 

            //Pseudecode:
            //1.Hauptprogramm
            //.Ausgabe:"Entfernung in Km angeben"
            //.km = ReadDouble()
            //.Meilen(km)
            //2.Funktion static double Readdouble erstellen für die eingabe
            //. static double ReadDouble()
            //. { double zahl = double.Parse(Console.ReadLine());
            //. return zahl;}
            //3.Funktion static void Meilen erstellen für die umrechnung in meilen
            //. static void Meilen( double km)
            //. {double meilen = km / 1.609344
            //. Ausgabe:($"Die Entfernung beträgt {meilen} Meilen ")}

            //.Ändern Sie anschließend diese Funktion so, dass der Wert in Meilen nicht mehr ausgegeben sondern 
            // an den „Aufrufer“ zurückgegeben wird. 


            Console.WriteLine("Entfernung in Km angeben");
            double km = ReadDouble();
            Console.WriteLine(Meilen(km)); 
            
            
        }

        static double ReadDouble()
        {
            double zahl = double.Parse(Console.ReadLine());
            return zahl;
          
        }
        static double Meilen(double km)
        {
            double meilen = km / 1.609344;
            //Console.WriteLine($"Die Entfernung beträgt {meilen} Meilen");
            return meilen;
        }

        static void Aufgabe11()
        {

        }





    }   
        

        

}

