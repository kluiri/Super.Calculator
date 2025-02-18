namespace Super.Calculator
{
    class Program
    {
        public static void Main(string[] args)
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
                        return;
                    }
                    ergebnis = zahl1 / zahl2;
                    break;
                default:
                    Console.WriteLine("Ungueltige Operation.");
                    return;
            }

            // Ausgabe des Ergebnisses
            Console.WriteLine("Ergebnis: " + ergebnis);
        }
    }
}
