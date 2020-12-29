using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    class RectangleClass : FigureClass, IPrint
    {
        protected double Width;

        protected double Height;

        public RectangleClass(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Прямоугольник: ширина = " + this.Width + ", высота = " + this.Height +
                   ", площадь: " + this.Area() + ".";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}