using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Collections.Generic;

using Lab5.Construction;
using Lab5.Exceptions;

namespace Lab5
{
    //  Вариант 4
    //  Растение, Куст, Цветок, Роза, Гладиолус, Кактус, Бумага, Букет
    class Program
    {
        static void Main(string[] args)
        {
            //ObjCaller.Start();
            //ObjCaller.ObjViaRefInterface();
            //ObjCaller.CheckMethod();
            //ObjCaller.DefBouquet();
            //ObjCaller.CallSort();
            //ObjCaller.CallStruct();

            //Вызов исключений
            ExceptionCaller.Menu();
            //ExceptionCaller.IncorrectValue();
            //ExceptionCaller.NullArgument();
            //ExceptionCaller.DivideByZero();
        }
    }
}
