using System;
using System.Runtime.InteropServices;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        delegate string DelegateReverse(string s);

        delegate decimal DelegateProduct(decimal x, decimal y);

        delegate bool DelegateEqual(string s, decimal n);

        static string Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static decimal Product(decimal x, decimal y)
        {
            return x * y;
        }

        static bool Equal(string s, decimal n)
        {
            return Decimal.Parse(s) == n;
        }

        [Theory]
        [InlineData("Hej med dig","gid dem jeH")]
        [InlineData("12345lol","lol54321")]
        [InlineData("=+?@%","%@?+=")]
        public void Delegates_TestReverseString_ReturnReversedString(string input, string expected)
        {
            // Act
            DelegateReverse test = (x) => { return Reverse(x); };
            var result = test(input);
            
            // Assert
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData(10,0.5,5)]
        [InlineData(4,0.99,3.96)]
        public void Delegates_TestProduct_ReturnProduct(decimal x, decimal y, decimal expected)
        {
            // Act
            DelegateProduct test = (x, y) => { return Product(x, y); };
            var result = test(x, y);
            
            // Assert
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData("0056",56,true)]
        [InlineData("009090",9090,true)]
        [InlineData("32,56",32.56,true)]
        [InlineData("10",5,false)]
        public void Delegates_TestEqual_ReturnTrueOrFalse(string s, decimal n, bool expected)
        {
            // Act
            DelegateEqual test = (x, y) => { return Equal(x, y); };
            var result = test(s, n);
            
            // Assert
            Assert.Equal(expected, result);
        }
    }
}