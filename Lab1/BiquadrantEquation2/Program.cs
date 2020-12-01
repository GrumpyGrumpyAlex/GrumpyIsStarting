using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiquadrantEquation2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Разработчик: Рябкин А.В., группа ИУ5Ц-51Б");
            double a, b, c, d, x1, x2, x3, x4;
            if (args.Length == 0)
            {
                Console.WriteLine("Введите первый коэффициент A при х в 4 степени: ");
                a = Input();
                if (a == 0)
                {
                    Console.WriteLine("В биквадратном уравнении первый коэффициент никогда не равен нулю");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Введите второй коэффициент B при х в 2 степени: ");
                b = Input();
                Console.WriteLine("Введите последний коэффициент C: ");
                c = Input();
            }
            else
            {
                Console.WriteLine("Используются параметры командной строки:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine("Параметр " + (i + 1) + " = " + args[i]);
                }
                if (args.Length == 3)
                {
                    a = InputArgs(args[0], 1);
                    b = InputArgs(args[1], 2);
                    c = InputArgs(args[2], 3);
                }
                else
                {
                    Console.WriteLine("Некорректные параметры командной строки");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine(a + "*x^4 + " + b + "*x^2 + " + c + " = 0");
            Console.ReadLine();

            //найти корни
            if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Это не уравнение!");
                Console.ReadLine();
                return;
            }
            else
            {
                d = b * b - 4 * a * c;
                Console.WriteLine("Дискриминат: " + d);
                if (d >= 0 && -b + Math.Sqrt(d) >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a));
                    x2 = -Math.Sqrt((-b + Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    if (-b - Math.Sqrt(d) >= 0)
                    {
                        x3 = Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a));
                        x4 = -Math.Sqrt((-b - Math.Sqrt(d)) / (2 * a));
                        Console.WriteLine("x3 = " + x3);
                        Console.WriteLine("x4 = " + x4);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("x3 и x4 корни не существуют");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Решений данного уравнения не существует");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadLine();
                }
            }
        }

        //Тут проверяем корректность ввода
        static double Input()
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                resultString = Console.ReadLine();
                try
                {
                    resultDouble = double.Parse(resultString);
                    flag = true;
                }
                catch
                {
                    resultDouble = 0;
                    flag = false;
                }
                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод. Необходимо ввести вещественное число");
                }
            }
            while (!flag);
            return resultDouble;
        }

        //Проверяем корректность ввода аргументов командной строки(доп. требование)
        static double InputArgs(string resultString, int num)
        {
            double resultDouble;
            bool flag;
            do
            {
                flag = double.TryParse(resultString, out resultDouble);
                if (!flag)
                {
                    Console.WriteLine("Некорректное значение аргумента коммандно строки #" + num);
                }
            }
            while (!flag);
            return resultDouble;
        }
    }
}