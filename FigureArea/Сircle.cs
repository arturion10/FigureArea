using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Сircle : Figure
    {
        public double Radius { get; set; }

        public Сircle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
