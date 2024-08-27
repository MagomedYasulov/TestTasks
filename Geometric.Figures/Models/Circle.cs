using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Figures.Models
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public double Diameter => Radius * 2; 

        public Circle(double radius) 
        {
            if (radius <= 0)
                throw new ArgumentException("Invalid circle radius");
            
            Radius = radius;
        }

        /// <summary>
        /// P = 2 · π · r
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// S = π × r * r
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() => "Circle";
    }
}
