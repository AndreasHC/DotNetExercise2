
using DotNetExercise2;

internal class Repeater
{
    private static InputRequest textRequest = new InputRequest("Mata in en text: ", "Ett oförutsett fel har inträffat, försök igen.");

    internal static void TenFold()
    {
        string input = (string) textRequest.Run();
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