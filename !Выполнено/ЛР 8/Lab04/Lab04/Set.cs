using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace Lab04
{
    /// <summary>
    /// Класс множество Set
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> : IEnumerable<T>, CommonInterface<T>
    {
        private List<T> collection = new List<T>();

        /// <summary>
        /// Add - добавление элемента в множество
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            collection.Add(element);
        }

        /// <summary>
        /// Remove - удаление элемента из множества
        /// </summary>
        /// <param name="element"></param>
        public void Remove(T element)
        {
            collection.Remove(element);
        }

        public void ShowList()
        {
            Console.WriteLine("Show list: ");

            foreach(T item in collection)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
        }



        /// <summary>
        /// Перегрузка операции "-" - удалить элемент из множества
        /// </summary>
        /// <param name="set"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Set<T> operator -(Set<T> set, T element)
        {
            if(element == null)
            {
                throw new Lab04.Exceptions.NullElement();
            }
            set.Remove(element);
            return set;
        }

        /// <summary>
        /// Intersection - пересечение множеств
        /// <para>Перегрузка "*" - пересечение множеств</para>
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <returns></returns>
        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            var resultCollection = new Set<T>();

            if (set1.Count() < set2.Count())
            {
                foreach (T element in set1.collection)
                {
                    if (set2.collection.Contains(element))
                    {
                        resultCollection.Add(element);
                    }
                }
            }
            else
            {
                foreach (T element in set2.collection)
                {
                    if (set2.collection.Contains(element))
                    {
                        resultCollection.Add(element);
                    }
                }
            }
            return resultCollection;
        }

        /// <summary>
        /// Subset - проверка на подмножество
        /// <para>Перегрузка ">" - проверка на подмножество</para>
        /// </summary>
        /// <param name="setVerif"></param>
        /// <param name="setMain"></param>
        /// <returns></returns>
        public static bool operator >(Set<T> setVerif, Set<T> setMain)
        {
            bool flag = false;
            foreach(T element in setVerif)
            {
                if(setMain.Contains(element))
                {
                    //  Является подмножеством
                    flag = true;
                }
                else
                {
                    //  Не является подмножеством
                    return flag;
                }
            }
            return flag;
        }


        /// <summary>
        /// <para>Перегрузка "<" - сравнение множеств</para>
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <returns></returns>
        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            if(set1.Count() < set2.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Перегрузка "&" - придумать использование
        /// <para>Объединение множеств</para>
        /// </summary>
        /// <param name="set1"></param>
        /// <param name="set2"></param>
        /// <returns></returns>
        public static Set<T> operator & (Set<T> set1, Set<T> set2)
        {
            var resultSet = new Set<T>();
            var resultItems = new List<T>();

            //  Если элемент не дублируется - добавить в результат
            //  Если элемент дублируется - добавить только один в результат

            resultItems.AddRange(set1.collection);
            resultItems.AddRange(set2.collection);

            resultSet.collection = resultItems.Distinct().ToList();

            return resultSet;
        }

        //  Добавление вложенного объекта
        public class Owner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string OrgName { get; set; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return collection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collection.GetEnumerator();
        }
    }

    public static class ExtensionMethods
    {
        public static string DotInTheEnd(this string str)
        {
            return str += ".";
        }

        public static void RemoveAllNull<T>(this List<T> list)
        {
            list.RemoveAll(item => item == null);
        }
    }
}
