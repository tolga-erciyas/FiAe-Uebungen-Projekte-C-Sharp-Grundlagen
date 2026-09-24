using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class SparSchwein1
    {
        static void Main(string[] args)
        {
            /* Klassendiagramm
             * 
             * PiggyBank1
             * --------------------------
             * - Anzahl1Cent:          int
             * - Anzahl5Cent:          int
             * - Anzahl10Cent:         int
             * - Anzahl20Cent:         int
             * - Anzahl50Cent:         int
             * - Anzahl100Cent:        int 
             * - Anzahl200Cent:        int 
             * - MaximaleAnzahlMünzen: int
             * - ZustandSparschwein:   bool
             *---------------------------
             * + PiggyBank1
             * 
             * + Add1Cents():   int
             * + Add5Cents():   int
             * + Add10Cents():  int
             * + Add20Cents():  int
             * + Add50Cents():  int
             * + Add100Cents(): int
             * + Add200Cents(): int
             * + Shake():       void
             * + isbroken():    bool
             * + breakInto():   int
             */

            PiggyBank1 Sparschwein = new PiggyBank1(10);
            Sparschwein.shake();
            Sparschwein.Add50cents(20);
            Sparschwein.shake();
            Sparschwein.BreakInto();
        }
    }
    class PiggyBank1
    {
        int _Anzahl1Cent;
        int _Anzahl5Cent;
        int _Anzahl10Cent;
        int _Anzahl20Cent;
        int _Anzahl50Cent;
        int _Anzahl100Cent;
        int _Anzahl200Cent;
        int _MaximaleAnzahlMünzen;
        bool _ZustandSparschwein;

        public PiggyBank1(int MaximaleAnzahlMünzen)
        {
            _MaximaleAnzahlMünzen = MaximaleAnzahlMünzen;
        }

        public int Add1cents(int Anzahl1Cent)
        {
            _Anzahl1Cent = Anzahl1Cent;
            return Anzahl1Cent;
        }
        public int Add5cents(int Anzahl5Cent)
        {
            _Anzahl5Cent = Anzahl5Cent;
            return Anzahl5Cent;
        }
        public int Add10cents(int Anzahl10Cent)
        {
            _Anzahl10Cent = Anzahl10Cent;
            return Anzahl10Cent;
            _MaximaleAnzahlMünzen = _MaximaleAnzahlMünzen + 1;
        }
        public int Add20cents(int Anzahl20Cent)
        {
            _Anzahl20Cent = Anzahl20Cent;
            return Anzahl20Cent;
            _MaximaleAnzahlMünzen = _MaximaleAnzahlMünzen + 1;
        }
        public int Add50cents(int Anzahl50Cent)
        {
            _Anzahl50Cent = Anzahl50Cent;
            return Anzahl50Cent;
            _MaximaleAnzahlMünzen = _MaximaleAnzahlMünzen + 1;
        }
        public int Add100cents(int Anzahl100Cent)
        {
            
            _Anzahl100Cent = Anzahl100Cent;
            return Anzahl100Cent;
            _MaximaleAnzahlMünzen = _MaximaleAnzahlMünzen + 1;
        }
        public int Add200cents(int Anzahl200Cent)
        {
            _Anzahl200Cent = Anzahl200Cent;
            return Anzahl200Cent;
            _MaximaleAnzahlMünzen = _MaximaleAnzahlMünzen + 1;
        }

        public void shake()
        {
            if(_MaximaleAnzahlMünzen == 0)
            {
                Console.WriteLine("Leer");
            }
            else if (_MaximaleAnzahlMünzen < 25)
            {
                Console.WriteLine("etwa ein Drittel voll");
            }
            else if (_MaximaleAnzahlMünzen == 25)
            {
                Console.WriteLine("etwa halb voll");
            }
            else if (_MaximaleAnzahlMünzen > 25 && _MaximaleAnzahlMünzen <= 49)
            {
                Console.WriteLine("etwa zwei Drittel voll");
            }
            else if (_MaximaleAnzahlMünzen == 50)
            {
                Console.WriteLine("Voll");
            }

        }
        public bool isBroken()
        {
            if (_ZustandSparschwein)
            {
                return _ZustandSparschwein == true;
            }
            else
            {
                return _ZustandSparschwein == false;
            }
        }
        public int BreakInto()
        {
            _ZustandSparschwein = true;
            return _MaximaleAnzahlMünzen;
            Console.WriteLine($"so viele Münzen sind drin {_MaximaleAnzahlMünzen}");
            _MaximaleAnzahlMünzen = 0;

        }



    }
}
