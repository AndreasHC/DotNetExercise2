
using System.ComponentModel.DataAnnotations;

internal static class Menu
{
    internal static void runOnce(out bool done)
    {
        done = false;
        display();
        string input = Console.ReadLine();
        switch (input)
        {
            case "0":
                done = true;
                break;
            case "1":
                MovieTheater.singleQuery();
                break;
            case "2":
                MovieTheater.groupQuery();
                break;
            case "3":
                Repeater.tenFold();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{input} är inte ett giltigt input.");
                Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
                Console.ReadLine();
                break;
        }
    }

    private static void display()
    {
        Console.Clear();
        Console.WriteLine("Du har kommit till huvudmenyn.");
        Console.WriteLine("Skriv in siffror för att testa funktioner.");
        Console.WriteLine("0. Avsluta");
        Console.WriteLine("1. Biopris, en kund");
        Console.WriteLine("2. Biopris, grupp");
        Console.WriteLine("3. Repetition av text 10 gånger");
    }
}