using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Security.Policy;
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
            //Aufgabe12();
            //Aufgabe13();
            //Aufgabe14();
            //Aufgabe15();


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

        static void Aufgabe13()
        {
            //Schreiben Sie ein Programm mit einer Funktion, die eine ganze Zahl entgegennimmt und prüft, ob die
            //Zahl gerade ist.Testen Sie diese Funktion.
            Console.WriteLine("Gib eine Zahl ein");
            int zahl = ReadInt();
            gerade(zahl);
            
            

        }



        static void gerade(int zahl)
        {
            if(zahl % 2 == 0)
            {
                Console.WriteLine("ist gerade");
            }
            else
                Console.WriteLine("ist nicht gerade");
        }

        static void Aufgabe14()
        {
            //Schreiben Sie ein Programm mit einer Funktion, die zwei ganze Zahlen entgegennimmt und
            //vertauscht.Überlegen Sie genau, ob die Funktion etwas zurückgeben muss und welchem Typ dies
            //ggfs.Ist.Beachten Sie auch, wie die beiden Zahlen an die Funktion übergeben werden müssen.



            int s1 = ReadInt();
            int s2 = ReadInt();

            int[] ergebnis = Tauschen(s1, s2);

            Console.WriteLine($"{ergebnis[0]} {ergebnis[1]}");




        }

        static int[] Tauschen(int s1, int s2)
        {
            return new int[] { s2, s1 };
        }

        static void Aufgabe15()
        {
            //Schreiben Sie ein Programm, das das folgende Menü darstellt: 
            //Bitte wählen Sie die gewünschte Funktion
            //========================================= 
            //S -> Summe berechnen 
            //F -> Fakultät berechnen 
            //G -> Größten gemeinsamen Teiler berechnen 
            //M -> Meilen berechnen 
            //E -> Programm beenden 

            //Ihre Wahl: 

            //Nach der Eingabe eines Buchstabens wird eine Funktion aufgerufen, die die entsprechende
            //Berechnung durchführt.Das Menü selbst soll auch mit Hilfe einer Funktion angezeigt
            //werden.

            Menü();
            
        }

        static void Menü()
        {
            Console.WriteLine("Bitte wählen Sie die gewünschte Funktion" +
                "\n=========================================" +
                "\nS -> Summe berechnen " +
                "\nF -> Fakultät berechnen " +
                "\nG -> Größten gemeinsamen Teiler berechnen " +
                "\nM -> Meilen berechnen" +
                "\nE -> Programm beenden ");
            Console.WriteLine();

            string eingabe = Console.ReadLine();
            if (eingabe.ToUpper() == "S")
            {
                Console.WriteLine("Geben Sie die beiden Zahlen ein");
                int a = ReadInt();
                int b = ReadInt();
                Console.WriteLine($"Die Summe ist {Summe(a, b)}");

            }

            else if (eingabe.ToUpper() == "F")
            {
                Console.WriteLine("Geben Sie eine Zahl ein");
                double z = ReadInt();
                Console.WriteLine($"Die Fakultät lautet {Fakultät(z)}");

            }
                
            else if (eingabe.ToUpper() == "G")
            {
                Console.WriteLine("Geben Sie zwei Zahlen ein");
                int a = ReadInt();
                int b = ReadInt();

                int ergebnis = GrößterTeiler(a, b);
                Console.WriteLine($"Der Größte gemeinsame Teiler ist {ergebnis}");

            }
                
            else if (eingabe.ToUpper() == "M")
            {
                Console.WriteLine("Geben Sie die Entfernung in Km an");
                double km = ReadDouble();
                Console.WriteLine(Meilen(km));
            }
            else if (eingabe.ToUpper() == "E")
                return;
            else
                Console.WriteLine("Ungültige Eingabe");
        }
        static int Summe(int a, int b)
        {
            return a + b;
        }
        static double Fakultät(double z)
        {
             int ergebnis = 1;
            for (int i = 1; i <= z; i++)
                //ergebnis *= i;
                ergebnis = ergebnis * i;
            return ergebnis;
            
        }
        static int GrößterTeiler(int a, int b)
        {
            while (b != 0)
            {
                int rest = a % b;
                a = b;
                b = rest;
            }

            return a;

        }







    }




}

