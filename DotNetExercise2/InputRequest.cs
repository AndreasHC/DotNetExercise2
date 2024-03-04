// Helper class to repeat a demand for user input until an acceptable one is provided. Acceptance criteria to be implemented in subclasses.


namespace DotNetExercise2
{
    internal class InputRequest
    {
        private string prompt;
        private string rejection;

        public InputRequest(string prompt, string rejection)
        {
            this.prompt = prompt;
            this.rejection = rejection;
        }

        // The returned boolean indicates whether the input is to be accepted. The out parameter should be the input, rearranged so that any information that was extracted for the evaluation and likely to be useful again later is as easily available as possible. This object will be the return value from Run.
        protected virtual bool Evaluate(string input, out object parsed)
        {
            parsed = input;
            return true;
        }

        public object Run()
        {
            return Run(prompt);
        }
        public object Run(string prompt)
        {
            return Run(prompt, rejection);
        }

        public object Run(string prompt, string rejection)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if(Evaluate(input, out object parsed))
                    return parsed;
                Console.WriteLine(rejection);
            }while (true);
        }
    }
}
