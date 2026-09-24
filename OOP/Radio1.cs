using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1.OOP
{
    internal class Radio1
    {
        static void Main(string[] args)
        {
            /*Klassendiagramm
             * 
             * Radio
             * -------------
             * - Eingeschaltet: bool
             * - Lautstärke:    bool
             * -------------
             * + Lauter():      void
             * + Leiser():      void
             * + An():          void
             * + Aus():         void
             * + IstAn():       bool
             * + WähleSender(double neueFrequenz): void
             * + RadioInfo():   string
             * */

            Radioo meinRadio = new Radioo();
            meinRadio.RadioInfo();
            meinRadio.IstAn();
            meinRadio.An();
            meinRadio.IstAn();
            meinRadio.WähleSender(127.7);
            meinRadio.Lauter();
            meinRadio.RadioInfo();          
        }
    }
}
class Radioo
{
    bool Eingeschaltet;
    double Lautstärke = 50;
    double Frequenz = 0;

    public void Lauter()
    {
        if (Lautstärke < 100)
            Lautstärke += 1;
    }
    public void Leiser()
    {
        if (Lautstärke >= 0)
            Lautstärke -= 1;
    }
    public void An()
    {
        Eingeschaltet = true;
              
            Console.WriteLine("Radio an:");  
    }
    public void Aus()
    {
        Eingeschaltet = false;
        {
            Console.WriteLine("Radio aus:");
        }
    }

    public bool IstAn()
    {
        return Eingeschaltet;
    }
    public void WähleSender(double neueFrequenz)
    {
        Frequenz = neueFrequenz;
        Console.WriteLine($"Frequenz = {neueFrequenz}");
    }
    public string RadioInfo()
    {
        return $"{Eingeschaltet}\nFrequenz = {Frequenz}\nLautstärke = {Lautstärke}";
    }

}