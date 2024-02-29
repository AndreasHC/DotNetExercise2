
internal class MovieTheater
{
    internal static void singleQuery()
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
        string description;
        int price;
        if (age < 20)
        {
            description = "Ungdomspris";
            price = 80;
        }
        else if (age > 64)
        {
            description = "Pensionärspris";
            price = 90;
        }
        else
        {
            description = "Standardpris";
            price = 120;
        }
        Console.WriteLine($"{description}: {price} kr");
        Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
        Console.ReadLine();
    }
}