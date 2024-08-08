using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMastermindDemo.Mastermind.DataTypes
{
    public class Result
    {
        public int MatchingNumber { get; }
        public int MatchingPlacements { get; }

        public bool Won { get; }

        public Result(IAwnserSequence awnserSequence, IInputSequence userSequence) 
        {
            var countOfUnseenNumbers = new Dictionary<int, int>();

            if (awnserSequence.Length == userSequence.Length)
            {
                for (int i = 0; i < awnserSequence.Length; i++)
                {
                    if (!countOfUnseenNumbers.ContainsKey(awnserSequence.Digits[i]))
                    {
                        countOfUnseenNumbers[awnserSequence.Digits[i]] = 1;
                    }
                    else
                    {
                        countOfUnseenNumbers[awnserSequence.Digits[i]]++;
                    }
                }

                for (int i = 0; i < awnserSequence.Length; i++)
                {
                    if(awnserSequence.Digits[i] == userSequence.Digits[i])
                    {
                        MatchingPlacements++;
                    }
                    if (countOfUnseenNumbers.ContainsKey(userSequence.Digits[i]) && countOfUnseenNumbers[userSequence.Digits[i]] > 0)
                    {
                        countOfUnseenNumbers[userSequence.Digits[i]]--;
                        MatchingNumber++;
                    }
                }
            }

            Won = MatchingPlacements == awnserSequence.Length;
        }
    }
}
