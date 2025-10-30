using System;

namespace InputOutput_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Neuer Kommentar 
            // 1️. Statische Begrüßung
            Console.WriteLine("Moin Lars, willkommen zurück zur Einführung in C#!");
            Console.WriteLine(); // Leerzeile für bessere Lesbarkeit

        

            // 2️. Dynamische Eingabe: Vor- und Nachname abfragen
            Console.Write("Bitte gib deinen Vornamen ein: ");
            string vorname = Console.ReadLine();

            Console.Write("Bitte gib deinen Nachnamen ein: ");
            string nachname = Console.ReadLine();

            // 3️. Ausgabe mit personalisierter Begrüßung (Verkettung mit +)
            Console.WriteLine("Danke für die Eingabe, " + vorname + " " + nachname + ". Herzlich willkommen!");



            Console.WriteLine(); // Leerzeile für Übersicht
            Console.Write("Bitte gib eine ganze Zahl ein: ");
            int zahl = int.Parse(Console.ReadLine());

            if (zahl > 0)
            {
                Console.WriteLine("Die Zahl ist positiv!");
            }
            else if (zahl < 0)
            {
                Console.WriteLine("Die Zahl ist negativ!");
            }
            else
            {
                Console.WriteLine("Die Zahl ist null!");
            }
            Console.WriteLine(); // Leerzeile für Übersicht
        }
    }
}
