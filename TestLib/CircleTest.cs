namespace TestLib
{
    public class CircleTest
    {
        [Theory]
        [InlineData(3.1416, 1)]
        [InlineData(3631.6811, 34)]
        public void GetArea_HappyPath(double aria, double radius)
        {
            Assert.Equal(aria, Math.Round(new Сircle(radius).Area, 4));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(double.MaxValue)]
        public void GetArea_InvalidRadius_Exception(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Сircle(radius));
        }
    }
}
