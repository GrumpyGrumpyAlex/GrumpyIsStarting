using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class SquareClass : RectangleClass, Interface1
    {
        public SquareClass(double width) :
            base(width, width)
        { this.Type = "Квадрат"; }

        ///// Площадь квадрата
        //public override double Area()
        //{
        //    return this.Width * this.Width;
        //}

        ///// Переопределенный метод преобразования в строку
        //public override string ToString()
        //{
        //    return "Квадрат: сторона = " + this.Width + "; площадь = " + this.Area();
        //}

        ///// Метод вывода на консоль
        //public void Print()
        //{
        //    Console.WriteLine(this.ToString());
        //}
    }
}

