using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

using Lab10.Exceptions;
using Lab10.Сontrollers;

namespace Lab10.Construction
{
    class Employee: IEnumerable<Employee>
    {
        public Hashtable hashtable = new Hashtable();
        public string Key { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        /// <summary>
        /// Add element to hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="position"></param>
        public void Add(string key, string position)
        {
            Employee employee = new Employee();

            hashtable.Add(employee.Key = key, employee.Position = position);
        }

        /// <summary>
        /// Remove element from hashtable
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            hashtable.Remove(key);
        }

        public void Search(string element)
        {
            if(hashtable.ContainsKey(element))
            {
                Console.WriteLine("Существует ключ с таким именем");
            }
            else if(hashtable.ContainsValue(element))
            {
                Console.WriteLine("Существует элемент с таким именем");
            }
            else
            {
                Console.WriteLine("Ничего не найдено");
            }

        }
        /// <summary>
        /// Shows full hashtable
        /// </summary>
        public void Show()
        {
            if(hashtable.Keys.Count == 0)
            {
                throw new HashtableKeysIsEmptyException();
            }
            foreach(string key in hashtable.Keys)
            {
                Console.WriteLine($"{key}: {hashtable[key]}");
            }
        }


        public IEnumerator<Employee> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
