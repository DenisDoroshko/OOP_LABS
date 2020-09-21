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
            int[] expected = new int[3] { 0, 12, -41 };
            Vector testVector = new Vector(0, 12, -41);
            int[] testMassiv = new int[3] { testVector.CoordinateX, testVector.CoordinateY, testVector.CoordinateZ };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(testMassiv[i]);
                Console.WriteLine(expected[i]);
            }
            Console.ReadLine();
            //Console.WriteLine(FirstVector*SecondVector);
            //Console.WriteLine($"BY number {FirstVector.CoordinateX} {FirstVector.CoordinateY} {FirstVector.CoordinateZ}");
            //Console.ReadLine();
        }
    }
}
