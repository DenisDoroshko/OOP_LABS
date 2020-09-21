using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibary
{
    public class Vector
    {
        public int CoordinateX { get; set; }

        public int CoordinateY { get; set; }

        public int CoordinateZ { get; set; }

        public static int operator *(Vector firstVector,Vector secondVector)
        {
            int result = firstVector.CoordinateX * secondVector.CoordinateX + firstVector.CoordinateY * secondVector.CoordinateY + firstVector.CoordinateZ * secondVector.CoordinateZ;
            return result;
        }
        public static Vector operator *(Vector firstVector, int number)
        {
            Vector resultVector = new Vector();
            resultVector.CoordinateX = firstVector.CoordinateX * number;
            resultVector.CoordinateY = firstVector.CoordinateY * number;
            resultVector.CoordinateZ = firstVector.CoordinateZ * number;
            return resultVector;
        }
        public Vector(int coordinateX, int coordinateY, int coordinateZ)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            CoordinateZ = coordinateZ;
        }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Vector checkVector = (Vector)obj;
                return (CoordinateX == checkVector.CoordinateX) && (CoordinateY == checkVector.CoordinateY) && (CoordinateZ == checkVector.CoordinateZ);
            }
        }

        public override int GetHashCode()
        {
            return CoordinateX+CoordinateY+CoordinateZ;
        }

        public Vector()
        {

        }
    }
}
