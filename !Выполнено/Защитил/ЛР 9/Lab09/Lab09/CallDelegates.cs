using System;
using System.Collections.Generic;
using System.Text;

namespace Lab09
{
    class CallDelegates
    {
        public static void Start()
        {
            Director director = new Director();
            director.Notify += Director.ShowMsg;

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();

            employee1.Type = "Сварщик";
            employee1.Salary = 2000;

            employee2.Type = "Фррезировщик";
            employee2.Salary = 1800;

            employee3.Type = "Токарь";
            employee3.Salary = 1200;

            employee4.Type = "Инженер";
            employee4.Salary = 3000;


            //---------------------------------
            Console.WriteLine("------------ Делегату присвоена одна функция ------------ ");
            Director.Operation<Employee> operation1;
            operation1 = director.Raise;

            operation1.Invoke(ref employee1, 1000);
            operation1.Invoke(ref employee2, 500);
            Console.WriteLine($"Текущая зарплата должности {employee1.Type}: {employee1.Salary}");
            Console.WriteLine($"Текущая зарплата должности {employee2.Type}: {employee2.Salary}");
            Console.WriteLine("------------------------\n");
            //---------------------------------


            //---------------------------------
            Console.WriteLine("------------ Делегату присвоено две функции ------------ ");
            Director.Operation<Employee> operation2;
            operation2 = director.Fine;
            operation2 += director.Raise;

            operation2.Invoke(ref employee3, 1000);
            Console.WriteLine($"Текущая зарплата должности {employee3.Type}: {employee3.Salary}");
            Console.WriteLine("------------------------\n");
            //---------------------------------


            //---------------------------------
            Console.WriteLine("------------ Присваивание и удаление функций делегата ------------ ");
            Director.Operation<Employee> operation3;
            operation3 = director.Raise;

            operation3.Invoke(ref employee4, 300);
            Console.WriteLine($"Текущая зарплата должности {employee4.Type}: {employee4.Salary}");

            operation3 += director.Fine;
            operation3.Invoke(ref employee4, 300);
            Console.WriteLine($"Текущая зарплата должности {employee4.Type}: {employee4.Salary}");

            try
            {
                operation3 -= director.Fine;
                operation3 -= director.Raise;
                operation3.Invoke(ref employee4, 300);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("------------------------ ");
            //---------------------------------
        }
    }
}
