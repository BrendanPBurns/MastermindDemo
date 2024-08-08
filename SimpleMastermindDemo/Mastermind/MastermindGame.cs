using SimpleMastermindDemo.Mastermind.DataTypes;

namespace SimpleMastermindDemo.Mastermind
{
    public class MastermindGame
    {
        private int _attempts;
        private IAwnserSequence _sequence;

        public MastermindGame(int attempts, int length, int numberOfOptions)
        {
            _attempts = attempts;
            _sequence = new AwnserSequence(length, numberOfOptions);
        }


        public bool Play()
        {
            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine("We're all set up. So lets go.");
            var attempt = 1;
            while (attempt <= _attempts)
            {
                Console.Write($"Type {_sequence.Length} digits between 1 and {_sequence.NumberOfOptions} here:");
                var userInput = Console.ReadLine();
                var inputSequence = new InputSequence(_sequence.Length, _sequence.NumberOfOptions);
                if (inputSequence.SetValues(StringToDigitInput(userInput)))
                {
                    var result = new Result(_sequence, inputSequence);
                    PrintResults(result);
                    if(result.Won) return true;
                    attempt++;                    
                }
                else
                {
                    Console.WriteLine("Invalid Input try again!");
                }
            }
            Console.WriteLine("You Lost");
            return false;
        }

        private void PrintResults(Result result)
        {
            for (int i = 0; i < (result.MatchingNumber - result.MatchingPlacements); i++)
            {
                Console.Write('-');
            }
            for (int i = 0; i < result.MatchingPlacements; i++)
            {
                Console.Write('+');
            }
            Console.WriteLine();
        }

        private int[] StringToDigitInput(string input)
        {
            var output = new List<int>();

            foreach (char c in input)
            {
                if(int.TryParse(c.ToString(), out int number))
                {
                    output.Add(number);              
                }
            }

            return output.ToArray();
        }
    }
}
