using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using Lab10.Construction;
using Lab10.Сontrollers;
using Lab10.Exceptions;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //CollectionCaller.CallHashtable();

            ObservableCollection<Employee> employees = new ObservableCollection<Employee>
            {
                new Employee {Key = "123", Position = "Садовник", Salary = 20},
                new Employee {Key = "223a2", Position = "Инженер", Salary = 40 },
                new Employee {Key = "47j0", Position = "Машинист", Salary = 20 }
            };

            employees.CollectionChanged += CollectionChangedNotification;

            employees.Add(new Employee { Key = "9ija92", Position = "Садовник", Salary = 25 });
            employees.RemoveAt(2);
            employees[0] = new Employee { Key = "9ija92", Position = "Садовник", Salary = 25 };


            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Key}\t{employee.Position}\t{employee.Salary}");
            }
        }

        public static void CollectionChangedNotification(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Employee newEmployee = e.NewItems[0] as Employee;
                    Console.WriteLine($"В коллекцию был добавлен новый элемент: {newEmployee.Position}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Employee currentEmployee = e.OldItems[0] as Employee;
                    Console.WriteLine($"Объект удален: {currentEmployee.Position}");
                    break;
            }
        }
    }
}
