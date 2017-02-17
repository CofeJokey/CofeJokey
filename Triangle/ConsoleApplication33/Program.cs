using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Edge
    {
        public Point p1;
        public Point p2;
        public double length;
        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            length = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

    }
    class Triangle
    {
        public Point A;
        public Point B;
        public Point C;
        public double ae;
        public Edge AB;
        public Edge BC;
        public Edge AC;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = new Edge(A, B);
            this.BC = new Edge(B, C);
            this.AC = new Edge(A, C);
            ae = this.GetPerimetre();
        }

        public bool GetExist()
    {
        if (AB.length <= 0 || AC.length <= 0 || BC.length <= 0)
        {

                Console.WriteLine("Треугольник не существует");
                return false;
        }
        else if (AB.length + BC.length <= AC.length || AB.length + AC.length <= BC.length || AC.length + BC.length <= AB.length)
        {
            Console.WriteLine("Треугольник не существует");
            return false;
        }
        return true;
    }
        public double GetPerimetre()
        {
            double primente = AB.length + AC.length + BC.length;
            ae = primente;
            return primente;
        }

        public double GetArea()
        {
            double p = ae / 2;
            double area = Math.Sqrt(p * (p - AB.length) * (p - BC.length) * (p - AC.length));

            
            return area;
        }

        public bool checkIsosceles()
        {
            if ((AB.length == BC.length) || (AB.length == AC.length) || (AC.length == BC.length))
            {
                Console.WriteLine("Треугольник равнобедренный");
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
                return false;
            }
         
        }

      


        public bool checkRight()
        {
            //if ((AB.length * AB.length + BC.length * BC.length == AC.length * AC.length)
            //    || (AB.length * AB.length + AC.length * AC.length == BC.length * BC.length)
            //    || (AC.length * AC.length + BC.length * BC.length == AB.length * AB.length)) 

            if ((Math.Round(this.GetArea(), 2) == Math.Round(AB.length * BC.length / 2, 2))
                || (Math.Round(this.GetArea(), 2) == Math.Round(AC.length * BC.length / 2, 2))
                || (Math.Round(this.GetArea(), 2) == Math.Round(AB.length * AC.length / 2, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
                return false;
            }
        }


        

    }


}