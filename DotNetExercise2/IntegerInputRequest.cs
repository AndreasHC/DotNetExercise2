
namespace DotNetExercise2
{
    internal class IntegerInputRequest:InputRequest
    {
        private int min;
        private int max;
        public IntegerInputRequest(string prompt, string rejection, int min, int max):base(prompt, rejection)
        {
            this.min = min;
            this.max = max;
        }

        protected override bool Evaluate(string input, out object parsed)
        {
            bool parseResult = int.TryParse(input, out int parsedInt);
            parsed = parsedInt;
            return parseResult & parsedInt >= min & parsedInt <= max;
        }
    }
}
