using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public abstract class BaseSequence
    {
        private int _numberOfOptions;

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

        public void GenerateRandomValues()
        {
            for (int i = 0; i < Digits.Length; i++)
            {

            }
        }
    }
}
