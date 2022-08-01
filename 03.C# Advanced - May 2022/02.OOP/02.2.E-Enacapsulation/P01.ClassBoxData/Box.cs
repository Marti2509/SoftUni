using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            private set 
            {
                IsValid(value, "Length");
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                IsValid(value, "Width");
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                IsValid(value, "Height");
                height = value;
            }
        }

        public double SurfaceArea()
        {
            double area = 2 * Length * Width  + 2 * Length * Height + 2 * Width * Height;
            return area;
        }

        public double LateralSurfaceArea()
        {
            double area = 2 * Length * Height + 2 * Width * Height;
            return area;
        }

        public double Volume()
        {
            double volume = Length * Width * Height;
            return volume;
        }

        private void IsValid(double value, string name)
        {
            if (value <= 0)
                throw new ArgumentException($"{name} cannot be zero or negative.");
        }
    }
}
