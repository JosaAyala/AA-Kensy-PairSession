using System;
using Xunit;

namespace PairSession.Test
{
    public class PairSessionTest
    {
        [Fact]
        public void WhenSendPairNumber()
        {
            PairSessionClass _pairSessionClass = new PairSessionClass();

            int paramNumber = 4;

            bool result = _pairSessionClass.EvaluateNumberIsMultipleOfTwo(paramNumber);

            Assert.Equal(result, true);
        }

        [Fact]
        public void WhenNoSendPairNumber()
        {
            PairSessionClass _pairSessionClass = new PairSessionClass();

            int paramNumber = 3;

            bool result = _pairSessionClass.EvaluateNumberIsMultipleOfTwo(paramNumber);

            Assert.Equal(result, true);
        }
    }
}
