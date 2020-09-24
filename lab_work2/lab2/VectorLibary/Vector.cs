using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibary
{
    /// <summary>
    /// Класс хранящий координаты вектора и методы работы с векторами
    /// </summary>
    public class Vector
    {
        /// <summary>
        /// X-координата вектора
        /// </summary>
        public int CoordinateX { get; set; }

        /// <summary>
        /// Y-координата вектора
        /// </summary>
        public int CoordinateY { get; set; }
        /// <summary>
        /// Z-координата вектора
        /// </summary>
        public int CoordinateZ { get; set; }
        /// <summary>
        /// Переопределение оператора умножения для умножения экземпляров класса Vector
        /// </summary>
        /// <param name="firstVector">Первый исходный вектор</param>
        /// <param name="secondVector">Второй исходный вектор</param>
        /// <returns>Результатом произведения является новый вектор класса Vector</returns>
        public static int operator *(Vector firstVector,Vector secondVector)
        {
            int result = firstVector.CoordinateX * secondVector.CoordinateX + firstVector.CoordinateY * secondVector.CoordinateY + firstVector.CoordinateZ * secondVector.CoordinateZ;
            return result;
        }
        /// <summary>
        /// Переопределение оператора умножения для умножения экземпляра класса Vector на число
        /// </summary>
        /// <param name="firstVector">Исходный вектор</param>
        /// <param name="number">Число на которое умножается</param>
        /// <returns>Результатом произведения является новый вектор класса Vector</returns>
        public static Vector operator *(Vector firstVector, int number)
        {
            Vector resultVector = new Vector();
            resultVector.CoordinateX = firstVector.CoordinateX * number;
            resultVector.CoordinateY = firstVector.CoordinateY * number;
            resultVector.CoordinateZ = firstVector.CoordinateZ * number;
            return resultVector;
        }
        /// <summary>
        /// Метод вычисляющий векторное произведение двух векторов
        /// </summary>
        /// <param name="firstVector">Первый исходный вектор</param>
        /// <param name="secondVector">Второй исходный вектор</param>
        /// <returns>Результатом произведения является новый вектор класса Vector</returns>
        public static Vector VectorMultiple(Vector firstVector, Vector secondVector)
        {
            Vector result = new Vector();
            result.CoordinateX = firstVector.CoordinateY * secondVector.CoordinateZ - firstVector.CoordinateZ * secondVector.CoordinateY;
            result.CoordinateY = firstVector.CoordinateZ * secondVector.CoordinateX - firstVector.CoordinateX * secondVector.CoordinateZ;
            result.CoordinateZ = firstVector.CoordinateX * secondVector.CoordinateY - firstVector.CoordinateY * secondVector.CoordinateX;
            return result;
        }
        /// <summary>
        /// Метод выполняющий смешанное произведение векторов
        /// </summary>
        /// <param name="firstVector">Первый исходный вектор</param>
        /// <param name="secondVector">Второй исходный вектор</param>
        /// <param name="thirdVector">Третий исходный вектор</param>
        /// <returns>Результатом является число</returns>
        public static int MixedMultiply(Vector firstVector, Vector secondVector,Vector thirdVector)
        {
            int result = firstVector * VectorMultiple(secondVector, thirdVector);
            return result;
        }

        /// <summary>
        /// Переопределение метода Equals для сравнения экземпляров класса
        /// </summary>
        /// <param name="obj">Вектор с которым сравнивается</param>
        /// <returns>bool результат сравнения</returns>
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
        /// Переопределение метода GetHashCode для создания хеш-значения
        /// </summary>
        /// <returns>Хеш-значение</returns>
        public override int GetHashCode()
        {
            return CoordinateX+CoordinateY+CoordinateZ;
        }
        /// <summary>
        /// Инициализирует экземпляр класса
        /// </summary>
        /// <param name="coordinateX">X-координата вектора</param>
        /// <param name="coordinateY">Y-координата вектора</param>
        /// <param name="coordinateZ">Z-координата вектора</param>
        public Vector(int coordinateX, int coordinateY, int coordinateZ)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            CoordinateZ = coordinateZ;
        }
        /// <summary>
        /// Инициализирует экземпляр класса
        /// </summary>
        public Vector()
        {

        }
    }
}
