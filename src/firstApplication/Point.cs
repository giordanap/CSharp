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

            contadorObjetos++;

            Console.WriteLine("Constructor by default");
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            contadorObjetos++;

            Console.WriteLine("Coodinates:{x:" + x + ", y:" + y + "}");
        }

        public double DistanceTo(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(this.x - otherPoint.x, 2) + Math.Pow(this.y - otherPoint.y, 2));
        }

        //public static int ContadorDeObjetos()
        //{
        //    return contadorObjetos;
        //}

        public static int ContadorDeObjetos() => contadorObjetos;

        private int x, y;

        private static int contadorObjetos = 0;

        public const int constantePrueba = 7; // las constantes se asume que son estaticas.
    }
}
