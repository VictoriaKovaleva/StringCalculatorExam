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

        [Fact]
        public void ReturnOneWhenStringIsOne()
        {
            int actual = StringCalc.Add("1");
            
            Assert.Equal(1, actual);
        }
        
        [Fact]
        public void ReturnTwoWhenStringIsTwo()
        {
            int actual = StringCalc.Add("2");
            
            Assert.Equal(2, actual);
        }
        
    }
}