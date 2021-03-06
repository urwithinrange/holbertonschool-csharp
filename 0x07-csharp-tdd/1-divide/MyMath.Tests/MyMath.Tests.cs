using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Division Testing folder</summary>
    public class MyMathTests
    {
        [Test]
        /// <summary>Test Matrix.Divide() returns correct output</summary>
        public void test_NumbersNotNull_ReturnTrue()
        {
            // Assign
            int[,] i = new int[,] {{2, 4}, {6, 8}};
            int[,] div = new int [,]{{1, 2},{3, 4}};
            // Act
            Matrix.Divide(i, 2);
            // Assert            
            Assert.AreEqual(div, i);
        }
        [Test]
        /// <summary>Test to determine outcome if num is equal to 0</summary>
        public void test_NumEquals0_ReturnTrue()
        {
            // Assign
            int num = 0;
            int[,] tempMat = new int[,] {{2, 4}, {6, 8}};
            int[,] div;
            // Act
            div = Matrix.Divide(tempMat, num);
            // Assert
            Assert.IsNull(div);
        }
        [Test]
        /// <summary>Test to determine outcome if matrix is null</summary>
        public void test_MatrixIsNull_ReturnTrue()
        {
            // Assign
            int num = 2;
            int[,] tempMat = null;
            int[,] div;
            // Act
            div = Matrix.Divide(tempMat, num);
            // Assert
            Assert.IsNull(div);
        }
    }
}