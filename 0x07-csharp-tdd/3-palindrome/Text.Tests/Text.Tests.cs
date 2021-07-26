using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void SimpleString_IsPalindrome_ReturnTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level") == true);
        }
        [Test]
        public void StringWithPunctuation_IsPalindrome_ReturnTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama.") == true);
        }
        [Test]
        public void SimpleString_IsNotPalindrome_ReturnFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("A man, a plan") == false);
        }
    }
}