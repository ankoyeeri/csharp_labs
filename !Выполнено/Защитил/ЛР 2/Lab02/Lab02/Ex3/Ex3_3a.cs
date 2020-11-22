using System;

namespace Lab02.Ex3
{
    class Ex3_3a
    {
        public static void Start()
        {
            //  Инициалиация двумерного массива и его отформатированный вывод в виде матрицы
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int counter = 0;
            foreach (int a in array)
            {
                if (counter % 3 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(a);
                counter++;
            }
        }
    }
}
