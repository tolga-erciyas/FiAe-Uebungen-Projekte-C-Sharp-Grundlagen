using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Boxer
    {
        static void Main(string[] args)
        {
            /* Aufgabe Boxer:
             * Definieren Sie die Klasse Boxer mit dem Attribut name und vitalität sowie der Methode 
                Schlagen(). Der Parameter eines Schlages ist ein (anderer) Boxer, dessen Vitalität bei einem 
                Treffer sinkt. Die Trefferwahrscheinlichkeit beträgt 50% . Instanziieren Sie anschließend zwei 
                Boxer und lassen Sie die beiden so lange aufeinander schlagen, bis einer mit seiner Vitalität 
                im negativen Bereich – also k.o. – ist.*/

            /* Klassendiagramm:
             * Boxer:
             * ----------------
             * + Name: string
             * + Vitalität: int 
             * ----------------
             * + Schlagen(anderer Boxer): void
             */

            boxer Rocky = new boxer();
            Rocky.Name = "Rocky";
            Rocky.Vitalität = 100;    

            boxer Drago = new boxer();
            Drago.Name = "Drago";
            Drago.Vitalität = 100;

            bool nochfit = true;
            while (nochfit)
            {   
                
                Rocky.schlagen(Drago);
                if (Drago.Vitalität > 0)
                Drago.schlagen(Rocky);

                if (Rocky.Vitalität < 0 || Drago.Vitalität < 0)   
                {
                    nochfit = false;                                 
                }
            }
        }
    }
    class boxer
    {
        public string Name;
        public int Vitalität;
         
        public void schlagen(boxer gegner)
        {
            Random random = new Random();
            
            
            
                int schlag = random.Next(0, 2);
                if (schlag == 1)
                {
                    gegner.Vitalität = gegner.Vitalität - 10;
                }
                if (gegner.Vitalität < 0)
                {
                    Console.WriteLine($"{gegner.Name} ist K.O");
                }
            

        }


    }
}
