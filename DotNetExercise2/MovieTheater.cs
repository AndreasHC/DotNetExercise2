
namespace DotNetExercise2
{

    internal class MovieTheater
    {
        static Dictionary<string, int> prices = new Dictionary<string, int> { { "Gratis", 0 }, { "Ungdomspris", 80 }, { "Pensionärspris", 90 }, { "Standardpris", 120 } };

        private static IntegerInputRequest ageRequest = new IntegerInputRequest("Ange kundens ålder: ", "Kundens ålder måste anges i hela år, uttryckta med siffror, och måste vara 0-300.", 0, 300);
        private static IntegerInputRequest numberOfCustomersRequest = new IntegerInputRequest("Ange antal kunder: ", "Antalet kunder måste vara ett heltal, uttryckt med siffror, och måste vara 1-50.", 1, 50);

        internal static void SingleQuery()
        {
            int age = (int)ageRequest.Run();
            string description = AgeClass(age);
            Console.WriteLine($"{description}: {prices[description]} kr");
            Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
            Console.ReadLine();
        }

        internal static void GroupQuery()
        {
            int groupSize = (int)numberOfCustomersRequest.Run();
            int price = 0;
            // Start count at 1, since number is exposed to human user.
            for (int i = 1; i <= groupSize; i++)
            {
                int age = (int)ageRequest.Run($"Ange ålder för kund nummer {i}:");
                price += prices[AgeClass(age)];
            }
            Console.WriteLine($"Antal personer: {groupSize}");
            Console.WriteLine($"Total kostnad: {price}");
            Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
            Console.ReadLine();
        }

        private static string AgeClass(int age)
        {
            string description;
            if ((age < 5) | (age > 100))
            {
                description = "Gratis";
            }
            else if(age < 20)
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
}