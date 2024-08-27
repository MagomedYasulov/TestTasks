using Geometric.Figures.Models;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric.Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Get_Circle_Square()
        {
            // Arrange
            var circle = new Circle(4);

            // Act
            var square = circle.GetSquare();

            // Assert
            Assert.Equal(50.265482457, Math.Round(square,9));
        }

        [Fact]
        public void Get_Circle_Perimeter()
        {
            // Arrange
            var circle = new Circle(4);

            // Act
            var perimeter = circle.GetPerimeter();

            // Assert
            Assert.Equal(25.13274, Math.Round(perimeter, 5));
        }


        [Fact]
        public void Create_Circle_With_Invalid_Radius()
        {
            // Arrange

            // Act
            Action act = () => new Circle(-4);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Invalid circle radius", exception.Message);
        }

    }
}
