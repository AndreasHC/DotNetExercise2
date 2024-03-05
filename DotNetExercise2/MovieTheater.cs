
using System.Runtime.CompilerServices;

namespace DotNetExercise2
{
    internal enum AgeClass
    {
        Free,
        Youth,
        Retired,
        Standard
    }

    internal static class MovieTheater
    {
        static Dictionary<AgeClass, int> prices = new Dictionary<AgeClass, int> { {AgeClass.Free , 0 }, { AgeClass.Youth, 80 }, { AgeClass.Retired, 90 }, { AgeClass.Standard, 120 } };
        static Dictionary<AgeClass, string> ageClassDescriptions = new Dictionary<AgeClass, string> { { AgeClass.Free, "Gratis" }, { AgeClass.Youth, "Ungdomspris" }, { AgeClass.Retired, "Pensionärspris" }, { AgeClass.Standard, "Standardpris" } };

        private static IntegerInputRequest ageRequest = new IntegerInputRequest("Ange kundens ålder: ", "Kundens ålder måste anges i hela år, uttryckta med siffror, och måste vara 0-300.", 0, 300);
        private static IntegerInputRequest numberOfCustomersRequest = new IntegerInputRequest("Ange antal kunder: ", "Antalet kunder måste vara ett heltal, uttryckt med siffror, och måste vara 1-50.", 1, 50);

        internal static void SingleQuery()
        {
            int age = (int)ageRequest.Run();
            AgeClass ageClass = GetAgeClass(age);
            Console.WriteLine($"{ageClassDescriptions[ageClass]}: {prices[ageClass]} kr");
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
                price += prices[GetAgeClass(age)];
            }
            Console.WriteLine($"Antal personer: {groupSize}");
            Console.WriteLine($"Total kostnad: {price}");
            Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
            Console.ReadLine();
        }

        private static AgeClass GetAgeClass(int age)
        {
            if ((age < 5) | (age > 100))
            {
                return AgeClass.Free;
            }
            else if(age < 20)
            {
                return AgeClass.Youth;
            }
            else if (age > 64)
            {
                return AgeClass.Retired;
            }
            else
            {
                return AgeClass.Standard;
            }
        }
    }
}