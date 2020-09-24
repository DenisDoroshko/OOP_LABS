using System;
using VectorLibary;

namespace ConsoleMenu
{
    /// <summary>
    /// Класс описывающий методы для взаимодействия с пользователем
    /// </summary>
    class InteractionWithUser
    {
        /// <summary>
        /// Метод выполняющий определенные действия в соответствии с выбором пользователя
        /// </summary>
        public static void ShowMenu()
        {
            int choice;
            while ((choice = MakeChoice()) != 3)
            {
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        MultipleVectors();
                        break;
                    case 2:
                        MultipleByNumber();
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;
                }
            }
        }
        /// <summary>
        /// Метод предлагающий пользователю сделать выбор
        /// </summary>
        /// <returns>Выбор пользователя</returns>
        static int MakeChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Умножение векторов\n2.Умножение вектора на число\n3.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
        /// <summary>
        /// Метод выполняющий различные умножения векторов
        /// </summary>
        static void MultipleVectors()
        {
            int choice;
            Console.WriteLine("Как умножить векторы:\n1.Скалярно\n2.Векторно\n3.Смешанно");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            bool resultOperation;
            Vector firstVector = new Vector();
            Vector secondVector = new Vector();
            Vector thirdVector = new Vector();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ввод координат первого вектора");
                    resultOperation = AddVector(out firstVector);
                    if (resultOperation)
                    {
                        Console.WriteLine("Ввод координат второго вектора");
                        resultOperation = AddVector(out secondVector);
                    }

                    if (resultOperation)
                    {
                        int result = firstVector * secondVector;
                        Console.WriteLine($"Исходные векторы:\na( {firstVector.CoordinateX}, {firstVector.CoordinateY}, {firstVector.CoordinateZ})\n" +
                            $"b( {secondVector.CoordinateX}, {secondVector.CoordinateY}, {secondVector.CoordinateZ})\n" +
                            $"Результат умножения: {result} ");
                    }
                    else
                    {
                        Console.WriteLine("Операция умножения не выполнена");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ввод координат первого вектора");
                    resultOperation = AddVector(out firstVector);
                    if (resultOperation)
                    {
                        Console.WriteLine("Ввод координат второго вектора");
                        resultOperation = AddVector(out secondVector);
                    }

                    if (resultOperation)
                    {
                        Vector resultVector = Vector.VectorMultiple(firstVector, secondVector);
                        Console.WriteLine($"Исходные векторы:\na( {firstVector.CoordinateX}, {firstVector.CoordinateY}, {firstVector.CoordinateZ})\n" +
                            $"b( {secondVector.CoordinateX}, {secondVector.CoordinateY}, {secondVector.CoordinateZ})\n" +
                            $"Новый вектор: c( {resultVector.CoordinateX}, {resultVector.CoordinateY}, {resultVector.CoordinateZ})) ");
                    }
                    else
                    {
                        Console.WriteLine("Операция умножения не выполнена");
                    }
                    break;
                case 3:
                    Console.WriteLine("Ввод координат первого вектора");
                    resultOperation = AddVector(out firstVector);
                    if (resultOperation)
                    {
                        Console.WriteLine("Ввод координат второго вектора");
                        resultOperation = AddVector(out secondVector);
                    }
                    if (resultOperation)
                    {
                        Console.WriteLine("Ввод координат третего вектора");
                        resultOperation = AddVector(out thirdVector);
                    }
                    
                    if (resultOperation)
                    {
                        int result = Vector.MixedMultiply(firstVector, secondVector, thirdVector);
                        Console.WriteLine($"Исходные векторы:\na( {firstVector.CoordinateX}, {firstVector.CoordinateY}, {firstVector.CoordinateZ})\n" +
                            $"b( {secondVector.CoordinateX}, {secondVector.CoordinateY}, {secondVector.CoordinateZ})\n" +
                            $"c( {thirdVector.CoordinateX}, {thirdVector.CoordinateY}, {thirdVector.CoordinateZ})\n" +
                            $"Результат умножения: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Операция умножения не выполнена");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка выбора");
                    break;

            }
        }
        /// <summary>
        /// Метод выполняющий умножение вектора на число
        /// </summary>
        static void MultipleByNumber()
        {
            bool resultOperation;
            Vector firstVector = new Vector();
            Console.WriteLine("Ввод координат первого вектора");
            resultOperation = AddVector(out firstVector);
            if (resultOperation)
            {
                Console.WriteLine("Введите число на которое умножить ");
                int number;
                string input = Console.ReadLine();
                if (int.TryParse(input, out number)) 
                {
                    Vector resultVector = new Vector();
                    resultVector=firstVector * number;
                    Console.WriteLine($"Исходный вектор:\na( {firstVector.CoordinateX}, {firstVector.CoordinateY}, {firstVector.CoordinateZ})\n" +
                    $"Измененный вектор: b( {resultVector.CoordinateX}, {resultVector.CoordinateY}, {resultVector.CoordinateZ})) ");
                }
            }
        }
        /// <summary>
        /// Метод создающий вектор
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        static bool AddVector(out Vector vector)
        {
            bool resultOperation = false;
            vector = new Vector();
            int choice = 1;
            while (choice == 1)
            {
                bool checkCorrect = true;
                string input;
                Console.WriteLine("Введите координату X вектора");
                int coordinateX;
                input = Console.ReadLine();
                CheckInput(input, out coordinateX, ref checkCorrect);
                Console.WriteLine("Введите координату Y вектора");
                int coordinateY;
                input = Console.ReadLine();
                CheckInput(input, out coordinateY, ref checkCorrect);
                Console.WriteLine("Введите координату Z вектора");
                int coordinateZ;
                input = Console.ReadLine();
                CheckInput(input, out coordinateZ, ref checkCorrect);
                if (checkCorrect)
                {
                    vector = new Vector(coordinateX, coordinateY, coordinateZ);
                    Console.WriteLine("Вектор добавлен");
                    choice = 0;
                    resultOperation = true;
                }
                else
                {
                    Console.WriteLine("Вектор не создан\n1.Ввести еще раз \n2.Выйти");
                    input = Console.ReadLine();
                    int.TryParse(input, out choice);
                    resultOperation= false;
                }
            }
            return resultOperation;
        }
        /// <summary>
        /// Метод проверяющий коректность вводимых данных
        /// </summary>
        /// <param name="input">Строка хранящая введенное значение</param>
        /// <param name="number">Переменная в которую записывается значение</param>
        /// <param name="checkCorrect"></param>
        static void CheckInput(string input, out int number,ref bool checkCorrect)
        {
            if (int.TryParse(input, out number))
            {
            }
            else
            {
                checkCorrect = false;
                Console.WriteLine("Некоректный ввод");
            }
        }
    }
}
