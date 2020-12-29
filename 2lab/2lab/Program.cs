using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2");
            Console.Title = "Рябкин Александр ИУ5Ц-51Б";

            RectangleClass rect = new RectangleClass(4, 9);
            rect.Print();

            SquareClass square = new SquareClass(5);
            square.Print();

            CircleClass circle = new CircleClass(3);
            circle.Print();

            Console.WriteLine("Для выхода нажми любую клавишу...");
            Console.ReadKey();
        }
    }
}

