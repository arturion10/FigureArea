using FigureArea;

namespace TestLib
{
    public class CircleTest
    {
        [Fact]
        public void GetArea_Test()
        {
            Assert.Equal(Math.PI, new Сircle(1).GetArea());
            Assert.Equal(3631.6811, Math.Round(new Сircle(34).GetArea(), 4));
        }
    }
}
