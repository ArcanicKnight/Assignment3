using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Extension_TestOneLinerFlatten_Return1_2_3_5_6_7()
        {
            // Arrange
            var stream1 = new [] {1, 2, 3};
            var stream2 = new [] {5, 6, 7}; 
            IEnumerable<int>[] xs = {stream1, stream2};
            var expected = new[] {1, 2, 3, 5, 6, 7};
            
            // Act
            var result = xs.SelectMany(x => x);

            // Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void Extension_TestOneLinerFilter_Return49_70()
        {
            // Arrange
            var ys = new []{49, 51, 7, 39, 70};
            var expected = new[] {49, 70};
            
            // Act
            var result = ys.Where(y => y > 42 && y % 7 == 0);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Extension_TestOneLinerFilter_ReturnLeapYears()
        {
            // Arrange
            int[] ys = {1600, 1604, 1700, 1900, 2000};
            var expected = new[] {1600, 1604, 2000};
            
            // Act
            var result = ys.Where(y => DateTime.IsLeapYear(y));
            
            // Assert
            Assert.Equal(expected,result);
        }

        [Fact]
        public void Extension_TestIsSecure_GivenUriWithHttps_ReturnTrue()
        {
            // Arrange
            var uri = new Uri("https://github.itu.dk/BDSA2021");

            // Act
            var result = Extensions.IsSecure(uri);
            
            // Assert
            Assert.True(result);
        }
        
        [Fact]
        public void Extension_TestIsSecure_GivenUriWithHttp_ReturnFalse()
        {
            // Arrange
            var uri = new Uri("http://github.itu.dk/BDSA2021");

            // Act
            var result = Extensions.IsSecure(uri);
            
            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("Hej med dig",3)]
        [InlineData("H3jmedD1g",3)]
        [InlineData("123%#!hej=)(//",1)]
        public void Extension_TestWordCount_ReturnNumberOfWords(string str, int expected)
        {
            // Act
            var result = Extensions.WordCount(str);
            
            // Assert
            Assert.Equal(expected,result);
        }
    }
}