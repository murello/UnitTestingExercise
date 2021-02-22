using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 10, 10, 30)]
        [InlineData(100, 100, 100, 300)]
        [InlineData(-1, 6, -3, 2)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(10, 5, 5)]
        [InlineData(100, 25, 75)]
        [InlineData(-4, -6, 2)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 5, 5)]
        [InlineData(10, 10, 100)]
        [InlineData(5, 5, 25)]
        [InlineData(-5, -5, 25)]
        [InlineData(3, 3, 9)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(7, 1, 7)]
        [InlineData(100, 5, 20)]
        [InlineData(9, 3, 3)]
        [InlineData(7, -1, -7)]

        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void IsCharSymbol()
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();
            string symbols = "$~^+<>";

            foreach(char character in symbols)
            {
                //Act
                bool isSymbolActual = tester.IsCharSymbol(character);
                //Assert
                Assert.True(isSymbolActual);

            }
            

        }

        [Fact]
        public void IsCharNotSymbol()
        {
            //Arrange
            UnitTestMethods tester = new UnitTestMethods();
            string lettersAndNums = "0123456789abcdefghijklmnopqrstuvwxyz";
            foreach (char character in lettersAndNums)
            {
                //Act
                var actual = tester.IsCharNotSymbol(character);


                //Assert
                Assert.True(actual);


            }




            
        }
    }
}
