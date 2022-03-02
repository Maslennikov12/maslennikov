using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double x0, y0, x, y;
            Krug newkrug = new Krug();
            Console.WriteLine("Введите радиус: ");
            newkrug.Radius = Convert.ToInt32(Console.ReadLine());
            // проверка на ноль
            if (newkrug.Radius == 0)
            {
                Console.WriteLine("Радиус не может быть равен нулю");
                Console.ReadKey();
            }
            // проверка на ввод отрицательного радиуса
            else if (newkrug.Radius < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("x0 = ");
                newkrug.X0 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y0 = ");
                newkrug.Y0 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("x = ");
                newkrug.X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y = ");
                newkrug.Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Площадь окружности = " + newkrug.S(newkrug.Radius)); //  вывод площади
                Console.WriteLine("Длина окружности = " + newkrug.Line(newkrug.Radius)); // вывод длины окружности
                if (newkrug.prin(newkrug.X, newkrug.Y, newkrug.X0, newkrug.Y0, newkrug.Radius))
                    Console.WriteLine("Точка принадлежит окружности");
                else
                    Console.WriteLine("Точка не принадлежит окружности");               
                Console.ReadKey();
            }
        }
    }
}
