namespace Super.Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Taschenrechner");

                // Eingabe von zwei Zahlen
                Console.Write("Erste Zahl eingeben: ");
                double zahl1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Zweite Zahl eingeben: ");
                double zahl2 = Convert.ToDouble(Console.ReadLine());

                // Auswahl der Operation
                Console.WriteLine("Waehle eine Operation:");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraktion");
                Console.WriteLine("3: Multiplikation");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Fläche eines Rechtecks berechnen");

                Console.Write("Deine Wahl: ");
                int operation = Convert.ToInt32(Console.ReadLine());

                // Berechnung
                double ergebnis = 0;
                switch (operation)
                {
                    case 1:
                        ergebnis = zahl1 + zahl2;
                        break;
                    case 2:
                        ergebnis = zahl1 - zahl2;
                        break;
                    case 3:
                        ergebnis = zahl1 * zahl2;
                        break;
                    case 4:
                        if (zahl2 == 0)
                        {
                            Console.WriteLine("Division durch Null ist nicht erlaubt.");
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;
                    case 5:
                        if (zahl1 <= 0 || zahl2 <= 0)
                        {
                            Console.WriteLine("Die Zahlen müssen größer als null sein.");
                            continue;
                        }
                        ergebnis = zahl1 * zahl2;
                        Console.WriteLine("Die Fläche des Rechtecks beträgt: " + ergebnis);
                        break;
                    default:
                        Console.WriteLine("Ungueltige Operation.");
                        continue;
                }

                // Ausgabe des Ergebnisses
                Console.WriteLine("Ergebnis: " + ergebnis);

                // Option zum Beenden oder Weiterrechnen
                Console.WriteLine("Waehle eine Option:");
                Console.WriteLine("6: Programm beenden");
                Console.WriteLine("7: Weiter rechnen");

                Console.Write("Deine Wahl: ");
                int nextStep = Convert.ToInt32(Console.ReadLine());

                if (nextStep == 6)
                {
                    running = false;
                    Console.WriteLine("Programm beendet.");
                }
                else if (nextStep != 7)
                {
                    Console.WriteLine("Ungueltige Option. Programm wird fortgesetzt.");
                }
            }
        }
    }
}