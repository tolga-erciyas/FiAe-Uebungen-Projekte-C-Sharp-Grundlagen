using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Klassen_und_Objekte
    {
        static void Main(string[] args)
        {
            Auto meinKiaPicanto = new Auto();
            meinKiaPicanto.Marke = "Kia";
            meinKiaPicanto.Modell = "Picanto";
            meinKiaPicanto.Farbe = "Schwarz";
            
            Auto meinVW = new Auto();
            meinVW.Marke = "Vw";
            meinVW.Modell = "GTI";
            meinVW.Farbe = "Schwarz";

            Sportwagen meinPorsche = new Sportwagen();
            meinPorsche.Marke = "Porsche";
            meinPorsche.Modell = "GT";
            meinPorsche.Farbe = "Schwarz";
            meinPorsche.Performance = "Stage 1";




            //meinKiaPicanto.steckbrief();
            //meinVW.steckbrief();
            meinPorsche.steckbrief();

        }
    }

    class Auto
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public string Farbe { get; set; }

        public void fahren() { Console.WriteLine("Das Auto fährt"); }
        public void bremsen() { Console.WriteLine("Das Auto bremmst"); }





        public virtual void steckbrief()
        {
            Console.WriteLine("Marke: " + Marke + " Modell: " + Modell);
        }

  
    
    
    
    
    
    }
    class Sportwagen : Auto
    {
        public string Performance;
        public override void steckbrief()
        {
            base.steckbrief();
            Console.WriteLine("Performance: " + Performance);
        }

    }


















}


