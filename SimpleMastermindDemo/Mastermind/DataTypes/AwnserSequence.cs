namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public class AwnserSequence : BaseSequence
    {
        private Random _random = new Random();

        public AwnserSequence(int length, int numberOfOptions) : base(length, numberOfOptions)
        {
            GenerateRandomValues();
        }

        public void GenerateRandomValues()
        {
            for (int i = 0; i < Digits.Length; i++)
            {
                Digits[i] = _random.Next(1, _numberOfOptions);
            }
        }
    }
}
