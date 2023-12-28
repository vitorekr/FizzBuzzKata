using System;
using Xunit;

namespace KataDevelopment.FizzBuzz.FizzBuzz
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(35, "Buzz")]
        public void convert_Int_to_String(int number, string expectedString)
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(expectedString, fizzBuzz.Convert(number));
        }

        [Fact]
        public void convert_15_to_FizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("FizzBuzz", fizzBuzz.Convert(15));
        }
    }
}