using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Abstrakte_Klassen
    {
        static void Main(string[] args)
        {

            //Hund Appa = new Hund();
            //Appa.MachGeräusch();
            //Console.WriteLine();
            //hund Bello = new hund();
            //Bello.Name = "Bello";
            //Bello.Rasse();
            //Bello.Sprechen();
            //Console.WriteLine();
            //katze Mautzi = new katze();
            //Mautzi.Name = "Mautzi";
            //Mautzi.Rasse();
            //Mautzi.Sprechen();
            //Console.WriteLine();
            //kuh Paula = new kuh();
            //Paula.Name = "Paula";
            //Paula.Rasse();
            //Paula.Sprechen();
            //Kreis rund = new Kreis();
            //rund.BerechneFläche();
            //rund.BerechneUmfang();
            //rund.Ausgabe();
            //Console.WriteLine();
            //Rechteck ecki = new Rechteck();
            //ecki.BerechneFläche();
            //ecki.BerechneUmfang();
            //ecki.Ausgabe();
            //Console.WriteLine();
            //Quadrat quadi = new Quadrat();
            //quadi.BerechneFläche();
            //quadi.BerechneUmfang();
            //quadi.Ausgabe();

        }  
        
    }
    abstract class Tier 

    {
        public abstract void MachGeräusch(); //ein Vertrag der jede abgeleitete Klasse-
        //zwingt eine eigene methode zu implementieren
    }
    class Hund : Tier
    {
        public override void MachGeräusch()
        {
            Console.WriteLine("Wuff!");
        }
    }
    /*  Aufgabe 1:
        Implementieren Sie die abstrakte Basisklasse Tier und leiten Sie von dieser die Klassen Hund,
        Katze und Kuh ab.Jedes Tier hat einen Namen.Legen Sie die abstrakten Methoden zur
        Ausgabe der Rasse (z.B. "Ich bin ein Hund") und zum "Sprechen" (z.B. "Muuuh") an.*/

    /*Klassendiagramm:
     * 
     * abstract Tier:
     * --------------
     * + Namen : string {get; set;}
     * --------------
     * + Ausgabe Rasse : abstract void()
     * + Sprechen : abstract void()
     * --------------
     * Hund : Tier
     * --------------
     * + Ausgabe Rasse : public override void()
     * + Sprechen : public override void()
     * --------------
     *  Katze : Tier
     * --------------
     * + Ausgabe Rasse : public override void()
     * + Sprechen : public override void()
     * --------------
     * Kuh : Tier
     * --------------
     * + Ausgabe Rasse : public override void()
     * + Sprechen : public override void()
     */


    abstract class tier
    {
        public string Name { get; set; }

        public abstract void Rasse();
        public abstract void Sprechen();

    }

    class hund : tier
    {
        public override void Rasse()
        {
            Console.WriteLine("Ich bin die Rasse Hund");
        }
        public override void Sprechen()
        {
            Console.WriteLine("Wuff!");
        }
    }
    class katze : tier
    {
        public override void Rasse()
        {
            Console.WriteLine("Ich bin die Rasse Katze");
        }
        public override void Sprechen()
        {
            Console.WriteLine("Miau!");
        }
    }
    class kuh : tier
    {
        public override void Rasse()
        {
            Console.WriteLine("Ich bin die Rasse Kuh");
        }
        public override void Sprechen()
        {
            Console.WriteLine("Muhh!");
        }
    }


    /*  Aufgabe 2: 
        Implementieren Sie die abstrakte Basisklasse GeometrieObjekt und leiten Sie von dieser die
        Klassen Kreis, Quadrat und Rechteck ab.Die Klassen haben die Aufgabe die Fläche und den
        Umfang des Objektes zu berechnen.Legen Sie dazu die abstrakten Methoden
        BerechneFläche() und BerechneUmfang() an.Legen Sie zudem die Methode Ausgabe() an, 
        welche jeweils die berechnete Fläche und den Umfang auf der Konsole ausgibt.*/

    /* Klassendiagramm:
     * 
     * abstract GeometrieObjekt:
     * -------------------------
     * + BerechneFläche : abstract void()
     * + BerechneUmfang : abstract void()
     * -------------------------
     * class Kreis: GeometrieObjekt
     * -------------------------
     * + BerechneFläche() : public override void()
     * + BerechneUmfang() : public override void()
     * + Ausgabe() : public void
     * -------------------------
     * class Quadrat: GeometrieObjekt
     * -------------------------
     * + BerechneFläche() : public override void()
     * + BerechneUmfang() : public override void()
     * + Ausgabe() : public void
     * -------------------------
     * class Rechteck: GeometrieObjekt
     * -------------------------
     * + BerechneFläche() : public override void()
     * + BerechneUmfang() : public override void()
     * + Ausgabe() : public void
     * -------------------------*/

    abstract class GeometrieObjekt
    {
        public abstract void BerechneFläche();
        public abstract void BerechneUmfang();
    }
    class Kreis : GeometrieObjekt
    {
        double Durchmesser;
        double Fläche;
        double Umfang;
        public override void BerechneFläche()
        {
            Console.WriteLine("Durchmesser in cm angeben");
            double d = double.Parse(Console.ReadLine());
            Durchmesser = d;
            double r = d / 2;
            double a = Math.PI * r * r;
            Fläche = a;
            
        }
        public override void BerechneUmfang()
        {

            double d = Durchmesser;
            double u = Math.PI * d;
            Umfang = u;
        }
        public void Ausgabe()
        {
            Console.WriteLine($"Die berechnete Fläche vom Kreis beträgt {Math.Round(Fläche,2)}cm2" +
                $"\nDer berechnete Umfang vom Kreis beträgt {Math.Round(Umfang,2)}cm");
        }
    }
    class Quadrat : GeometrieObjekt
    {
        double Seitenlänge;
        double Fläche;
        double Umfang;

        public override void BerechneFläche()
        {
            Console.WriteLine("Länge A in cm angeben");
            double a = double.Parse(Console.ReadLine());

            Seitenlänge = a;
            Fläche = a * a;

        }
        public override void BerechneUmfang()
        {

            Umfang = 4 * Seitenlänge;
        }
        public void Ausgabe()
        {
            Console.WriteLine($"Die berechnete Fläche vom Quadrat beträgt {Fläche}cm2" +
                $"\nDer berechnete Umfang vom Quadrat beträgt {Umfang}cm");
        }
    }
    class Rechteck : GeometrieObjekt
    {
        double Länge_A;
        double Länge_B;
        double Fläche;
        double Umfang;

        public override void BerechneFläche()
        {
            Console.WriteLine("Länge A in cm angeben");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Länge B in cm angeben");
            double b = double.Parse(Console.ReadLine());
            Länge_A = a;
            Länge_B = b;
            double A = a * b;
            
            Fläche = A;

        }
        public override void BerechneUmfang()
        {
            double a = Länge_A;
            double b = Länge_B;
            double u = 2 * (a + b);
            
            Umfang = u;
        }
        public void Ausgabe()
        {
            Console.WriteLine($"Die berechnete Fläche vom Rechteck beträgt {Fläche}cm2" +
                $"\nDer berechnete Umfang vom Rechteck beträgt {Umfang}cm");
        }
    }

}
