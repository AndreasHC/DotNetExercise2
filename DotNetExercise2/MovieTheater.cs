
internal class MovieTheater
{
    static Dictionary<string, int> prices =new Dictionary<string, int> { { "Ungdomspris", 80 }, { "Pensionärspris", 90 }, {"Standardpris", 120 } };
    internal static void singleQuery()
    {
        int age = GetAgeFromUser("Ange kundens ålder: ");
        string description = AgeClass(age);
        Console.WriteLine($"{description}: {prices[description]} kr");
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }

    internal static void groupQuery()
    {
        bool done = false;
        uint groupSize;
        do
        {
            Console.Write("Ange antal kunder: ");
            string inputString = Console.ReadLine();
            done = uint.TryParse(inputString, out groupSize);
            if (!done)
            {
                Console.WriteLine("Antalet kunder måste vara ett heltal, uttryckt med siffror.");
            }
        }
        while (!done);
        int price = 0;
        // Start count at 1, since number is exposed to human user.
        for (int i = 1; i <= groupSize; i++)
        {
            int age = GetAgeFromUser($"Ange ålder för kund nummer {i}:");
            price += prices[AgeClass(age)];
        }
        Console.WriteLine($"Antal personer: {groupSize}");
        Console.WriteLine($"Total kostnad: {price}");
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }

    private static int GetAgeFromUser(string prompt)
    {
        bool done = false;
        int age;
        do
        {
            Console.Write(prompt);
            string inputString = Console.ReadLine();
            done = int.TryParse(inputString, out age);
            if (!done)
            {
                Console.WriteLine("Kundens ålder måste anges i hela år, uttryckta med siffror.");
            }
        }
        while (!done);
        return age;
    }

    private static string AgeClass(int age)
    {
        string description;
        if (age < 20)
        {
            description = "Ungdomspris";
        }
        else if (age > 64)
        {
            description = "Pensionärspris";
        }
        else
        {
            description = "Standardpris";
        }

        return description;
    }
}