
internal class Repeater
{
    internal static void tenFold()
    {
        Console.WriteLine("Mata in en text");
        string input = Console.ReadLine();
        // Start count at 1, since number is exposed to human user.
        for (int i = 1; i <= 10;  i++)
        {
            Console.Write(i);
            Console.Write('.');
            Console.Write(input);
            Console.Write(", ");
        }
        Console.WriteLine();
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }
}