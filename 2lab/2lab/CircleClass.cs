using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    class CircleClass : FigureClass, IPrint
    {
        protected double Radius;

        public CircleClass(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        //Переопределенный метод преобразования в строку
        public override string ToString()
        {
            return "Круг: радиус = " + this.Radius + "; площадь = " + this.Area();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

