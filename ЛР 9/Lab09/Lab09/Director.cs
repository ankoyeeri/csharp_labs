using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    /// <summary>
    /// Директор
    /// </summary>
    class Director
    {
        public delegate void Operation<T>(ref T obj, double a);
        public delegate void DirectorHandler(string message);
        public event DirectorHandler Notify;

        /// <summary>
        /// Повышение запрплаты
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="a"></param>
        public void Raise<T>(ref T obj, double a) where T : Employee 
        {
            Notify?.Invoke($"Зарплата работника ({obj.Salary}) на должности \'{obj.Type}\' была повышена на {a}.\n");
            obj.Salary += a;
        }

        /// <summary>
        /// Штраф из запрлаты
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="a"></param>
        public void Fine<T>(ref T obj, double a) where T : Employee
        {
            Notify?.Invoke($"Работник должности \'{obj.Type}\' был оштрафован на {a}. Стоимость вычтена из текущей зарплаты ({obj.Salary})\n");
            obj.Salary -= a;
        }

        public static void ShowMsg(string message)
        {
            Console.WriteLine(message);
        }

    }
}
