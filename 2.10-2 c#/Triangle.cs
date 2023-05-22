using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2._10
{
    public class Triangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double FirstSide, double SecondSide, double ThirdSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThirdSide = ThirdSide;
        }

        public double Perimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }

        public double Square()
        {
            double semiPerimeter = Perimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }

        public Tuple<double, double> GetMedianIntersection()
        {

            double x = (FirstSide + SecondSide + ThirdSide) / 3;
            double y = Square() * 2 / (FirstSide + SecondSide + ThirdSide);
            return Tuple.Create(x, y);

        }
    }
}
