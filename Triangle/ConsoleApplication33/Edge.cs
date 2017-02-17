using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Edge
    {
         Point p1;
         Point p2;
        public double length;
        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            length = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

    }
}
