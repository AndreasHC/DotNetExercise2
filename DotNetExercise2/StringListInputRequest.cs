
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
            string[] words = input.Split(' ');
            parsed = words;
            return words.Length >= minLength;
        }


    }
}
