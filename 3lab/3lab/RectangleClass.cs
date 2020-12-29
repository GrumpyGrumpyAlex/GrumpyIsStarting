using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{

    class RectangleClass : FigureClass, Interface1
    {
        protected double Width;
        protected double Height;
        public RectangleClass(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            return Width * Height;
        }

        ///// Переопределенный метод преобразования в строку
        //public override string ToString()
        //{
        //    return "Прямоугольник: ширина = " + this.Width + "; высота = " + this.Height +
        //           "; площадь: " + this.Area();
        //}

        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("Высота: " + this.Height);
            Console.WriteLine("Ширина: " + this.Width);
        }
    }
}
