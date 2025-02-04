using NUnit.Framework;
using DemoPipeline.App;

namespace DemoPipeline.Tests
{
    public class UnitTest1
    {
        [Test]
        public void Add_ShouldReturnSumOfTwoIntegers()
        {
            // Arrange
            int x = 2;
            int y = 3;

            // Act
            int result = Program.Add(x, y);

            // Assert
            Assert.That(result, Is.EqualTo(5));

        }

        [Test]
        public void Add_ShouldFailForDemo()
        {
            Assert.Pass("Remove or modify this test to force a failure for demonstration");
        }
    }
}
