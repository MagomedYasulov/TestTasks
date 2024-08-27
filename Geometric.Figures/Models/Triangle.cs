using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Figures.Models
{
    public class Triangle : Figure
    {
        public double LeftSide { get; private set; }
        public double RightSide { get; private set; }
        public double BaseSide { get; private set; }

        public Triangle(double leftSide, double rightSide, double baseSide) 
        {
            if (!IsValidSides(leftSide, rightSide, baseSide))
                throw new ArgumentException("Invalid triangle sides");

            LeftSide = leftSide;
            RightSide = rightSide;
            BaseSide = baseSide;
        }

        /// <summary>
        /// P = a + b + c
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            return LeftSide + RightSide + BaseSide;
        }

        /// <summary>
        /// Площаль треугольника: S = √(p · (p — a)(p — b)(p — c))
        /// p - Полупермитер треугольника
        /// a,b,c - Стороны треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetSquare()
        {
            var perimeter = GetPerimeter() / 2;
            return Math.Sqrt(perimeter * (perimeter - LeftSide) * (perimeter - RightSide) * (perimeter - BaseSide));
        }

        public bool IsRightTriangle()
        {
            if (Math.Pow(RightSide, 2) == Math.Pow(LeftSide, 2) + Math.Pow(BaseSide, 2))
                return true;
            if (Math.Pow(LeftSide, 2) == Math.Pow(RightSide, 2) + Math.Pow(BaseSide, 2))
                return true;
            if (Math.Pow(BaseSide, 2) == Math.Pow(LeftSide, 2) + Math.Pow(RightSide, 2))
                return true;

            return false;
        }

        private bool IsValidSides(double leftSide, double rightSide, double baseSide)
        {
            if(leftSide <= 0 || rightSide <= 0 || baseSide <= 0)
                return false;

            //Длина любой стороны треугольника всегда меньше суммы длин двух его других сторон
            if (leftSide >= rightSide + baseSide || rightSide >= leftSide + baseSide || baseSide >= leftSide + rightSide)
                return false;

            return true;
        }

        public override string ToString() => "Triangle";
    }
}
