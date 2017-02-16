using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //var tringle = new Triangle(new Point(1, 0), new Point(0, 4), new Point(2, 0));
            //tringle.Exist();
            //Console.WriteLine("Периметр = " + tringle.Perimetre());
            //Console.WriteLine("Площадь = " + tringle.Area());
            //tringle.Isosceles();
            //tringle.Right();

            Console.WriteLine("Введите количество треугольников");
            int n = Convert.ToInt32(Console.ReadLine());
        
            Triangle[] triangles=new Triangle[n];

            
            for (int i = 0; i < n;i++ )
            {
                Console.WriteLine("Введите точки");
                string[] tmp;
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xa = Convert.ToInt32(tmp[0]), ya = Convert.ToInt32(tmp[1]);
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xb = Convert.ToInt32(tmp[0]), yb = Convert.ToInt32(tmp[1]);
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xc = Convert.ToInt32(tmp[0]), yc = Convert.ToInt32(tmp[1]); 
                 triangles[i] = new Triangle(
                    new Point(xa, ya),
                    new Point(xb, yb),
                    new Point(xc, yc));
            }
            Console.WriteLine("***************");

            int countRight = 0;
            double sumPerimetres = 0;
            int countIsosceles = 0;
            double sumAreas = 0;


            for (int i = 0; i < triangles.Length;i++ )
            {
                Console.WriteLine();
                Console.WriteLine("Треугольник № {0} ", i + 1);
                if (triangles[i].GetExist())
                {

                    Console.WriteLine("Площадь треугольника = {0} ", triangles[i].GetArea());
                    Console.WriteLine("Периметр Треугольника = {0} ", triangles[i].GetPerimetre());
               

                if (triangles[i].checkIsosceles())
                    {
                        sumAreas += triangles[i].GetArea();
                        countIsosceles++;
                    }

                    if (triangles[i].checkRight())
                    {
                        sumPerimetres += triangles[i].GetPerimetre();
                        countRight++;
                    }
             
                }

                
                Console.WriteLine();
                Console.WriteLine("***************");
              
                
            }
            Console.WriteLine();
            Console.WriteLine("Средний Периметр = " + sumPerimetres / countRight);
            Console.WriteLine("Средняя Площадь = " + sumAreas / countIsosceles);
            Console.WriteLine();
            Console.WriteLine("Количество треугольников " +n);
            sumPerimetres = 0; countRight = 0;
            sumAreas = 0; countIsosceles = 0;
         }
        

    }

}