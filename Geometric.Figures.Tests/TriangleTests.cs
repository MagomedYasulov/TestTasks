using Geometric.Figures.Models;

namespace Geometric.Figures.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Get_Triangle_Square()
        {
            // Arrange
            var triangle = new Triangle(4,6,8);

            // Act
            var square = triangle.GetSquare();

            // Assert
            Assert.Equal(11.61895003862225, square);
        }

        [Fact]
        public void Get_Triangle_Perimeter()
        {
            // Arrange
            var triangle = new Triangle(2, 3, 4);

            // Act
            var perimeter = triangle.GetPerimeter();

            // Assert
            Assert.Equal(9, perimeter);
        }

        [Fact]
        public void Is_Triangle_Right()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRight);
        }

        [Fact]
        public void Is_Triangle_Not_Right()
        {
            // Arrange
            var triangle = new Triangle(2, 3, 4);

            // Act
            var isRight = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRight);
        }

        [Fact]
        public void Create_Triangle_With_Invalid_Sides()
        {
            // Arrange

            // Act
            Action act1 = () => new Triangle(2, 3, 100);
            Action act2 = () => new Triangle(2, 100, 3);
            Action act3 = () => new Triangle(100, 2, 3);

            Action act4 = () => new Triangle(-2, 3, 4);
            Action act5 = () => new Triangle(2, -3, 4);
            Action act6 = () => new Triangle(2, 3, -4);

            // Assert
            ArgumentException exception1 = Assert.Throws<ArgumentException>(act1);
            ArgumentException exception2 = Assert.Throws<ArgumentException>(act2);
            ArgumentException exception3 = Assert.Throws<ArgumentException>(act3);
            ArgumentException exception4 = Assert.Throws<ArgumentException>(act4);
            ArgumentException exception5 = Assert.Throws<ArgumentException>(act5);
            ArgumentException exception6 = Assert.Throws<ArgumentException>(act6);

            var message = "Invalid triangle sides";
            Assert.Equal(message, exception1.Message);
            Assert.Equal(message, exception2.Message);
            Assert.Equal(message, exception3.Message);
            Assert.Equal(message, exception4.Message);
            Assert.Equal(message, exception5.Message);
            Assert.Equal(message, exception6.Message);
        }

    }
}