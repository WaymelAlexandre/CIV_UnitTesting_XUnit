using System;
using Xunit;
using CalcLib;

namespace unittest
{
    public class UnitTest1
    {
        private const bool V = false;

        //Create Unit Tests using xUnit for the methods 
        // FibonnacciRec,
        // FactorialRec
        // PrimeCheckRec.

        RecursiveCalc Rec = new RecursiveCalc();



        [Fact]
        public void testNumIsFibona()
        {
            Assert.Equal(5, Rec.FibonacciRec(2, 3, 0));
        }
        [Fact]
        public void TestIsFactorial()
        {
            Assert.Equal(18, Rec.FactorialRec(3, 3));
        }
        [Fact]
        public void TestIsPrimalTrue()
        {

            Assert.True(true.Equals(Rec.PrimeCheckRec(5, 5)));

        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Zero_test(int divisor)
        {
            Assert.Throws<DivideByZeroException>(() => Rec.PrimeCheckRec(10000 ,divisor));

        }
    }
}
