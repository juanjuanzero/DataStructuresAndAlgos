using System;
using Xunit;
using StringManipulation;

namespace TestStringManipulation
{
    public class CommonChildTest
    {
        [Fact]
        public void Test0()
        {
            string s1 = "HARRY", s2 = "SALLY";
            var b = CommonChild.commonChild(s1, s2);
            Assert.Equal(2, b);
        }

        [Fact]
        public void Test1()
        {
            string s1 = "ABCD", s2 = "ABDC";
            var b = CommonChild.commonChild(s1, s2);
            Assert.Equal(3, b);
        }

        [Fact]
        public void Test2()
        {
            string s1 = "AA", s2 = "BB";
            var b = CommonChild.commonChild(s1, s2);
            Assert.Equal(0, b);
        }
        [Fact]
        public void Test3()
        {
            string s1 = "SHINCHAN", s2 = "NOHARAAA";
            var b = CommonChild.commonChild(s1, s2);
            Assert.Equal(3, b);
        }
    }
}
