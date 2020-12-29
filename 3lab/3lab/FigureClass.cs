using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    abstract partial class FigureClass : IComparable
    {
        private string _Type;

        public string Type
        {
            get { return this._Type; }
            set { this._Type = value; }
        }

        abstract public double Area();

        public override string ToString()
        {
            //Console.WriteLine(this.Type + ":");
            return this.Type + " с площадью " + this.Area().ToString();

        }

        public int CompareTo(object obj)
        {
            FigureClass p = (FigureClass)obj;
            if (this.Area() > p.Area())
            {
                return 1;
            }
            else if (this.Area() < p.Area())
            {
                return -1;
            }
            else if (this.Area() == p.Area())
            {
                return 0;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}

