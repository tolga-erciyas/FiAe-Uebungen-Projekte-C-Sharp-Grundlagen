using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class BruchRechner
    {
        static void Main(string[] args)
        {
            Bruch bruch1 = new Bruch(4,12);
            Bruch bruch2 = new Bruch(2, 10);

            bruch1.Addiere(bruch2);
            bruch1.Subtrahiere(bruch2);
            bruch1.Dividiere(bruch2);
            bruch1.Multipliziere(bruch2);
        }
    }
    class Bruch
    {
        int Zähler;
        int Nenner;

        public Bruch(int zähler)
        {
            Zähler = zähler;
            Nenner = 1;
        }
        public Bruch(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"{Zähler} / {Nenner}");
        }
        public void Kehrwert()
        {
            Console.WriteLine($"{Nenner} / {Zähler}");
        }
        public void Kürzen()
        {
            int größteZahl = 0;
            if (Zähler > Nenner)
            {
                größteZahl = Zähler;
            }
            else
                größteZahl = Nenner;
            for( int i = größteZahl; i >= 1; i--)
            {
                if(Zähler % i == 0 && Nenner % i == 0)
                {
                    Zähler = Zähler / i;
                    Nenner = Nenner / i;
                    break;
                }
                
            }
            Console.WriteLine($"{Zähler} / {Nenner}"); 
        }
        public Bruch Addiere(Bruch bruch)
        {
            int neuerZähler = Zähler * bruch.Nenner + bruch.Zähler * Nenner;
            int neuerNenner = Nenner * bruch.Nenner;

            Bruch ergebnis = new Bruch(neuerZähler, neuerNenner);
            ergebnis.Kürzen();

            return ergebnis;
        }
        public Bruch Subtrahiere(Bruch bruch)
        {
            int neuerZähler = Zähler * bruch.Nenner - bruch.Zähler * Nenner;
            int neuerNenner = Nenner * bruch.Nenner;

            Bruch ergebnis = new Bruch(neuerZähler, neuerNenner);
            ergebnis.Kürzen();

            return ergebnis;
        }

        public Bruch Multipliziere(Bruch bruch)
        {
            int neuerZähler = Zähler * bruch.Zähler;
            int neuerNenner = Nenner * bruch.Nenner;

            Bruch ergebnis = new Bruch(neuerZähler, neuerNenner);
            ergebnis.Kürzen();

            return ergebnis;
        }

        public Bruch Dividiere(Bruch bruch)
        {
            int neuerZähler = Zähler * bruch.Nenner;
            int neuerNenner = Nenner * bruch.Zähler;

            Bruch ergebnis = new Bruch(neuerZähler, neuerNenner);
            ergebnis.Kürzen();

            return ergebnis;
        }

    }
}
