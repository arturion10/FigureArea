using FigureArea;

namespace TestLib
{
    public class TriangleTest
    {
        [Fact]
        public void GetArea_Test()
        {
            Assert.Equal(0.4330127018922193, new Triangle(1, 1, 1).GetArea());
            Assert.Equal(6, new Triangle(3, 4, 5).GetArea());
        }
        [Fact]
        public void IsItARightTriangle_Test()
        {
            Assert.True(new Triangle(3, 4, 5).IsItARightTriangle());
            Assert.True(new Triangle(12, 13, 5).IsItARightTriangle());
            Assert.True(new Triangle(13, 12, 5).IsItARightTriangle());
            Assert.False(new Triangle(13, 13, 5).IsItARightTriangle());
        }
    }
}