using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Box(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public static Box operator +(Box a, Box b)
        {
            int h = a.Height + b.Height;
            int w = a.Width + b.Width;
            Box res = new Box(h, w);
            return res;
        }
    }
    class program
    { 
        static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2;

            Console.WriteLine(b3.Height); //19
            Console.WriteLine(b3.Width); //10

            Console.ReadKey();
        }
    }
}

