using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Triangle
    {
         Point A;
         Point B;
         Point C;
        // double ae;
         Edge AB;
         Edge BC;
         Edge AC;

        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = new Edge(A, B);
            this.BC = new Edge(B, C);
            this.AC = new Edge(A, C);
          //  ae = this.GetPerimetre();
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
        public double Perimetre()
        {
            double primente = AB.length + AC.length + BC.length;
          
            return primente;
        }

        public double Area()
        {
            double p = Perimetre() / 2;
            double area = Math.Sqrt(p * (p - AB.length) * (p - BC.length) * (p - AC.length));

            
            return area;
        }

        public bool Isosceles()
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

      


        public bool Right()
        {
            //if ((AB.length * AB.length + BC.length * BC.length == AC.length * AC.length)
            //    || (AB.length * AB.length + AC.length * AC.length == BC.length * BC.length)
            //    || (AC.length * AC.length + BC.length * BC.length == AB.length * AB.length)) 

            if ((Math.Round(this.Area(), 2) == Math.Round(AB.length * BC.length / 2, 2))
                || (Math.Round(this.Area(), 2) == Math.Round(AC.length * BC.length / 2, 2))
                || (Math.Round(this.Area(), 2) == Math.Round(AB.length * AC.length / 2, 2)))
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