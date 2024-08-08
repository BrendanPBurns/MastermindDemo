namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public interface IAwnserSequence
    {
        int Length { get; }
        int NumberOfOptions { get; }
        int[] Digits { get; }
    }

    public class AwnserSequence : BaseSequence, IAwnserSequence
    {
        private Random _random = new Random();

        public AwnserSequence(int length, int numberOfOptions) : base(length, numberOfOptions)
        {
            GenerateRandomValues();
        }

        public int Length => Digits.Length;

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
