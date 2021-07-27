using NUnit.Framework;

namespace Text.Tests
{
    public class CamelCaseTests
    {
        [Test]
        public void CamelCase_MultipleWords_ReturnEquals4()
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
        [Test]
        public void CamelCase_OneWord_ReturnEquals1()
        {
            int i = Str.CamelCase("whatever");
            Assert.AreEqual(i, 1);
        }
        [Test]
        public void CamelCase_TwoWords_ReturnEquals2()
        {
            int i = Str.CamelCase("twoWords");
            Assert.AreEqual(i, 2);
        }
    }
}