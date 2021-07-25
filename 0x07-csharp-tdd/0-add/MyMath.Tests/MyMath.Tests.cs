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
            // act
            sum_total = Operations.Add(1, 2);
            // assert
            Assert.IsInstanceOf<int>( sum_total, "Integer is being returned");
        }
    }
}