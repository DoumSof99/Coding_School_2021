using Session_23_ClassLibraryFibonacci;
using System;
using Xunit;

namespace ClassLibraryFibonacci.Test {
    public class FibonacciCalculateTests {

        private FibonacciCalculator CreateDefaultSUT() {
            var sut = new FibonacciCalculator();
            return sut;
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(20, 6765)]
        [InlineData(31, 1346269)]
        [InlineData(42, 267914296)]
        [InlineData(53, 53316291173)]
        [InlineData(64, 10610209857723)]
        [InlineData(75, 2111485077978050)]
        public void CalculateResult_PossitiveFibonacciNumberIsGiven_ReturnsResultCorrectly(long fibNumber, long expected) {
            
            //Arrange
            var sut = CreateDefaultSUT();

            //Act
            var actual = sut.FibonacciSerries(fibNumber);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(-2)]
        [InlineData(95)]
        public void CalculateResult_NegativeAndAbove90ValueIsGiven_ThrowsArgumentException(long fibNumber) {
            //Arrange
            var sut = CreateDefaultSUT();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSerries(fibNumber);
            });
        }

        //Example for single number
        //[Fact]
        //public void CalculateFibonacciNumber_FibonacciNumber4IsGiven_Returns2Number() {

        //    //Arrange
        //    long fibNumber = 9;
        //    long expected = 34;
        //    var sut = CreateDefaultSUT();

        //    //Act
        //    var actual = sut.CalculateFibonacciNumber(fibNumber);

        //    //Assert
        //    Assert.Equal(expected, actual);

        //}
    }
}
