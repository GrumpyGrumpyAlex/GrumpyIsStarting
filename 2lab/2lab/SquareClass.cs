using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    class SquareClass : RectangleClass, IPrint
    {

        public SquareClass(double width) :
            base(width, width)
        {

        }

        public override double Area()
        {
            return this.Width * this.Width;
        }

        public override string ToString()
        {
            return "Квадрат: сторона = " + this.Width + "; площадь = " + this.Area();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}