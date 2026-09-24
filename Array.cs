using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Einstieg1
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            //Aufgabe12();
            //Aufgabe13();
            //Aufgabe21();
            //Aufgabe31();
            //Aufgabe41();
            //Aufgabe42();
            //Aufgabe51();
            KinossalAufgabe();
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //PasswortGenerator();
            //BubbleSort();

        }

        static void Aufgabe11()
        {
            //Legen Sie jeweils ein Array eines beliebigen, ganzzahligen Datentyps der Größe 10 an.
            //Füllen Sie das Array mit:

            //a) den Zahlen von 1 bis 10(in dieser Reihenfolge) mittels einer Schleife.
            int[] zahlen = new int[10];

            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = i + 1;   // i = 0, i + 1 = 1 / Werte 1 bis 10 einfügen
            }

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + " ");
            }
            Console.WriteLine();
            //b) den Zahlen von 10 bis 1(in dieser Reihenfolge) mittels einer Schleife.
            Console.WriteLine();
            int[] zahlen2 = new int[10];

            for (int i = 0; i < zahlen2.Length; i++)
            {
                zahlen2[i] = 10 - i; // Werte 10 bis 1 einfügen
            }

            for (int i = 0; i < zahlen2.Length; i++)
            {
                Console.Write(zahlen2[i] + " ");
            }
            Console.WriteLine();

            //c) Zufallszahlen mittels der Random.Next() Funktion in einer Schleife. 
            //Geben Sie das Array nach jeder Füllung wieder aus.
            Console.WriteLine();
            int[] zahlen3 = new int[10];
            Random zufall = new Random();

            for (int i = 0; i < zahlen3.Length; i++)
            {
                zahlen3[i] = zufall.Next(1, 11); // 1 bis 10 befüllen
                Console.Write(zahlen3[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] übung = new int[3];

            for (int i = 0; i < übung.Length; i++)
            {
                übung[i] = i + 1; // Beispiel: 1, 2, 3
            }

            for (int i = 0; i < übung.Length; i++)
            {
                Console.Write(übung[i] + " ");
            }
        }

        static void Aufgabe12()
        {
            //Legen Sie ein Array eines beliebigen, ganzzahligen Datentyps mit beliebiger Größe an.Füllen Sie das
            //Array mit Zufallszahlen.
            int[] array22 = new int[10];
            Random zufall = new Random();
            for (int i = 0; i < array22.Length; i++)
            {
                array22[i] = zufall.Next(22, 33);
                Console.WriteLine(array22[i] + " ");

            }

            //Führen Sie dann folgende Berechnungen durch:

            //1.berechnen Sie die Summe aller Zahlen in dem Array
            int summe = 0;
            foreach (int i in array22)
            {
                summe = summe + i;
            }
            Console.WriteLine("___");
            Console.WriteLine();
            Console.WriteLine($"Summe: {summe}");

            //2.berechnen Sie den Mittelwert aller Zahlen im Array und geben diesen aus
            double summex = 0;
            foreach (int i in array22)
            {
                summex = summex + i;
            }
            double mittelwert = summex / array22.Length;
            Console.WriteLine($"Mittelwert: {mittelwert}");

            //3.finden Sie die kleinste Zahl im Array
            int kleinste = array22[0];
            foreach (int i in array22)
            {
                if (i < kleinste)
                {
                    kleinste = i;
                }
            }
            Console.WriteLine($"Kleinste Zahl: {kleinste}");

            //4.finden Sie die größte Zahl im Array
            int größte = array22[0];
            foreach (int i in array22)
            {
                if (i > größte)
                {
                    größte = i;
                }
            }
            Console.WriteLine($"Größte Zahl: {größte}");

        }
        static void Aufgabe13()
        {
            //Legen Sie ein Array eines beliebigen, ganzzahligen Datentyps mit der Größe 10 an.Füllen Sie das
            //Array mit Zufallszahlen.  
            //Lassen Sie das Array ausgeben.
            //Vertauschen Sie alle Zahlen im Array miteinander, d.h.die erste Zahl wird zur letzten Zahl, die zweite
            //Zahl wird zur vorletzten Zahl, usw.Führen Sie den Tausch so durch, dass Sie kein weiteres Array
            //anlegen müssen.
            int[] array13 = new int[10];
            Random zufall = new Random();

            for (int i = 0; i < array13.Length; i++)
            {
                array13[i] = zufall.Next(1, 11);
            }
            Console.WriteLine("StartReihenfolge:");
            foreach (int i in array13)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            int left = 0;
            int right = array13.Length - 1;

            while (left < right)
            {
                int temp = array13[left];
                array13[left] = array13[right];
                array13[right] = temp;

                left++;
                right--;
            }
            Console.WriteLine("Danach");
            foreach (int i in array13)
            {
                Console.Write(i + " ");
            }
        }

        static void Aufgabe21()
        {
            //Schreiben Sie eine Anwendung, die 100.000 Zufallszahlen zwischen 0 und 50.000 in ein Array
            //schreibt.Der Anwender soll eine zu suchende Zahl eingeben und die Anwendung soll im Array nach
            //der Zahl suchen.Fangen Sie fehlerhafte Eingaben der gesuchten Zahl auf die obere und untere
            //Zahlengrenze ab.
            //Es wird ausgegeben: „Ja, die Zahl ist im Array“ oder „Nein, die Zahl ist nicht im Array“. 
            //Programmieren Sie die Suche als eine sequentielle Suche, d.h.fangen Sie beim ersten Array - Element
            //an und vergleichen es mit dem gesuchten Wert. Falls es nicht das gesuchte Element ist, gehen Sie
            //zum nächsten Array - Element usw.

            Console.WriteLine("Gib eine Zahl von 0 - 50.000 ein");
            int eingabe = int.Parse(Console.ReadLine());

            int[] Array1 = new int[100000];
            Random zufallszahl = new Random();
            bool gefunden = false;

            if (eingabe < 0 || eingabe > 50000)
            {
                Console.WriteLine("Ungültige Eingabe");
            }
            else
            {
                for (int i = 0; i < 100000; i++)
                {
                    Array1[i] = zufallszahl.Next(0, 50001);
                    if (Array1[i] == eingabe)     
                        gefunden = true;
                }
                if (gefunden)                     
                    Console.WriteLine("Ja, Die Zahl ist im Array");
                else
                    Console.WriteLine("Nein, Die Zahl ist nicht im Array");
            }
        }

        static void Aufgabe31()
        {
            //Schreiben Sie ein Programm, welches für z.B. einen Getränkeautomaten die Art und Anzahl der 
            //Münzen ermittelt, die für die Auszahlung des Wechselgeldes benötigt wird.
            //Ein Beispiel:
            //Ein Kunde kauft ein Getränk für 35 Cent, bezahl aber durch den Einwurf einer 1 Euro Münze. Das 
            //Restgeld entspricht 65 Cent und muss ausgezahlt werden.Idealerweise erfolgt dies in folgenden
            //Münzen:
            //1 x 50 Cent 
            //1 x 10 Cent
            //1 x  5 Cent
            //Gehen Sie davon aus, dass Sie für das Programm einen idealen Automaten mit unendlich vielen
            //Münzen jeder Sorte zur Verfügung haben. Erstellen Sie das Programm so, dass es vom Anwender
            //direkt den Restgeldbetrag in Cent abfragt und dann die Folge der zu zahlenden Münzen ausgibt.

            //Pseudocode:

            //1.Ausgabe: "Restbetrag eingeben"
            //2.int variable restbetrag erstellen 
            //3.restbetrag in int umwandeln mit int.Parse
            //4.array preis erstellen 
            //5.array befüllen mit verschiedenen münzen 200,100,50,20,10,5,2,1
            //6.for schleife:(int i = 0; i < Array.Length; i++)
            //7.in der schleife:
            //8.gehe das array durch und prüfe ob die münze im array <= ist als der restbetrag 
            //9.wenn nicht - gehe einen platz weiter 
            //10.wenn ja - int anzahl = restbetrag / münze
            //11.if (anzahl > 0) ausgabe ($"{anzahl} x {münze}") 
            //12.restbetrag = restbetrag % münze 


            Console.WriteLine("Restbetrag eingeben");
            int restbetrag = 0;
            restbetrag = int.Parse(Console.ReadLine());
            if (restbetrag <= 0)
                Console.WriteLine("Kein Restbetrag");
            else
            {
                int[] Münzen = { 200, 100, 50, 20, 10, 5, 2, 1 };


                for (int i = 0; i < Münzen.Length; i++)
                {
                    if (Münzen[i] <= restbetrag)
                    {
                        int anzahl = restbetrag / Münzen[i];

                        if (anzahl > 0)
                        {
                            Console.WriteLine($"{anzahl} x {Münzen[i]} cent");
                        }
                        restbetrag = restbetrag % Münzen[i];

                    }

                }
            }
        }

        static void Aufgabe41()
        {
            //Schreiben Sie ein Programm, das für das Lottospiel „6 aus 49“ einen Tipp vorschlägt, das heißt, sechs
            //zufällige Zahlen in einem Array speichert und anschließend ausgibt. Die Zahlen müssen nicht sortiert
            //sein.
            //Bei einem Lottotipp darf keine Zahl doppelt vorkommen.

            //Pseudocode:

            //1.Ausgabe:("Vorgeschlagener Tipp");
            //2.Array erstellen: int[] Lotto = new int[6];
            //3.Random zufallszahlen = new Random();
            //4.for-schleife : eine Zufallszahl (1–49) ziehen und in neuezahl speichern
            //5.den Merker schonVorhanden auf false setzen
            //6.mit dem Finger durchs Array gehen und jede gespeicherte Zahl mit neuezahl vergleichen
            //7.wenn beim Vergleich eine gleich ist -> schonVorhanden auf true setzen
            //8.wenn schonVorhanden true war -> nichts einfügen, neue Zahl ziehen (wiederholen)
            //9.wenn schonVorhanden am Ende false ist -> neuezahl ins Array einfügen

            Console.WriteLine("Tipps:"); 
            int[] lotto = new int[6];
            int neuezahl = 0;
            Random zufallszahlen = new Random();
            
            Console.WriteLine();

            for (int i = 0; i < lotto.Length; i++)
            {
                bool schonvorhanden = true;


                while (schonvorhanden)
                {
                    neuezahl = zufallszahlen.Next(1, 50); 
                    schonvorhanden = false;  
                    for (int j = 0; j < lotto.Length; j++) 
                    {
                        if (lotto[j] == neuezahl)
                            schonvorhanden = true; 
                    }
                }
                lotto[i] = neuezahl;
            }
            foreach (int zahl in lotto)
            {
                Console.Write(zahl + " ");
            }
            Console.WriteLine();

        }

        static void Aufgabe42()
        {
            //Erstellen Sie ein int-Array mit mindestens 5000 Elementen.Füllen Sie dieses Array mit Zufallszahlen
            //mit Zahlen zwischen 0 und 9.Legen Sie ein weiteres Array an, in dem Sie die Häufigkeit der Zahlen
            //von 0 bis 9 des ersten Arrays zählen(d.h.wie oft kommt z.B.die 0 in dem ersten Array vor, wie oft
            //die 1, usw.). Geben Sie anschließend den Inhalt des zweiten Arrays auf dem Bildschirm aus.
            //

            //Pseudocode:
            //1. Array1 anlegen: int[] Array1 = new int [5000]
            //2. Zufallsgenerator bauen: Random zufall = new Random();
            //3. Array mit Zufallszahlen befüllen mit einer for-schleife:
            //4. Array2 anlegen: int[] Array2 = new int [10]
            //5. Ich muss das Array1 durchgehen.
            //6. gehe durch Array1, und für jede Zahl x:  erhöhe Array2[x] um 1
            //7. Mit foreach (int zahl in Array2) jede zahl im Array2 nehmen
            //8.Ausgabe(Die Zahl ... gibt es ... mal)


            int[] Array1 = new int[5000];
            Random Zufall = new Random();
            for (int i = 0; i < Array1.Length; i++)
                Array1[i] = Zufall.Next(0, 10);
            int[] Array2 = new int[10];

            for (int i = 0; i < Array1.Length; i++)
            {

                Array2[Array1[i]]++;
            }
            for (int i = 0; i < Array2.Length; i++)
            {
                Console.WriteLine($"Die Zahl {i} kommt {Array2[i]} mal vor");
            }

        }

        static void KinossalAufgabe()
        {
            /*Aufgabe:
             * Sie sollen einem Kinobetreiber dabei helfen seine Säle udn Sitzplätze
             * darin zu verwalten. Ein Kinosaal kann wie folgt beschrieben werden
             * 
             * 8    8   8   8   8   8   8   8   8   8
             * 8    8   8   10  10  10  8   8   8   8
             * 10   10  10  10  10  10  10  10  10  10
             * 
             * Kunden wollen für eine Vorstellung in einem Saal buchen. Dabei können
             * Plätze zwei Zahlen(Reihe und Sitznummer in der Reihe) oder die Wahl
             * der Preiskategorie an, dann bekommt er den ersten freien PLatz in der
             * Kategorie an, dann bekommt er den ersten freien PLatz in der Kategorie
             * oder einem Meldung des Bedauerns, wenn kein Platz frei ist.
             * 
             * Ihr Programm soll folgendes leisten:
             * 
             * 1. Die obige Belegung des Kinosaals erzeugen
             * 
             * 2. An der Konsole abfragen, ob man über die Platznummer oder über die 
             * Kategorie wählen will oder die Eingabe beenden möchte.
             * 
             * 3. Die Eingabe des Platzes abwarten und dann eine Rückmeldung über
             * den Erfolg oder Misserfolg der Buchung ausgeben.
             * 
             * 4. Ausgeben wie viele Plätze noch frei sind, zurück zum Punkz 2
             * 
             * 5. Ausgabe der Summe, die über die verkauften Plätze eingenommen wurde.*/

            /*Pseudocode:
             * 
             * 
             * 
             * 
             */

            Console.WriteLine("Willkommen bei MyKino :)\n_______________________\n  Menü:\n        1.Platz buchen\n        2.Preiskategorie buchen\n        3.Beenden");
            Console.WriteLine();
            int eingabe = int.Parse(Console.ReadLine());
            string eingabe_kategorie;
            bool gebucht = false;
            bool weiter = true;

            int[,] kinosaal = new int[6, 11];


            for (int reihe = 0; reihe < 4; reihe++)
            {
                for(int spalte = 0; spalte < 10; spalte++)
                {
                    kinosaal[reihe, spalte] = 8;
                    
                }
                
            }
            for (int reihe = 4; reihe < 6; reihe++)
            {
                for (int spalte = 0; spalte < 10; spalte++)
                {
                    kinosaal[reihe, spalte] = 10;

                }

            }

            for (int reihe = 3; reihe < 4; reihe++)
            {
                for (int spalte = 3; spalte < 7; spalte++)
                {
                    kinosaal[reihe, spalte] = 10;
                }
            }

                switch (eingabe)
                {

                case 1:
                    Console.WriteLine("Geben Sie den Gewünschten Platz ein (z.B A1)");
                    Console.WriteLine();
                    Console.Write("    ");
                    for (int spalte = 0; spalte < 10; spalte++)
                    {
                        Console.Write((spalte + 1).ToString().PadLeft(4) + "    ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int reihe = 0; reihe < 6; reihe++)
                    {
                        char reihenBuchstabe = (char)('A' + reihe);
                        Console.Write(reihenBuchstabe + "   ");

                        for (int spalte = 0; spalte < 10; spalte++)
                        {
                            Console.Write(kinosaal[reihe, spalte].ToString().PadLeft(4) + "    ");
                        }
                        Console.WriteLine();

                    }
                    Console.WriteLine();


                    break;

                case 2:
                    Console.WriteLine("Wählen Sie Ihre gewünschte Preiskategorie\nn = Normaler Platz\np = Premiumplatz");
                    eingabe_kategorie = Console.ReadLine();

                    for (int reihe = 0; reihe < 6; reihe++)
                    {
                        char reihenBuchstabe = (char)('A' + reihe);
                        Console.Write(reihenBuchstabe + "   ");

                        for (int spalte = 0; spalte < 10; spalte++)
                        {
                            if (eingabe_kategorie == "n" && kinosaal[reihe, spalte] == 8)
                            {
                                Console.Write(kinosaal[reihe, spalte].ToString().PadLeft(4) + "    ");
                            }
                            else if (eingabe_kategorie == "p" && kinosaal[reihe, spalte] == 10)
                            {
                                Console.Write(kinosaal[reihe, spalte].ToString().PadLeft(4) + "    ");
                            }
                            else
                            {
                                Console.Write("    ".PadLeft(4) + "    ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:

                    break;
                }
        }
       
        static void Aufgabe1()
        {   
            //Array von 1-10 ausgeben
            int[] meinArray = new int[10];
            for (int i = 0; i < meinArray.Length; i++)
            {
                meinArray[i] = i + 1;

                Console.WriteLine(meinArray[i]);
            }
            Console.WriteLine();

            //Array von 10-1 ausgeben
            int[] meinArray1 = new int[10];
            for (int i = 0; i < meinArray1.Length; i++)
            {
                meinArray1[i] = 10 - i;

                Console.WriteLine(meinArray1[i]);
            }
            Console.WriteLine();

            // Array mit random zahlen 
            int[] meinArray3 = new int[10];
            Random zufall = new Random();
            for(int i = 0; i < meinArray3.Length; i++)
            {
                meinArray3[i] = zufall.Next(1, 11);
                Console.WriteLine(meinArray3[i]);
            }
            Console.WriteLine();
        }
        static void Aufgabe2()
        {   
            // Array Zufallszahlen und Summe,Mittelwert,Größte,Kleinste
            int[] meinArray4 = new int[10];
            Random zufall = new Random();
            double summe = 0;
            double mittelwert = 0;
            int kleinste = 10;
            int größte = 0;
            for(int i = 0; i < meinArray4.Length; i++)
            {
                meinArray4[i] = zufall.Next(1, 11);
                summe = summe + meinArray4[i];
                Console.WriteLine(meinArray4[i]);
            }
            for (int i = 0; i < meinArray4.Length; i++)
            {
                if (meinArray4[i] > größte)
                {
                    größte = meinArray4[i];
                }
            }
            for (int i = 0; i < meinArray4.Length; i++)
            {
                if (meinArray4[i] < kleinste)
                {
                    kleinste = meinArray4[i];
                }
            }
            mittelwert = (double)summe / meinArray4.Length;
            Console.WriteLine();
            Console.WriteLine($"Summe = {summe}");
            Console.WriteLine($"Mittelwert = {mittelwert}");
            Console.WriteLine($"Größte = {größte}");
            Console.WriteLine($"Kleinste = {kleinste}");
        }
        static void Aufgabe3()
        {
            int[] meinArray5 = new int[10];
            Random zufall = new Random();
            for (int i = 0; i < meinArray5.Length; i++)
            {
                meinArray5[i] = zufall.Next(1, 11);
                Console.Write(meinArray5[i] + " ");
            }
        }
        static void PasswortGenerator()
        {

            Console.WriteLine("Generiertes Passwort");
            Console.WriteLine();
            Random zufall = new Random();
            string[] Passwort = new string[8];
            bool gueltig = false;

            while (!gueltig)
            {
                int groß = 0;
                int klein = 0;
                int zeichen = 0;
                int zahl = 0;

                for (int i = 0; i < Passwort.Length; i++)
                {
                    Passwort[i] = ((char)zufall.Next(33, 126)).ToString();

                    if (char.IsUpper(Passwort[i][0]))
                        groß = 1;
                    if (char.IsLower(Passwort[i][0]))
                        klein = 1;
                    if (char.IsDigit(Passwort[i][0]))
                        zahl = 1;
                    if (char.IsPunctuation(Passwort[i][0]) || char.IsSymbol(Passwort[i][0]))
                        zeichen = 1;
                }

                if (groß == 1 && klein == 1 && zeichen == 1 && zahl == 1)
                    gueltig = true;
            }

            foreach (string c in Passwort)
                Console.Write(c);
            Console.WriteLine();
        }
        static void BubbleSort()
        {
            /*Pseudocode
             * 
             * Array anlegen: int[10]
             * Variable Zufall vom Typ Random();
             * ANFANG: For Schleife: Für Array von 0 - Array.Length
             * Array befüllen mit Zufallszahlen
             * ENDE:
             * */

            //int[] zahlen = new int[10];
            //Random rnd = new Random();

            //for (int i = 0; i < zahlen.Length; i++)
            //{
            //    zahlen[i] = rnd.Next(25, 76);
            //}

            //Console.WriteLine(string.Join(" ", zahlen));

            //bool istGetauscht = true;
            //int counter = 1;

            //while (istGetauscht)
            //{
            //    istGetauscht = false;
            //    int i = 0;

            //    while (i < zahlen.Length - counter)
            //    {
            //        if (zahlen[i] > zahlen[i + 1])
            //        {
            //            int puffer = zahlen[i + 1];
            //            zahlen[i + 1] = zahlen[i];
            //            zahlen[i] = puffer;
            //            istGetauscht = true;
            //        }
            //        i++;
            //    }

            //    counter++;
            //}

            //Console.WriteLine("Ausgabe von dem sortierten Array:");
            //Console.WriteLine(string.Join(" ", zahlen));

            int[] zahlen = new int[10];
            Random rnd = new Random();
            
            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = rnd.Next(25, 76);
            }

            Console.WriteLine(string.Join(" ", zahlen));
            bool istGetauscht = true;
            int counter = 1;

            while (istGetauscht)
            {
                istGetauscht = false;

                for (int i = 0; i < zahlen.Length - counter; i++)
                {
                    if (zahlen[i] > zahlen[i + 1])
                    {
                        int puffer = zahlen[i + 1];
                        zahlen[i + 1] = zahlen[i];
                        zahlen[i] = puffer;
                        istGetauscht = true;
                    }
                }
                counter++;
            }

            //Console.WriteLine(string.Join(" ", zahlen));

            foreach (int zahl in zahlen)
            {
                Console.Write(zahl + " ");
            }
            Console.WriteLine();



        }


           









        



            
    }
}




























    
    