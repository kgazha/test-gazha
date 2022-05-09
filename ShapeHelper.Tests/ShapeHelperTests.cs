﻿using ShapeHelper.Behaviours;
using ShapeHelper.Domain;
using ShapeHelper.Interfaces;
using System;
using Xunit;

namespace ShapeHelper.Tests
{
    public class ShapeHelperTests
    {
        [Fact]
        public void Triangle_Square_By_Edges()
        {
            IShape triangle = new Triangle(3, 4, 5);

            var actualResult = triangle.GetSquare();

            Assert.Equal(6, actualResult);
        }

        [Fact]
        public void Triangle_Square_By_Base_And_Height()
        {
            IShape triangle = new Triangle(4, 7);

            var actualResult = triangle.GetSquare();

            Assert.Equal(14, actualResult);
        }

        [Fact]
        public void Triangle_HasRightAngle_Returns_True()
        {
            IAngularShape triangle = new Triangle(3, 4, 5);

            var actualResult = triangle.HasRightAngle();

            Assert.True(actualResult);
        }

        [Fact]
        public void Triangle_HasRightAngleReturns_False()
        {
            IAngularShape triangle = new Triangle(5, 8, 6);

            var actualResult = triangle.HasRightAngle();

            Assert.False(actualResult);
        }

        [Fact]
        public void Triangle_Throws_Parameters_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleWithBaseAndHeight(-4, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleWithEdges(5, -4, 0));
        }

        [Fact]
        public void Circle_Square_By_Radius()
        {
            IShape circle = new Circle(3);

            var actualResult = circle.GetSquare();

            Assert.Equal(28.274, actualResult, 3);
        }

        [Fact]
        public void Circle_Throws_Parameters_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-4));
        }
    }
}