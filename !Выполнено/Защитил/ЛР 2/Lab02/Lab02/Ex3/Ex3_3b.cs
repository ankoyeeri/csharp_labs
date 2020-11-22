using System;

namespace Lab02.Ex3
{
    class Ex3_3b
    {
        public static void Start()
        {
            //  Инициализация одномерного массива
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            
            //  Вывод массива
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }

            //  Вывод размер массива
            Console.WriteLine($"\nРазмер массива: {array.Length}");
            Console.WriteLine("Нажмите, чтобы продолжить...");
            Console.ReadLine();
            Console.Clear();

            // -----------------------------
            
            //  Замена нужного элемента массива нужным числом
            while (true)
            {
                try
                {
                    Console.Write("Выберите позицию элемента массива: ");
                    int chosenPos = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nВведите значение массива: ");
                    int chosenVal = Convert.ToInt32(Console.ReadLine());

                    array[chosenPos] = chosenVal;

                    foreach (int a in array)
                    {
                        Console.Write($"{a} ");

                    }

                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
    }
}
