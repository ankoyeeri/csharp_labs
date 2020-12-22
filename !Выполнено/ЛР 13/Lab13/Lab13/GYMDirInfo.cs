using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    /// <summary>
    /// Вывод информации о конкретном директории
    /// </summary>
    class GYMDirInfo : EventListener
    {
        public static event Handler Notify;
        const string dirName = "E:\\Soft";
        //  количество файлов
        public static void GetNumberOfFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"Name: {directoryInfo.Name}");
            Console.WriteLine($"Number of files: {directoryInfo.GetFiles().Length}");
            Console.WriteLine("------------------------------");
            Notify?.Invoke($"Action: Get number of files.\nDirectory name: {directoryInfo.Name}\nTime: {DateTime.Now}");
        }

        //  время создания
        public static void GetTimeOfCreate()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"Name: {directoryInfo.Name}");
            Console.WriteLine($"Directory creation time: {directoryInfo.CreationTime}");
            Console.WriteLine("------------------------------");
            Notify?.Invoke($"Action: Get time of create.\nDirectory name: {directoryInfo.Name}\nTime: {DateTime.Now}");
        }

        //  количество поддиректориев
        public static void GetNumOfSubDirrectories()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);
            //var dirs = Directory.GetParent(dirName);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"Name: {directoryInfo.Name}");
            Console.WriteLine($"Number of directories: {directoryInfo.GetDirectories().Length}");
            Console.WriteLine("------------------------------");

            Notify?.Invoke($"Action: Get number of subdirrectories.\nDirectory name: {directoryInfo.Name}\nTime: {DateTime.Now}");
        }

        //  список родительских директориев
        public static void ShowParentDirectories()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dirName);

            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Root name:");
            foreach(var d in directoryInfo.Root.GetDirectories())
            {
                Console.WriteLine($"{d.Name}");
            }
            Console.WriteLine("------------------------------");

            Notify?.Invoke($"Action: Show parrent directories.\nDirectory name: {directoryInfo.Name}\nTime: {DateTime.Now}");
        }

    }
}
