using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypePattern
{
    class TypePattern
    {
        static void Main(string[] args)
        {

            Triangle t = new Triangle(10, 20);
            Console.WriteLine("Area of Triangle: " + t.Area());
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine("Area of Rectangle: " + r.Area());
        




            Console.ReadKey();
        }
    }

    #region Virtual Method

    class Shapes
    {
        protected int _width;
        protected int _height;

        public Shapes(int width, int height)
        {
            _width = width;
            _height = height;
        }
        virtual public double Area()
        {
            return 0;
        }
    }

    class Triangle : Shapes
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }
        public override double Area()
        {
            return _width * _height / 2;
        }
    }
    class Rectangle : Shapes
    {
        public Rectangle(int width, int height) : base(width, height)
        {
        }
        public override double Area()
        {
            return _width * _height;
        }
    }
    #endregion
}