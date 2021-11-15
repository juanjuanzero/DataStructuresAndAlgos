using System;
using Xunit;
using StringManipulation;

namespace TestStringManipulation
{
    public class SpecialStringAgainTest
    {
        [Fact]
        public void Test0()
        {
            string s = "aaaa";
            var b = SpecialStringAgain.substrCount(4, s);
            Assert.Equal(10, b);
        }
        [Fact]
        public void Test1()
        {
            string s = "mnonopoo";
            var b = SpecialStringAgain.substrCount(s.Length, s);
            Assert.Equal(12, b);
        }
        [Fact]
        public void Test2()
        {
            string s = "asasd";
            var b = SpecialStringAgain.substrCount(s.Length, s);
            Assert.Equal(7, b);
        }
        [Fact]
        public void Test3()
        {
            string s = "abcbaba";
            var b = SpecialStringAgain.substrCount(s.Length, s);
            Assert.Equal(10, b);
        }
        
    }
}
