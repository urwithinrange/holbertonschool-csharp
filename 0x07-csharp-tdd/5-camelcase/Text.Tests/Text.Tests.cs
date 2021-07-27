using NUnit.Framework;

namespace Text.Tests
{
    public class CamelCaseTests
    {
        [Test]
        public void CamelCase_NumberOfWords_ReturnEquals4()
        {
            int i = Str.CamelCase("thisIsAString");
            Assert.AreEqual(i, 4);
        }
        [Test]
        public void CamelCase_NoWords_ReturnEquals0()
        {
            int i = Str.CamelCase("");
            Assert.AreEqual(i, 0);
        }
    }
}