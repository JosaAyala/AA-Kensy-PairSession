using System;

namespace PairSession
{
    public class PairSessionClass
    {
        public bool EvaluateNumberIsMultipleOfTwo(int paramNumber)
        {
            if (paramNumber % 2 == 0)
            {
                return true;
            };
            return false;
        }
    }
}
