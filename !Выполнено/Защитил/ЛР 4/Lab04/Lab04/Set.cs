using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace Lab04
{
    //  Класс множество Set
    public class Set<T> : IEnumerable<T>
    {
        private List<T> collection = new List<T>();


        //  Add - добавление элемента в множество
        public void Add(T element)
        {
            collection.Add(element);
        }

        //  Remove - удаление элемента из множества
        public void Remove(T element)
        {
            collection.Remove(element);
        }

        //  Перегрузка операции "-" - удалить элемент из множества
        public static Set<T> operator -(Set<T> set, T element)
        {
            set.Remove(element);
            return set;
        }

        //  Intersection - пересечение множеств
        //  Перегрузка "*" - пересечение множеств
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

        //  Subset - проверка на подмножество
        //  Перегрузка ">" - проверка на подмножество
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


        //  Перегрузка "<" - сравнение множеств
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

        //  Перегрузка "&" - придумать использование
        //  Объединение множеств
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
            //foreach(var item in set)
            //{
            //    if(item == null)
            //    {
            //        set.Remove(item);
            //    }
            //}
        }
    }
}
