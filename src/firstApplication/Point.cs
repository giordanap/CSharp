using System;
using System.Collections.Generic;
using System.Text;

namespace firstApplication
{
    class Point
    {
        public Point()
        {
            this.x = 0;
            this.y = 0;

            Console.WriteLine("Constructor by default");
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine("Coodinates:{x:" + x + ", y:" + y + "}");
        }

        public double DistanceTo(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(this.x - otherPoint.x, 2) + Math.Pow(this.y - otherPoint.y, 2));
        }

        private int x, y;
    }
}
