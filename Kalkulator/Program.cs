using System;

internal class Program
{
    private static void Main()
    {
        // Powitanie użytkownika
        Console.WriteLine("Witaj w kalkulatorze!");

        // Pobranie imienia użytkownika
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine();

        // Przywitanie użytkownika
        Console.WriteLine($"Cześć, {imie}! Zaczynamy!");

        while (true) // Główna pętla, aby aplikacja nie zamykała się po pierwszym użyciu
        {
            // Wyświetlenie głównego menu
            Console.WriteLine("\nNasz Kalkulator:");
            Console.WriteLine("1. Proste działania (+, -, *, /)");
            Console.WriteLine("2. Potęga, pierwiastek");
            Console.WriteLine("3. Zaokrąglij");
            Console.WriteLine("4. Logarytm");
            Console.WriteLine("5. Obliczenia dla figur");
            Console.WriteLine("6. Sin, Cos, Tg, Ctg");
            Console.WriteLine("7. Wyjście");
            Console.Write("Wybierz opcję (1-7): ");

            // Pobranie wyboru użytkownika
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    ProsteDzialania();
                    break;

                case "2":
                    PotegaPierwiastek();
                    break;

                case "3":
                    Zaokraglij();
                    break;

                case "4":
                    Logarytm();
                    break;

                case "5":
                    ObliczeniaDlaFigur();
                    break;

                case "6":
                    FunkcjeTrygonometryczne();
                    break;

                case "7":
                    Console.WriteLine("Dziękujemy za skorzystanie z kalkulatora! Do zobaczenia!");
                    return; // Zakończenie programu
                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static double PobierzLiczbe(string komunikat)
    {
        double liczba;
        while (true)
        {
            Console.Write(komunikat);
            if (double.TryParse(Console.ReadLine(), out liczba))
            {
                return liczba;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość. Podaj liczbę.");
            }
        }
    }

    private static void Zaokraglij()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz rodzaj zaokrąglenia:");
            Console.WriteLine("1. Zaokrąglij w dół");
            Console.WriteLine("2. Zaokrąglij w górę");
            Console.WriteLine("3. Standardowe zaokrąglenie");
            Console.WriteLine("4. Powrót do głównego menu");
            Console.Write("Wybierz opcję (1-4): ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                case "2":
                case "3":
                    double a = PobierzLiczbe("Podaj liczbę do zaokrąglenia: ");
                    switch (wybor)
                    {
                        case "1":
                            Console.WriteLine($"Wynik zaokrąglenia w dół: {Math.Floor(a)}");
                            break;

                        case "2":
                            Console.WriteLine($"Wynik zaokrąglenia w górę: {Math.Ceiling(a)}");
                            break;

                        case "3":
                            Console.WriteLine($"Standardowy wynik zaokrąglenia: {Math.Round(a)}");
                            break;
                    }
                    break;

                case "4":
                    return; // Powrót do głównego menu
                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    // Reszta funkcji pozostaje bez zmian
    private static void ProsteDzialania()
    {
        double a = PobierzLiczbe("Podaj pierwszą liczbę: ");
        double b = PobierzLiczbe("Podaj drugą liczbę: ");

        Console.Write("Podaj operację (+, -, *, /): ");
        char operacja = Console.ReadLine()[0];

        double wynik = 0;
        switch (operacja)
        {
            case '+':
                wynik = a + b;
                break;

            case '-':
                wynik = a - b;
                break;

            case '*':
                wynik = a * b;
                break;

            case '/':
                if (b != 0)
                {
                    wynik = a / b;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero!");
                    return;
                }
                break;

            default:
                Console.WriteLine("Nieznana operacja.");
                return;
        }
        Console.WriteLine($"Wynik: {wynik}");
    }

    private static void PotegaPierwiastek()
    {
        double a = PobierzLiczbe("Podaj liczbę: ");

        Console.Write("Wybierz operację (potęga - p, pierwiastek - r): ");
        char operacja = Console.ReadLine()[0];

        if (operacja == 'p')
        {
            double b = PobierzLiczbe("Podaj wykładnik: ");
            double wynik = Math.Pow(a, b);
            Console.WriteLine($"Wynik: {wynik}");
        }
        else if (operacja == 'r')
        {
            if (a >= 0)
            {
                double wynik = Math.Sqrt(a);
                Console.WriteLine($"Wynik: {wynik}");
            }
            else
            {
                Console.WriteLine("Nie można obliczyć pierwiastka z liczby ujemnej.");
            }
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
        }
    }

    private static void Logarytm()
    {
        double a = PobierzLiczbe("Podaj liczbę: ");

        if (a > 0)
        {
            double wynik = Math.Log(a);
            Console.WriteLine($"Wynik logarytmu: {wynik}");
        }
        else
        {
            Console.WriteLine("Logarytm można obliczyć tylko dla liczb dodatnich.");
        }
    }

    private static void ObliczeniaDlaFigur()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz figurę:");
            Console.WriteLine("1. Czworokąt");
            Console.WriteLine("2. Trójkąt");
            Console.WriteLine("3. Koło");
            Console.WriteLine("4. Powrót do głównego menu");
            Console.Write("Wybierz opcję (1-4): ");

            string wyborFigury = Console.ReadLine();

            switch (wyborFigury)
            {
                case "1":
                    ObliczeniaCzworokat();
                    break;

                case "2":
                    ObliczeniaTrojkat();
                    break;

                case "3":
                    ObliczeniaKolo();
                    break;

                case "4":
                    return; // Powrót do głównego menu
                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static void ObliczeniaCzworokat()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz rodzaj czworokąta:");
            Console.WriteLine("1. Kwadrat");
            Console.WriteLine("2. Prostokąt");
            Console.WriteLine("3. Równoległobok");
            Console.WriteLine("4. Trapez");
            Console.WriteLine("5. Powrót do menu figur");
            Console.Write("Wybierz opcję (1-5): ");
            string wyborCzworokata = Console.ReadLine();

            switch (wyborCzworokata)
            {
                case "1":
                    double bokKwadrat = PobierzLiczbe("Podaj długość boku: ");
                    Console.WriteLine($"Pole: {bokKwadrat * bokKwadrat}, Obwód: {4 * bokKwadrat}");
                    break;

                case "2":
                    double aProstokat = PobierzLiczbe("Podaj długość pierwszego boku: ");
                    double bProstokat = PobierzLiczbe("Podaj długość drugiego boku: ");
                    Console.WriteLine($"Pole: {aProstokat * bProstokat}, Obwód: {2 * (aProstokat + bProstokat)}");
                    break;

                case "3":
                    double aRownoleglobok = PobierzLiczbe("Podaj długość podstawy: ");
                    double hRownoleglobok = PobierzLiczbe("Podaj wysokość: ");
                    Console.WriteLine($"Pole: {aRownoleglobok * hRownoleglobok}");
                    break;

                case "4":
                    double aTrapez = PobierzLiczbe("Podaj długość pierwszej podstawy: ");
                    double bTrapez = PobierzLiczbe("Podaj długość drugiej podstawy: ");
                    double hTrapez = PobierzLiczbe("Podaj wysokość: ");
                    Console.WriteLine($"Pole: {((aTrapez + bTrapez) * hTrapez) / 2}");
                    break;

                case "5":
                    return; // Powrót do menu figur

                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static void ObliczeniaTrojkat()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz rodzaj trójkąta:");
            Console.WriteLine("1. Równoboczny");
            Console.WriteLine("2. Równoramienny");
            Console.WriteLine("3. Prostokątny");
            Console.WriteLine("4. Ostry (kąt + boki)");
            Console.WriteLine("5. Trójkąt (podstawa + wysokość)");
            Console.WriteLine("6. Powrót do menu figur");
            Console.Write("Wybierz opcję (1-6): ");
            string wyborTrojkata = Console.ReadLine();

            switch (wyborTrojkata)
            {
                case "1":
                    double bok = PobierzLiczbe("Podaj długość boku: ");
                    Console.WriteLine($"Pole: {(Math.Sqrt(3) / 4) * bok * bok}, Obwód: {3 * bok}");
                    break;

                case "2":
                    double bokA = PobierzLiczbe("Podaj długość podstawy: ");
                    double bokB = PobierzLiczbe("Podaj długość ramienia: ");
                    double wysokosc = Math.Sqrt(bokB * bokB - (bokA * bokA) / 4);
                    Console.WriteLine($"Pole: {(bokA * wysokosc) / 2}, Obwód: {2 * bokB + bokA}");
                    break;

                case "3":
                    double przyprostokatna1 = PobierzLiczbe("Podaj długość pierwszej przyprostokątnej: ");
                    double przyprostokatna2 = PobierzLiczbe("Podaj długość drugiej przyprostokątnej: ");
                    Console.WriteLine($"Pole: {(przyprostokatna1 * przyprostokatna2) / 2}");
                    break;

                case "4":
                    Console.WriteLine("Funkcjonalność dla obliczeń trójkąta ostrego jeszcze nie jest zaimplementowana.");
                    break;

                case "5":
                    double podstawa = PobierzLiczbe("Podaj długość podstawy: ");
                    double wys = PobierzLiczbe("Podaj wysokość: ");
                    Console.WriteLine($"Pole: {(podstawa * wys) / 2}");
                    break;

                case "6":
                    return; // Powrót do menu figur

                default:
                    Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }

    private static void ObliczeniaKolo()
    {
        double r = PobierzLiczbe("Podaj promień koła: ");
        double pole = Math.PI * r * r;
        double obwod = 2 * Math.PI * r;
        Console.WriteLine($"Pole: {pole}, Obwód: {obwod}");
    }

    private static void FunkcjeTrygonometryczne()
    {
        double kat = PobierzLiczbe("Podaj kąt w stopniach: ");
        double katRad = Math.PI * kat / 180.0; // Konwersja stopni na radiany

        Console.WriteLine($"Sin: {Math.Sin(katRad)}");
        Console.WriteLine($"Cos: {Math.Cos(katRad)}");
        Console.WriteLine($"Tg: {Math.Tan(katRad)}");
        Console.WriteLine($"Ctg: {(Math.Tan(katRad) != 0 ? 1.0 / Math.Tan(katRad) : double.PositiveInfinity)}");
    }
}