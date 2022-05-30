namespace FigureArea
{
    /// <summary>
    /// Базовый класс для всех фигур
    /// </summary>
    public abstract class Figure
    {
        public double Area => CalculateArea();

        public abstract double CalculateArea();
    }
}