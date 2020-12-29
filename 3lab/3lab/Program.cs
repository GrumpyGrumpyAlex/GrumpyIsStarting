using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3");

            Console.Title = "Рябкин Александр ИУ5Ц-51Б";

            RectangleClass rect = new RectangleClass(2, 4);
            rect.Print();

            SquareClass square = new SquareClass(5);
            square.Print();

            CircleClass circle = new CircleClass(3);
            circle.Print();


            ArrayList figures = new ArrayList();
            figures.Add(circle);
            figures.Add(rect);
            figures.Add(square);
            Console.WriteLine("\nДо сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }
            figures.Sort();
            Console.WriteLine("\nПосле сортировки для ArrayList");
            foreach (var i in figures)
            {
                Console.WriteLine(i);
            }

            List<FigureClass> figures1 = new List<FigureClass>();
            figures1.Add(circle);
            figures1.Add(rect);
            figures1.Add(square);
            Console.WriteLine("\n\nДо сортировки для List<Figure>:");
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nПосле сортировки для List<Figure>:");
            figures1.Sort();
            foreach (var i in figures1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\nМатрица:");
            Matrix<FigureClass> matrix = new Matrix<FigureClass>(3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0] = rect;
            matrix[1, 1] = square;
            matrix[2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            SimpleList<FigureClass> list = new SimpleList<FigureClass>();
            list.Add(circle);
            list.Add(rect);
            list.Add(square);
            Console.WriteLine("\n\nПеред сортировкой (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }
            list.Sort();
            Console.WriteLine("\n\nПосле сортировки (SimpleList):");
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            SimpleStack<FigureClass> stack = new SimpleStack<FigureClass>();
            stack.Push(circle);
            stack.Push(rect);
            stack.Push(square);
            Console.WriteLine("\n\nИспользование стека:");
            while (stack.Count > 0)
            {
                FigureClass f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}

