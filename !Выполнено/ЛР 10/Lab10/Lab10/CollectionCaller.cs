using System;
using System.Collections.Generic;

using Lab10.Construction;
using Lab10.Сontrollers;
using Lab10.Exceptions;

namespace Lab10
{
    class CollectionCaller
    {
        public static void CallHashtable()
        {
            Employee employee = new Employee();

            HashtableCollectionController.Add(employee);
            HashtableCollectionController.Remove(employee);
            HashtableCollectionController.Search(employee);
            HashtableCollectionController.Show(employee);

            List<Employee> employees = new List<Employee>();

            foreach (string key in employee.hashtable.Keys)
            {
                employees.Add(new Employee { Key = key, Position = Convert.ToString(employee.hashtable[key]) });
            }



            Console.WriteLine("Конвертация в лист");
            foreach (Employee elem in employees)
            {
                Console.WriteLine($"{elem.Key}: {elem.Position}");
            }

            Console.Write("Введите ключ для поиска: ");
            string searchStr = Console.ReadLine();
            Console.WriteLine(employees.Find(x => x.Key.Contains(searchStr)).Position);
        }
    }
}
