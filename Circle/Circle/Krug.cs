using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Krug
    {
        //задаем поля класса
        private double radius;
        private double x;
        private double y;
        private double x0;
        private double y0;

        //метод для доступа к полю "radius"
        public double Radius
        {
        get  { return radius; }
            set {
                if ((double)value < radius)
                    radius = value;
                
            }
            
        }

        // метод для доступа к полю "koordinate"
        public double X
        {
            //возвращает значение
            get { return x; }
            //устанавливает значение
            set { x = value; }
        }

        public double Y
        {
            //возвращает значение
            get { return y; }
            //устанавливает значение
            set { y = value; }
        }

        public double Y0
        {
            //возвращает значение
            get { return y0; }
            //устанавливает значение
            set { y0 = value; }
        }

        public double X0
        {
            //возвращает значение
            get { return x0; }
            //устанавливает значение
            set { x0 = value; }
        }
        public  Krug ()
        {
            radius = 50;
            x = 20;
            y = 10;
        }

        public Krug(double radius, double x, double y, double x0, double y0)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
            this.x0 = x0;
            this.y0 = y0;
        }

        //метод подсчета площади окружности
        public double S (double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //метод подсчета длины окружности
        public double Line( double radius)
        {
            return 2 * Math.PI * radius;
        }

        //метод для нахождения положения точки
        public bool prin(double radius, double x, double y, double y0, double x0)
        {
            if (Math.Pow(x - x0, 2) +  Math.Pow(y - y0, 2) <= Math.Pow(radius, 2))           
                return true;
                else
                    return false;
            }
        }

    }

