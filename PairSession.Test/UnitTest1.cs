using System;
using Xunit;

namespace PairSession.Test
{
    public class UnitTest1
    {
        [Fact]
        public void WhenSendOneIsSuccess()
        {
            Class1 class1 = new Class1();

            int paramNumber = 1;

            bool result = class1.EvaluateNumbers(paramNumber);

            Assert.Equal(result, true);
        }

        [Fact]
        public void WhenNoSendOneIsNotSuccess()
        {
            Class1 class1 = new Class1();

            int paramNumber = 2;

            bool result = class1.EvaluateNumbers(paramNumber);

            Assert.Equal(result, true);
        }
    }
}
