
using DotNetExercise2;

internal class StringSplitter
{
    private static StringListInputRequest request = new StringListInputRequest("Mata in en text med minst tre ord: ", "Det var inte en text med minst tre ord.", 3);
    internal static void Third()
    {
        string[] words = (string[]) request.Run();
        Console.WriteLine(words[2]);
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }
}