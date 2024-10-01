using System;

internal class Program
{
    private static void Main()
    {
        // Deklaracja zmiennych do przechowywania dwóch liczb
        double liczba1, liczba2;
        string operacja;

        // Pobranie od użytkownika pierwszej liczby
        Console.Write("Wprowadź pierwszą liczbę: ");
        liczba1 = Convert.ToDouble(Console.ReadLine());

        // Pobranie od użytkownika drugiej liczby
        Console.Write("Wprowadź drugą liczbę: ");
        liczba2 = Convert.ToDouble(Console.ReadLine());

        // Pobranie od użytkownika wybranej operacji
        Console.Write("Wprowadź operację (+, -, *, /): ");
        operacja = Console.ReadLine();

        // Zmienna do przechowywania wyniku
        double wynik = 0;

        // Instrukcja switch do wyboru odpowiedniej operacji
        switch (operacja)
        {
            case "+":
                wynik = liczba1 + liczba2; // Dodawanie
                break;

            case "-":
                wynik = liczba1 - liczba2; // Odejmowanie
                break;

            case "*":
                wynik = liczba1 * liczba2; // Mnożenie
                break;

            case "/":
                // Sprawdzenie, czy dzielenie przez zero nie ma miejsca
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2; // Dzielenie
                }
                else
                {
                    Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                    return; // Zakończenie programu w przypadku błędu
                }
                break;

            default:
                // Obsługa błędnej operacji
                Console.WriteLine("Błąd: Nieznana operacja!");
                return;
        }

        // Wyświetlenie wyniku
        Console.WriteLine("Wynik: " + wynik);
    }
}