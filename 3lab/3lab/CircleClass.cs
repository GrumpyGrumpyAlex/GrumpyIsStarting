using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class CircleClass : FigureClass, Interface1
    {
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { this._Radius = value; }
        }

        public CircleClass(double radius)
        {
            this.Radius = radius;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        ///// Переопределенный метод преобразования в строку
        //public override string ToString()
        //{
        //    return "Круг: радиус = " + this.Radius + "; площадь = " + this.Area();
        //}

        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine("Радиус: " + this.Radius);
        }
    }
}
