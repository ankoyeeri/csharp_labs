using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Construction
{
    /// <summary>
    /// Растение
    /// <para>Абстрактный класс</para>
    /// </summary>
    abstract class Plant
    {
        /// <summary>
        /// Название растения
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Размер растения
        /// </summary>
        public virtual double Size { get; set; }

        /// <summary>
        /// Функция абстрактного класса
        /// </summary>
        public abstract void Note();
    }
}
