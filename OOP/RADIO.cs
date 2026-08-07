using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class RADIO
    {
        static void Main(string[] args)
        {
            /* Klassendiagramm:
             * 
             * Radio:
             * 
             * - eingeschaltet : bool
             * - lautsärke : int 
             * - frequenz : double
             * --------------------------
             * + lauter(): void
             * + leiser(): void 
             * + einschalten(): void 
             * + ausschalten(): void
             * + ist an(): bool
             * + wähleSender(neueFrequenz: double): void
             * + GetRadioInfo(): string
             * */

            Radio meinRadio = new Radio();
            
            meinRadio.Ausschalten();
            meinRadio.Einschalten();
            meinRadio.Ausschalten();
            meinRadio.WähleSender(267.55);
            meinRadio.Lauter();
            meinRadio.Leiser();
            meinRadio.Leiser();
            

            Console.WriteLine(meinRadio.GetRadioInfo());
           

        }
    }
    class Radio
    {
        bool eingeschaltet = false;
        int lautstärke = 50;
        double frequenz = 0.00;

        public void Lauter()
        {

            if (lautstärke < 100)
            {
                lautstärke += 1;
            }
        }
        public void Leiser()
        {
            if (lautstärke > 0)
            {
                lautstärke -= 1;
            }
        }
        public void Einschalten()
        {
            if (!eingeschaltet)
            {
                eingeschaltet = true;
            }
            Console.WriteLine("Radio an");
        }
        public void Ausschalten()
        {
            if (eingeschaltet)
            {
                eingeschaltet = false;
            }
            Console.WriteLine("Radio aus");
        }
        public bool IstAn()
        {
            return eingeschaltet;

        }
        public double WähleSender(double NeueFrequenz)
        {
            frequenz = NeueFrequenz;
            return NeueFrequenz;
            
        }
        
        public string GetRadioInfo()
        {
            string status = eingeschaltet ? "Radio an" : "Radio aus";
            return $"{status}: Frequenz = {frequenz}, Lautstärke = {lautstärke}";     
        }

    }



}
