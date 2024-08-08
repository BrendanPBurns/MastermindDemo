namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public interface IInputSequence
    {
        bool SetValues(int[] input);
    }

    public class InputSequence : BaseSequence
    {
        public bool Initalized { get; private set; }

        public InputSequence(int length, int numberOfOptions) : base(length, numberOfOptions)
        {
        }

        public bool SetValues(int[] input) 
        { 
            if(input.Length == Digits.Length)
            {
                for(int i = 0;i < Digits.Length; i++)
                {
                    Digits[i] = input[i];
                }
                Initalized = true;
                return true;
            }
            else
            {
                return false;
            }            
        }

    }
}
