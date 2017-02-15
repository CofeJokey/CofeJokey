using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Points
    {
        public double x, y;
        public void Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Edge
    {
        public Points v1;
        public Points v2;
        public double lenght;
        public Edge(Points v1, Points v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            lenght = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
        }

    }
    class Triangle
    {
        public Points A;
        public Points B;
        public Points C;
        public double ae;
        public Edge AB;
        public Edge BC;
        public Edge AC;

        public Triangle(Points a, Points b, Points c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = new Edge(A, B);
            this.BC = new Edge(B, C);
            this.AC = new Edge(A, C);
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

        public void Isosceles()
        {
            if ((AB.lenght == BC.lenght) || (AB.lenght == AC.lenght) || (AC.lenght == BC.lenght))
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
            }
          //  return 0;
        }

        public void Right()
        {
            if ((AB.lenght * AB.lenght + BC.lenght * BC.lenght == AC.lenght * AC.lenght) 
                || (AB.lenght * AB.lenght + AC.lenght * AC.lenght == BC.lenght * BC.lenght)
                || (AC.lenght * AC.lenght + BC.lenght * BC.lenght == AB.lenght * AB.lenght))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }


        

    }


}