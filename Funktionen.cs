using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Funktionen
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            Aufgabe11();
            //Aufgabe12();
        }

        static void Aufgabe1()
        {
            //Erstellen Sie ein kleines Programm, welches vom Anwender zwei ganze Zahlen abfragt und dann 
            //ermittelt, welche der beiden Zahlen die größere Zahl ist und welche die kleinere Zahl ist. 
            //Erstellen Sie dazu in Ihrem Programm zunächst zwei Funktionen mit den Namen Min und Max:
            //Verwenden Sie diese Funktionen, um festzustellen welche der beiden Zahlen die größere bzw. die
            //kleinere Zahl ist. 


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
            //Schreiben Sie ein Programm mit einer Funktion „Hallo()“. Diese Funktion soll auf der Konsole „Hallo 
            //Welt“ ausgeben.Die Funktion hat keine Übergabeparameter und keinen Rückgabewert. Rufen Sie
            //aus dem „Hauptprogramm“ diese Methode auf.

            //Pseudocode:

            //1. in Main: ich brauche eine Funktion ohne Rückgabewert
            //2.Funktion erstellen - static void Hallo()
            //. { Console.WriteLine("Hallo Welt") }
            //3. In Main aufrufen: Hallo();
            Hallo("Tolga");

        }

        static void Hallo( string name)
        {

            Console.WriteLine($"Hallo! {name}");
        }




    }   
        

        

}

