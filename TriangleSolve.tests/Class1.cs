using NUnit.Framework;
using TriangleSolverAssignment2;

namespace TriangleSolve.tests
{
    [TestFixture]
    public class TriangleTest
    {
        private Triangle triangle;

        [SetUp]
        public void Setup()
        {
            triangle = new Triangle();
        }

        [TestFixture]
        public class TriangleTests
        {
            [Test]
            public void EquilateralTriangle_ValidResponse_Test()
            {
                // Arrange
                int firstSide = 5, secondSide = 5, thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
            }

            

            [Test]
            public void ScaleneTriangle_ValidResponse_Test1()
            {
                // Arrange
                int firstSide = 3, secondSide = 4, thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test2()
            {
                // Arrange
                int firstSide = 7, secondSide = 9, thirdSide = 11;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test3()
            {
                // Arrange
                int firstSide = 5, secondSide = 12, thirdSide = 13;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test4()
            {
                // Arrange
                int firstSide = 10, secondSide = 11, thirdSide = 12;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ScaleneTriangle_ValidResponse_Test5()
            {
                // Arrange
                int firstSide = 2, secondSide = 4, thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("The triangle is valid and is a SCALENE", result);
            }

            [Test]
            public void ZeroLengthSide_InvalidResponse_Test1()
            {
                // Arrange
                int firstSide = 0, secondSide = 4, thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }

            [Test]
            public void ZeroLengthSide_InvalidResponse_Test2()
            {
                // Arrange
                int firstSide = 3, secondSide = 0, thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }

            [Test]
            public void ZeroLengthSide_InvalidResponse_Test3()
            {
                // Arrange
                int firstSide = 3, secondSide = 4, thirdSide = 0;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", result);
            }

            [Test]
            public void InvalidResponse_InvalidResponse_Test1()
            {
                // Arrange
                int firstSide = 2, secondSide = 3, thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void InvalidResponse_InvalidResponse_Test2()
            {
                // Arrange
                int firstSide = 1, secondSide = 1, thirdSide = 3;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }

            [Test]
            public void InvalidResponse_InvalidResponse_Test3()
            {
                // Arrange
                int firstSide = 5, secondSide = 9, thirdSide = 2;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.AreEqual("A triangle cannot be formed with those numbers", result);
            }
        }
    }
}