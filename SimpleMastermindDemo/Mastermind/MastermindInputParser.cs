namespace SimpleMastermindDemo.Mastermind
{
    public static class MastermindInputParser
    {
        public static int[] StringToDigits(string input)
        {
            var output = new List<int>();

            foreach (char c in input)
            {
                if (int.TryParse(c.ToString(), out int number))
                {
                    output.Add(number);
                }
            }

            return output.ToArray();
        }
    }
}
