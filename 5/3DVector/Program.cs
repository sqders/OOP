using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DVector
{
    struct _3DVector
        {
        public int x, y, z;
        public _3DVector(int x,int y ,int z )
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void DisplayVector()
        {
            Console.WriteLine($"x : {x} \t y : {y} \t z : {z}");
        }
        public double Module()
        {
            return Math.Sqrt(x*x+y*y+z*z);
        }
        public static _3DVector operator +(_3DVector a,_3DVector b)
        {
            return new _3DVector(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static _3DVector operator -(_3DVector a, _3DVector b)
        {
            return new _3DVector(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static _3DVector operator *(_3DVector a, _3DVector b)
        {
            return new _3DVector(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static _3DVector operator *(_3DVector a, int b)
        {
            return new _3DVector(a.x * b, a.y * b, a.z * b);
        }
        public static _3DVector operator &(_3DVector a, _3DVector b)
        {
            //в лево ортогонормированном базисе
            return new _3DVector(a.x * b.z - a.z * b.y, a.z * b.x -a.x*b.z, a.x * b.y- a.y*b.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = new int();
            _3DVector a = new _3DVector(1, 1, 1);
            a.DisplayVector();
            Console.WriteLine(a.Module());
            _3DVector b = new _3DVector(4, 2, 1);
            b += a;
            b.DisplayVector();
            a -= b;
            a.DisplayVector();
            a *= b;
            a.DisplayVector();
            b *= 2;
            b.DisplayVector();
            a = new _3DVector(2, 1, 0);
            b = new _3DVector(-3, 0, -1);
            b &= a;
            b.DisplayVector();
            Console.ReadLine();
        }
    }
}
