
namespace Lab1
{ 

    /// <summary>
    /// Структура хранящая значения координат точки и их суммы по модулю
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Значение X-координаты точки
        /// </summary>
        public int X;
        /// <summary>
        /// Значение Y-координаты точки
        /// </summary>
        public int Y;
        /// <summary>
        /// Сумма X и Y координат точки по модулю
        /// </summary>
        public int SumCoordinate;
        /// <summary>
        /// Инициализирует экземпляр структуры
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="SumCoordinate"></param>
        public Point(int X, int Y,int SumCoordinate)
        {
            this.X = X;
            this.Y = Y;
            this.SumCoordinate = SumCoordinate;
        }
    }
}
