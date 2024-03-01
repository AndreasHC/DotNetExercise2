
internal class MovieTheater
{
    static Dictionary<string, int> prices =new Dictionary<string, int> { { "Ungdomspris", 80 }, { "Pensionärspris", 90 }, {"Standardpris", 120 } };
    internal static void singleQuery()
    {
        int age = GetAgeFromUser();
        string description = AgeClass(age);
        Console.WriteLine($"{description}: {prices[description]} kr");
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }

    private static int GetAgeFromUser()
    {
        bool done = false;
        int age;
        do
        {
            Console.Write("Ange kundens ålder: ");
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