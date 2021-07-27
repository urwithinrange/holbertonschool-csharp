using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class UniqueCharTests
    {
        [Test]
        public void FindUniqueChar_IsCharAtBeginning_ReturnEquals0()
        {
            string str = "abbccdd";
            int i = Str.UniqueChar(str);
            Assert.AreEqual(i, 0);
        }
        [Test]
        public void FindUniqueChar_CharInTheMiddle_ReturnEquals3()
        {
            string str = "bbcacdd";
            int i = Str.UniqueChar(str);
            Assert.AreEqual(i, 3);
        }
        [Test]
        public void FindUniqueChar_CharAreNotUnique_ReturnEqualsNeg1()
        {
            string str = "bbcaacdd";
            int i = Str.UniqueChar(str);
            Assert.AreEqual(i, -1);
        }
    }
}