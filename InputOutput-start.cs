using System;

namespace InputOutput_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1️. Statische Begrüßung
            Console.WriteLine("Hallo Lars Sandmann, willkommen in der Einführung zur Programmierung mit C#!");
            Console.WriteLine(); // Leerzeile für bessere Lesbarkeit

            // 2️. Dynamische Eingabe: Vor- und Nachname abfragen
            Console.Write("Bitte gib deinen Vornamen ein: ");
            string vorname = Console.ReadLine();

            Console.Write("Bitte gib deinen Nachnamen ein: ");
            string nachname = Console.ReadLine();

            // 3️. Ausgabe mit personalisierter Begrüßung (Verkettung mit +)
            Console.WriteLine("Danke für die Eingabe, " + vorname + " " + nachname + ". Herzlich willkommen!");
        }
    }
}
