
internal class StringSplitter
{
    internal static void Third()
    {
        bool done = false;
        while (!done)
        {
            Console.WriteLine("Mata in en text med minst tre ord.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            if (words.Length > 2 )
            {
                Console.WriteLine(words[2]);
                done = true;
            }
            else
            {
                Console.WriteLine("Det var inte en text med minst tre ord.");
            }
        }
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }
}