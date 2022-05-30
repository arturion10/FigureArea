namespace FigureArea
{
    public class Triangle : Figure
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide < 0 || bSide < 0 || cSide < 0)
                throw new ArgumentOutOfRangeException();


            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public override double CalculateArea()
        {
            var p = (ASide + BSide + CSide) / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        /// <summary>
        /// Проверка осуществляется по теореме Пифагора.
        /// </summary>
        public bool IsRightTriangle()
        {
            if (ASide > BSide)
                if (ASide > CSide)
                    return ASide * ASide == CSide * CSide + BSide * BSide;
                else
                    return CSide * CSide == ASide * ASide + BSide * BSide;
            else
                if (BSide > CSide)
                return BSide * BSide == CSide * CSide + ASide * ASide;
            return CSide * CSide == ASide * ASide + BSide * BSide;
        }
    }
}