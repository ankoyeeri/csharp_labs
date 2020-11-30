using Lab5.Construction;
using Lab5.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab5
{
    /// <summary>
    /// Класс вызова исключений
    /// </summary>
    class ExceptionCaller
    {
        /// <summary>
        /// Вызов исключения <see cref="Lab5.Exceptions.IncorrectValueException"/>
        /// </summary>
        public static void IncorrectValue()
        {
            try
            {
                Bouquet bouquet = new Bouquet();
                Console.Write("Ввести значение от 0 до 20: ");
                bouquet.Size = Convert.ToInt32(Console.ReadLine());
                bouquet.Size = 40;

            }
            catch (IncorrectValueException e)
            {

                Console.WriteLine($"{Convert.ToString(e.GetType())}\n{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Выполнение завершено");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Вызов исключение <see cref="Lab5.Exceptions.ArgNullException"/>
        /// </summary>
        public static void NullArgument()
        {
            try
            {
                Bouquet bouquet = null;

                BouquetController.SortListByParam(bouquet);
            }
            catch (ArgNullException e)
            {
                Console.WriteLine($"{Convert.ToString(e.GetType())}\n{e.Message}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Выполнение завершено");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Вызов исключения <see cref="Lab5.Exceptions.DBZException"/>
        /// </summary>
        public static void DivideByZero()
        {
            try
            {
                int a, b;
                a = 2;
                b = 0;
                Dividing(a, b);
            }
            catch (DBZException e)
            {
                Console.WriteLine($"{Convert.ToString(e.GetType())}\n{e.Message}");
            }
            finally
            {
                Console.WriteLine("Выполнение завершено");
                Console.ReadKey();
            }
        }

        private static void Dividing(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new DBZException();
            }

            Console.WriteLine(a / b);
        }

        /// <summary>
        /// Вызов <see cref="Debug.Assert(bool)"/>
        /// </summary>
        public static void AssertCall()
        {
            try
            {
                Bouquet bouquet = new Bouquet();
                Console.WriteLine("При вводе \"5\" сработает Assert");
                bouquet.Size = Convert.ToDouble(Console.ReadLine());
                Debug.Assert(bouquet.Size != 5, "Лист не может быть равен null");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Выполнение завершено");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Меню выбора исключений
        /// </summary>
        public static void Menu()
        {
            while (true)
            {
                Console.Write($"1) {nameof(IncorrectValue)}\n2) {nameof(NullArgument)}\n3) {nameof(DivideByZero)}\n" +
                    $"4){nameof(AssertCall)}\n---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        IncorrectValue();
                        break;
                    case 2:
                        NullArgument();
                        break;
                    case 3:
                        DivideByZero();
                        break;
                    case 4:
                        AssertCall();
                        break;
                    default:
                        throw new IncorrectValueException(nameof(choise));
                }
                Console.Clear();
            } 
        }
    }
}
