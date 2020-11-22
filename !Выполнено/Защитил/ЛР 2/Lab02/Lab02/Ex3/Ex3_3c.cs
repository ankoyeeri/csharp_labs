using System;

namespace Lab02.Ex3
{
    class Ex3_3c
    {
        public static void Start()
        {
            // Инициализация тройного массива
            double[][] array = new double[3][];
            array[0] = new double[2];
            array[1] = new double[3];
            array[2] = new double[4];

            while (true)
            {
                try
                {
                    //  Инициализация ступенчатого массива
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"Введите данные {i + 1}-го массива: ");
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            Console.Write($"{j} значение из {array[i].Length}: ");
                            array[i][j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    Console.WriteLine();

                    //  Вывод ступенчатого массива
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            Console.Write(array[i][j]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Нажмите, чтобы продолжить...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    }
}
