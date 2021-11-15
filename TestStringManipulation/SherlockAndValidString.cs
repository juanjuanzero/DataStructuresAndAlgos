using System;
using Xunit;
using StringManipulation;

namespace TestStringManipulation
{
    public class SherlockAndValidString
    {
        [Fact]
        public void Test2()
        {
            string s = "abcdefghhgfedecba";
            var b = SherlockAndValidStringSolution.isValid(s);
            Assert.Equal("YES", b);

        }
        [Fact]
        public void Test1()
        {
            string s = "aabbccddeefghi";
            var b = SherlockAndValidStringSolution.isValid(s);
            Assert.Equal("NO", b);
        }
        [Fact]
        public void Test0()
        {
            string s = "aabbcd";
            var b = SherlockAndValidStringSolution.isValid(s);
            Assert.Equal("NO", b);
        }
        [Fact]
        public void Test7()
        {
            string s = "ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd";
            var b = SherlockAndValidStringSolution.isValid(s);
            Assert.Equal("YES", b);
        }
    }
}
