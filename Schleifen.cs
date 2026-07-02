using System;
using System.Numerics;
using System.Security.Cryptography;



namespace Einstieg1
{
    internal class Schleifen
    {
        static void Main(string[] args)
        {
            //Aufgabe11();
            //Countdown();
            //Aufgabe12();
            //Bonus1();
            //Bonus2();
            //Bonus3();
            //Aufgabe13();
            //Aufgabe21();
            //Aufgabe22();
            //Aufgabe31();
            //Aufgabe41();
            //Aufgabe61();
        }
        static void Aufgabe11()
        {
            Console.WriteLine("Gebe die Zahlen 1-10 aus\n");

            for (int i = 1; i < 11; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        static void Countdown()
        {
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine("Zählerstand : {0}", counter);
                counter--;
            }
            Console.WriteLine("Start!");
        }

        static void Aufgabe12() //ChatGPT
        {
            Console.WriteLine("Die ersten 30 Fibonacci-Zahlen:\n");

            int a = 0;   // erste Zahl
            int b = 1;   // zweite Zahl

            Console.Write($"{a} {b} ");  // die ersten beiden ausgeben

            for (int i = 3; i <= 30; i++)
            {
                int c = a + b;   // neue Fibonacci-Zahl
                Console.Write($"{c} ");

                a = b;           // Werte weiterschieben
                b = c;
            }

        }

        static void Bonus1()
        {
            // Logisches Zerlegen üben:
            //Zähle nur die geraden Zahlen von 1 - 20 
            //Gib nur die Zahlen aus, die gerade sind.

            Console.WriteLine("Nur gerade Zahlen ausgeben:");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        static void Bonus2()
        {
            //Zwischenschritte planen:
            //Berechne die Summe aller Zahlen von 1 bis 50

            Console.WriteLine("Die Gesamtsumme aus den Summen 1-50");

            int x = 0;
            for (int i = 1; i <= 50; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);
        }

        static void Bonus3()
        {
            // Gib die Zahlen 1 - 10 rückwärts aus:
            Console.WriteLine("Zahlen 1 - 10 Rückwärts ausgeben:\n");

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void Aufgabe13()
        {   //Quersumme einer Zahl berechnen.
            Console.WriteLine("Gib eine Zahl ein:");
            int eingabe = int.Parse(Console.ReadLine());

            int quersumme = 0;
            int zahl = eingabe;

            while (zahl > 0) //Zerlege die Zahl solange bis nix mehr übrig ist.
            {
                quersumme += zahl % 10; // letzte Ziffer addieren - quersumme = quersumme + (zahl % 10); (777 % 10 = 7) 
                zahl /= 10;             // letzte Ziffer entfernen
            }

            Console.WriteLine($"Die Quersumme Ihrer Zahl ist {quersumme}");

        }

        static void Aufgabe21()
        {
            //Ein Programm soll das Quadrat der Zahlen von 1 bis 10 erstellen. Die Ausgabe soll wie folgt aussehen: 
            //Verwenden Sie alle Ihnen bekannten verschiedenen Schleifen-Typen um die Ausgabe jeweils einmal 
            //pro Schleifen-Typ zu erreichen. Soll so aussehen -> Das Quadrat von 1 ist 1. 
            int x = 0;
            for (int i = 1; i <= 10; i++)
            {
                x = i * i;
                Console.WriteLine($"Das Quadrat von {i} ist {x}");
            }
            //Mit While-Scheife:
            //int i = 0;
            //int x = 0;
            //while (i <= 10)
            //{
            //    x = i * i;
            //    Console.WriteLine($"Das Quadrat von {i} ist {x}");
            //    i++;

        }


        static void Aufgabe22()
        {
            //Schreiben Sie ein Programm, das die Summe der Zahlen von 1 bis n berechnet: 
            //Summe = 1 + 2 + 3 + … +(n – 1) +n
            //Beispiel: Summe der Zahlen von 1 bis 5 = 1 + 2 + 3 + 4 + 5 = 15

            //Console.WriteLine("Summe der Zahlen berechnen;");

            //int summe = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    summe = summe + i;

            //    if (i < 5)
            //        Console.Write($"{i} + ");
            //    else
            //        Console.Write($"{i}");
            //}
            //Console.WriteLine($" = {summe}");

            //Mit einer While - Schleife:
            int i = 0;
            int summe = 0;
            while (i <= 5)
            {
                summe = summe + i;
                if (i < 5)
                    Console.Write($"{i} + ");
                else
                    Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine($"= {summe}");
        }
        static void Aufgabe31()
        {
            //Aufgabe 1
            //Erstellen Sie ein Programm für ein einfaches Spiel, in dem Zahlen geraten werden sollen.Ihre
            //Anwendung soll zunächst eine Zufallszahl aus dem Intervall von 1 bis 100 einschließlich auswählen. 
            //Dann soll der Spieler solange die Möglichkeit erhalten eine Zahl einzugeben, bis er die zufällig
            //ausgewählte Zahl erraten hat. 
            //Rät der Anwender richtig, dann endet das Spiel.Rät der Anwender falsch, dann erhält er eine
            //entsprechende Meldung und einen Hinweis, ob die gesuchte Zahl kleiner oder größer als sein letzter
            //Versuch ist. Sie können als Erweiterung auch die Anzahl der Rateversuche mit als Teil des Ergebnisses
            //ausgeben.
            //Sie erhalten eine Zufallszahl aus dem Intervall 1 bis 100 durch folgende Anweisungen:
            //Random zufall = new Random();
            //int zahl = zufall.Next(1, 101);

            Console.WriteLine("Gebe eine Zahl von 1 - 20 ein:");
            Random zufall = new Random();
            int zahl = zufall.Next(1, 21);
            int eingabe = 0;
            int versuche = 0;


            while (eingabe != zahl)
            {
                versuche++;

                eingabe = int.Parse(Console.ReadLine());

                if (eingabe == zahl)
                    Console.WriteLine($"Richtig! Du hast {versuche} Versuche gebraucht");
                else if (eingabe < zahl)
                    Console.WriteLine("Zahl zu klein! Neuer Versuch!");
                else
                    Console.WriteLine("Zahl zu groß! Neuer Versuch!");
            }
        }
        static void Aufgabe41()
        {
            //Aufgabe
            //Um die Erfindung des Schach-Spiels rankt sich die „Weizenkornlegende“. Der angebliche Erfinder des
            //Spiels präsentierte das Spiel seinem König und dieser war so begeistert, dass er dem Erfinder eine
            //Belohnung seiner Wahl versprach.
            //Der Erfinder wollte in Weizen belohnt werden.Er erbat vom König folgendes: 
            //Als Lohn sollten die 64 Felder des Spielbretts mit Weizenkörnern gefüllt werden, und zwar ein Korn
            //für das erste Feld und auf jedes weitere Feld doppelt so viele Körner, wie auf dem vorherigen Feld.
            //Schreiben Sie ein Programm, welches ausrechnet, wie viele Weizenkörner nach der beschriebenen
            //Methode benötigt würden, um die Abmachung zu erfüllen.Geben Sie bei jedem Schritt das
            //Zwischenergebnis aus.
            //Berechnen Sie auch das Gesamtgewicht der insgesamt aufgelegten Weizenkörner in Tonnen, wobei
            //Sie das Gewicht für ein Weizenkorn mit 0,05 g ansetzen. 
            //Wie lang wäre ein Stau von LKW mit allen Weizenkörnern, wenn ein LKW 25 Tonnen laden kann und
            //19m lang ist? 

            Console.WriteLine
            ("64 Felder mit Weizenkörner füllen und für jedes Feld immer Doppelt so viele wie auf dem Vorherigen Feld");
            ulong  körner = 1;

            for (int i = 1; i <= 64; i++)
            {
                Console.WriteLine($"{i} {körner}");
                körner = körner * 2;
            }
            double gramm = körner * 0.05; // Gesamtgramm aller Körner 
            double tonnen = gramm / 1000 / 1000; // Gesamttonnen aller Körner
            double ton25 = 25_000_000 / 0.05; // = 500.000.000 Körner = 25 Tonnen 
            double lkw = tonnen / 25;
            double lkwstau = lkw * 19;

            Console.WriteLine(tonnen);
            Console.WriteLine(ton25);
            Console.WriteLine(lkw);
            Console.WriteLine(lkwstau);
        }
        
        static void Aufgabe61() 
        {
            //Erstellen Sie ein Programm(Windows / Console), welches zwei beliebige ganze Zahlen, die größer als
            //0 sind, mithilfe der "Russischen Multiplikation" multipliziert! Die " Russischen Multiplikation" arbeitet
            //nach folgendem Verfahren:
            //1.Man schreibt die beiden Zahlen nebeneinander(Tabelle)
            //2.Auf der linken Seite wird die Zahl jeweils halbiert(Reste abrunden)
            //3.Auf der rechten Seite wird die Zahl verdoppelt
            //4.Ist die Zahl auf der linken Seite gerade, dann wird die Zahl rechts gestrichen
            //5.Ist man in der linken Spalte beim Wert eins(1) angelangt, dann beendet man das halbieren, 
            //multiplizieren
            //6.Das Produkt der beiden Zahlen ist die Summe alle nicht gestrichenen Zahlen in der rechte
            //Spalte!

            Console.WriteLine("Nennen Sie Ihre Multiplikation\nErste Zahl:");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zweite Zahl:");
            int zahl2 = int.Parse(Console.ReadLine());

            int x = zahl1;
            int y = zahl2;

            int summe = 0;

            Console.WriteLine("\nZahl1\tZahl2\tgenommen?");
            Console.WriteLine("---------------------------");

            while (zahl1 > 0)
            {
                bool ungerade = (zahl1 % 2 == 1);

                Console.WriteLine($"{zahl1}\t{zahl2}\t{(ungerade ? "ja" : "nein")}");

                if (ungerade)
                {
                    summe += zahl2;
                }

                zahl1 = zahl1 / 2;   // halbieren (abrunden)
                zahl2 = zahl2 * 2;   // verdoppeln
            }

            Console.WriteLine($"\nErgebnis: {x} * {y} = {summe}");













        }















        































    }
}