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
            var tringle = new Triangle(4, 2, 2);
            tringle.Exist();
            Console.WriteLine("Периметр = " + tringle.Perimetre());
            Console.WriteLine("Площадь = " + tringle.Area());
            tringle.Check1();
            tringle.Check2();
            
            //var tringle2 = new Triangle(-1, 2, 2);
            //tringle2.Exist();
            //Console.WriteLine("Периметр = " + tringle2.Perimetre());
            //Console.WriteLine("Площадь = " + tringle2.Area());
            //tringle2.Check1();
            //tringle2.Check2();
         }
        

    }

}