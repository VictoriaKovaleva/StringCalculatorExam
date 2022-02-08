using System;
using Xunit;

namespace StringCalculator.Test
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenStringIsEmpty()
        {
            int actual = StringCalc.Add("");
            
            Assert.Equal(0, actual);
        }
    }
}