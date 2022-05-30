
namespace TestLib
{
    public class TriangleTest
    {
        [Fact]
        public void GetArea_Test()
        {
            Assert.Equal(0.4330127018922193, new Triangle(1, 1, 1).CalculateArea());
            Assert.Equal(6, new Triangle(3, 4, 5).CalculateArea());
        }
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(12, 13, 5)]
        [InlineData(5, 4, 3)]
        [InlineData(5, 3, 4)]
        [InlineData(4, 5, 3)]
        [InlineData(4, 3, 5)]
        [InlineData(3, 5, 4)]
        public void IsItARightTriangle_Test(int a, int b, int c)
        {
            Assert.True(new Triangle(a, b, c).IsRightTriangle());
        }
    }
}