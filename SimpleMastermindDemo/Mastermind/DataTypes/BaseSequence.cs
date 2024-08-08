using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public interface ISequence
    {
        int Length { get; }
        int[] Digits { get; }
    }

    public abstract class BaseSequence
    {
        protected int _numberOfOptions;

        public int Length => Digits.Length;

        public int[] Digits
        {
            get;
            private set;
        }

        public BaseSequence(int length, int numberOfOptions)
        {
            Digits = new int[length];
            _numberOfOptions = numberOfOptions;
        }
    }
}
