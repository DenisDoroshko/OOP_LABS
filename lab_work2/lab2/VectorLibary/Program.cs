using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vector testVector = new Vector(-23, 15, 11);
            Vector test2Vector = new Vector(12, 12, -41);
            Vector newV = Vector.VectorMultiple(testVector,test2Vector);
            Console.WriteLine($"vot { newV.CoordinateX}{ newV.CoordinateY}{ newV.CoordinateZ}");
            Console.ReadLine();
            //Console.WriteLine(FirstVector*SecondVector);
            //Console.WriteLine($"BY number {FirstVector.CoordinateX} {FirstVector.CoordinateY} {FirstVector.CoordinateZ}");
            //Console.ReadLine();
        }
    }
}
