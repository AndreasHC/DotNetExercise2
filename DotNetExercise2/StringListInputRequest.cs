
namespace DotNetExercise2
{
    internal class StringListInputRequest : InputRequest
    {
        private int minLength;

        public StringListInputRequest(string prompt, string rejection, int minLength) : base(prompt, rejection)
        {
            this.minLength = minLength;
        }

        protected override bool Evaluate(string input, out object parsed)
        {
            List<string> words = input.Split(' ').ToList();
            words.RemoveAll(StringIsEmpty);
            parsed = words;
            return words.Count >= minLength;
        }


        private static bool StringIsEmpty(string input)
        {
            return input == "";
        }

    }
}
