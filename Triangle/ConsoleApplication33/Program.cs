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
        public Point v1;
        public Point v2;
        public double lenght;
        public Edge(Point v1, Point v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            lenght = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
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
            ae = this.Perimetre();
        }

        public void Exist()
        {
        if (AB.lenght <= 0 || AC.lenght <= 0 || BC.lenght <= 0)
        {

                Console.WriteLine("Треугольник не существует");
                Environment.Exit(0);
        }
        else if (AB.lenght + BC.lenght <= AC.lenght || AB.lenght + AC.lenght <= BC.lenght || AC.lenght + BC.lenght <= AB.lenght)
        {
            Console.WriteLine("Треугольник не существует");
            Environment.Exit(0);
        }
}
        public double Perimetre()
        {
            double primente = AB.lenght + AC.lenght + BC.lenght;
            ae = primente;
            return primente;
        }

        public double Area()
        {
            double p = ae / 2;
            double area = Math.Sqrt(p * (p - AB.lenght) * (p - BC.lenght) * (p - AC.lenght));

            
            return area;
        }

        public bool Isosceles()
        {
            if ((AB.lenght == BC.lenght) || (AB.lenght == AC.lenght) || (AC.lenght == BC.lenght))
            {
                Console.WriteLine("Треугольник равнобедренный");
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
                return false;
            }
          //  return 0;
        }

        public bool Right()
        {
            //if ((AB.lenght * AB.lenght + BC.lenght * BC.lenght == AC.lenght * AC.lenght)
            //    || (AB.lenght * AB.lenght + AC.lenght * AC.lenght == BC.lenght * BC.lenght)
            //    || (AC.lenght * AC.lenght + BC.lenght * BC.lenght == AB.lenght * AB.lenght))
            if ((Math.Round(this.Area(),2) == Math.Round(AB.lenght * BC.lenght / 2,2))
                || (Math.Round(this.Area(), 2) == Math.Round(AC.lenght * BC.lenght / 2, 2))
                || (Math.Round(this.Area(), 2) == Math.Round(AB.lenght * AC.lenght / 2, 2)))
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