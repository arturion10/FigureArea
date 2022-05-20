using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Figure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public override double GetArea()
        {
            double p = (ASide + BSide + CSide) / 2;
            Area = Math.Sqrt(p*(p-ASide)*(p-BSide)*(p-CSide));
            return Area;
        }
        public bool IsItARightTriangle()
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
