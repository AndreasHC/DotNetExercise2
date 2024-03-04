
namespace DotNetExercise2
{
    internal static class Menu
    {
        private static InputRequest request = new InputRequest("Välj: ", "Ett oförutsett fel har inträffat, försök igen.");
        internal static void RunOnce(out bool done)
        {
            done = false;
            Display();
            string input = (string)request.Run();
            switch (input)
            {
                case "0":
                    done = true;
                    break;
                case "1":
                    MovieTheater.SingleQuery();
                    break;
                case "2":
                    MovieTheater.GroupQuery();
                    break;
                case "3":
                    Repeater.TenFold();
                    break;
                case "4":
                    StringSplitter.Third();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine($"{input} är inte ett giltigt input.");
                    Console.WriteLine("Tryck enter för att komma tillbaka till huvudmenyn.");
                    Console.ReadLine();
                    break;
            }
        }

        private static void Display()
        {
            Console.Clear();
            Console.WriteLine("Du har kommit till huvudmenyn.");
            Console.WriteLine("Skriv in siffror för att testa funktioner.");
            Console.WriteLine("0. Avsluta");
            Console.WriteLine("1. Biopris, en kund");
            Console.WriteLine("2. Biopris, grupp");
            Console.WriteLine("3. Repetition av text 10 gånger");
            Console.WriteLine("4. Hitta tredje ordet i en text");
        }
    }
}