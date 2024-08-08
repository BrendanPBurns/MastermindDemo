namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public interface IAwnserSequence : ISequence
    {
        int NumberOfOptions { get; }
    }

    public class AwnserSequence : BaseSequence, IAwnserSequence
    {
        private Random _random = new Random();

        public AwnserSequence(int length, int numberOfOptions) : base(length, numberOfOptions)
        {
            GenerateRandomValues();
        }

        public int NumberOfOptions => _numberOfOptions;

        public void GenerateRandomValues()
        {
            for (int i = 0; i < Digits.Length; i++)
            {
                Digits[i] = _random.Next(1, _numberOfOptions);
            }
        }
    }
}
