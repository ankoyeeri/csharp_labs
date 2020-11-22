using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab5.Construction
{
    /// <summary>
    /// Бумага.
    /// <para>Интерфейс</para>
    /// </summary>
    interface IPaper
    {
        /// <summary>
        /// Цвет бумаги
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// Функция интерфейса
        /// </summary>
        void Note();
    }
}
