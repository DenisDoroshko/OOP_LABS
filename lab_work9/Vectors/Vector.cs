using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    /// <summary>
    /// A class that stores vector coordinates and methods for working with vectors
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// Initializes an instance of the Vector class
        /// </summary>
        /// <param name="coordinateX">X-coordinate of the vector</param>
        /// <param name="coordinateY">Y-coordinate of the vector</param>
        /// <param name="coordinateZ">Z-coordinate of the vector</param>
        
        public Vector(int coordinateX, int coordinateY, int coordinateZ)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            CoordinateZ = coordinateZ;
        }

        /// <summary>
        /// Initializes an instance of the class
        /// </summary>
        
        public Vector()
        {

        }

        /// <summary>
        /// X-coordinate of the vector
        /// </summary>
        
        public int CoordinateX { get; set; }

        /// <summary>
        /// Y-coordinate of the vector
        /// </summary>
        
        public int CoordinateY { get; set; }

        /// <summary>
        /// Z-coordinate of the vector
        /// </summary>
        
        public int CoordinateZ { get; set; }

        /// <summary>
        /// Redefining the multiplication operator for multiplying instances of the Vector class
        /// </summary>
        /// <param name="firstVector">The first source vector</param>
        /// <param name="secondVector">The second source vector</param>
        /// <returns>The result of the product is a new Vector of the Vector class</returns>
        
        public static int operator *(Vector firstVector, Vector secondVector)
        {
            int result = firstVector.CoordinateX * secondVector.CoordinateX + firstVector.CoordinateY * secondVector.CoordinateY + firstVector.CoordinateZ * secondVector.CoordinateZ;
            return result;
        }

        /// <summary>
        /// Redefining the multiplication operator to multiply an instance of the Vector class by a number
        /// </summary>
        /// <param name="firstVector">The original vector</param>
        /// <param name="number">The number to multiply by</param>
        /// <returns>The result of the product is a new Vector of the Vector class</returns>
        
        public static Vector operator *(Vector firstVector, int number)
        {
            Vector resultVector = new Vector();
            resultVector.CoordinateX = firstVector.CoordinateX * number;
            resultVector.CoordinateY = firstVector.CoordinateY * number;
            resultVector.CoordinateZ = firstVector.CoordinateZ * number;
            return resultVector;
        }

        /// <summary>
        /// A method that calculates the vector product of two vectors
        /// </summary>
        /// <param name="firstVector">The first source vector</param>
        /// <param name="secondVector">The second source vector</param>
        /// <returns>The result of the product is a new Vector of the Vector class</returns>
        
        public static Vector VectorMultiple(Vector firstVector, Vector secondVector)
        {
            Vector result = new Vector();
            result.CoordinateX = firstVector.CoordinateY * secondVector.CoordinateZ - firstVector.CoordinateZ * secondVector.CoordinateY;
            result.CoordinateY = firstVector.CoordinateZ * secondVector.CoordinateX - firstVector.CoordinateX * secondVector.CoordinateZ;
            result.CoordinateZ = firstVector.CoordinateX * secondVector.CoordinateY - firstVector.CoordinateY * secondVector.CoordinateX;
            return result;
        }

        /// <summary>
        ///A method that performs a mixed product of vectors
        /// </summary>
        /// <param name="firstVector">The first source vector</param>
        /// <param name="secondVector">The second source vector</param>
        /// <param name="thirdVector">The third source vector</param>
        /// <returns>The result is a number</returns>
        
        public static int MixedMultiply(Vector firstVector, Vector secondVector, Vector thirdVector)
        {
            int result = firstVector * VectorMultiple(secondVector, thirdVector);
            return result;
        }

        /// <summary>
        /// Redefining the Equals method for comparing class instances
        /// </summary>
        /// <param name="obj">The vector to compare with</param>
        /// <returns>The value is true if vectors are equal,otherwise - false</returns>
        
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

        /// <summary>
        /// Redefining the GetHashCode method for creating a hash value
        /// </summary>
        /// <returns>hash value</returns>
        
        public override int GetHashCode()
        {
            return CoordinateX + CoordinateY + CoordinateZ;
        }

        /// <summary>
        /// Returns string representation of the class
        /// </summary>
        /// <returns>String representation of the class</returns>
        
        public override string ToString()
        {
            return $"({CoordinateX},{CoordinateY},{CoordinateZ})";
        }
    }
}
