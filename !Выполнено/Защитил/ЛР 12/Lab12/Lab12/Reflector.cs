using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace Lab12
{
    static class Reflector
    {
        const string fileName = "ClassReflection.txt";
        public static void GetAssemblyBuild<T>(T obj)
        {
            Assembly info = typeof(T).Assembly;
            AssemblyName assemblyName = info.GetName();

            using(StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine($"AssemblyName info from {typeof(T)} class:");
                sw.WriteLine($"Name - {assemblyName.Name}");
                sw.WriteLine($"Version - {assemblyName.Version.Major}.{assemblyName.Version.Minor}");
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void CheckPublicConstructors<T>(T obj) where T : class
        {
            ConstructorInfo[] infos = typeof(T).GetConstructors();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine($"Number of public constructors: {infos.Length}");
                for (int i = 0; i < infos.Length; i++)
                {
                    sw.WriteLine($"{i + 1}) {infos[i]}");
                }
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void GetPublicPublicMethods<T>(T obj) where T : class
        {
            Type type = (typeof(T));
            MethodInfo[] info = type.GetMethods();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine($"Number of public methods in {typeof(T)} class: {info.Length}");
                foreach (var item in info)
                {
                    sw.WriteLine($"{item.Name}");
                }
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void GetPublicFieldProperties<T>(T obj)
        {
            Type type = (typeof(T));
            var properties = type.GetProperties();
            var fields = type.GetFields();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine($"Properties in {typeof(T)} class: {properties.Length}");
                sw.WriteLine($"Fields in {typeof(T)} class: {fields.Length}");
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void GetRealisedInterfaces<T>(T obj)
        {
            Type type = (typeof(T));
            var interfaces = type.GetInterfaces();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine($"Realised interfaces in {typeof(T)}: {interfaces.Length}");
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void SearchMethodByParameterType<T>(T obj, string parameterClassName)
        {
            Type type = (typeof(T));
            //var info = type.GetMethods();

            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine("\n---------------------------------------------------");
                sw.WriteLine("Check methods and it's parameters: ");
                foreach (MethodInfo mi in type.GetMethods())
                {
                    foreach (ParameterInfo pr in mi.GetParameters())
                    {
                        if(pr.ParameterType.Name == parameterClassName)
                        {
                            sw.WriteLine($"Method Name: {mi.Name}");
                            sw.WriteLine($"Parameter Name: {pr.Name}");
                            sw.WriteLine($"Type: {pr.ParameterType}");
                        }
                    }
                    sw.WriteLine();
                }
                sw.WriteLine("---------------------------------------------------");
            }
        }

        public static void WorkWithInvoke<T>(T obj)
        {

            Console.WriteLine("\n----------------------------------------------");

            Console.WriteLine("----------------------------------------------");
        }

        public static object Create<T>(T obj, object[] parms) where T : class, new()
        {
            int a;
            string b;

            Type type = typeof(T);

            List<Type> paramTypes = new List<Type>();

            foreach(var item in parms)
            {
                paramTypes.Add(item.GetType());    
            }

            ConstructorInfo constructorInfo = type.GetConstructor(paramTypes.ToArray());
            var newobj = constructorInfo.Invoke(parms);


            return newobj;
        }
    }
}
