using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMathTests
    {
        [Test]
        public void Addition_AreInt_ReturnsTrue()
        {
            // arrange
            int sum_total;
            int test_sum = 1 + 2;
            // act
            sum_total = Operations.Add(1, 2);
            // assert
            Assert.AreEqual(sum_total, test_sum);
        }
    }
}