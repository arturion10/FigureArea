// МОжно прописать автора и описание сборки в ее свойствах

// Naming calsses
// Arturion10.Geometry.FigureArea.Сircle
// SolutionName: Arturion10.Geometry
// AssemblyName: Arturion10.Geometry.FigureArea
// DeveloperName.AppName.SubAppName.AssemblyName.SubAssemblyName.TypeName

// FigureAreaTests
namespace FigureArea
{
    public class Сircle : Figure
    {
        private readonly double _maxRadius = Math.Sqrt(Double.MaxValue / Math.PI);
        public readonly double Radius;

        public Сircle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException();

            if (radius > _maxRadius)
                throw new ArgumentOutOfRangeException();

            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
