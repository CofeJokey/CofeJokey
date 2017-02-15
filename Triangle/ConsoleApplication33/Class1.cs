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

            Console.WriteLine("Enter count of triangles");
            int n = Convert.ToInt32(Console.ReadLine());
            Triangle[] triangles=new Triangle[n];
          // List<Triangle> listOfTriangles=new List<Triangle>();

            for (int i = 0; i < n;i++ )
            {
                Console.WriteLine("Enter points");
                string[] tmp;
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xa = Convert.ToInt32(tmp[0]), ya = Convert.ToInt32(tmp[1]);
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xb = Convert.ToInt32(tmp[0]), yb = Convert.ToInt32(tmp[1]);
                tmp = Console.ReadLine().Split(new Char[] { ' ' });
                int xc = Convert.ToInt32(tmp[0]), yc = Convert.ToInt32(tmp[1]); 
                 triangles[i] = new Triangle(new Point(xa, ya),
                    new Point(xb, yb),
                    new Point(xc, yc));
            }
            for (int i = 0; i < triangles.Length;i++ )
            {
                Console.WriteLine("Area of triangle №{0} is {1}", i + 1, triangles[i].Area());
                Console.WriteLine("Perimetre of triangle №{0} is {1}", i + 1, triangles[i].Perimetre());
                int count=0;
                double sum=0;
                if (triangles[i].Right())
                {
                    sum += triangles[i].Perimetre();
                    count++;
                }
                double averagePerimetreRight = sum / count;
                sum = 0; count = 0;

                //сделать для площади

                triangles[i].Isosceles();

                Console.WriteLine();

                //кодить здесь
            }
                Console.WriteLine(n);
         }
        

    }

}