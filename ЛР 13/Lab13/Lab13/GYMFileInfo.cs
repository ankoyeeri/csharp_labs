using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    /// <summary>
    /// Вывод информации о конкретном файле
    /// </summary>
    class GYMFileInfo : EventListener
    {
        public static event Handler Notify;
        //  полный путь
        public static void GetFullPath()
        {
            string fileName = @"JustAFile.txt";
            FileInfo fileInfo = new FileInfo(fileName);

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"Full Path: {fileInfo.DirectoryName}");
            Console.WriteLine("--------------------------------");

            Notify?.Invoke($"Action: Get full path.\nFile name: {fileName}\nTime: {DateTime.Now}");
        }

        //  размер, расширение, имя
        public static void GetFileSize()
        {
            string fileName = @"JustAFile.txt";
            FileInfo fileInfo = new FileInfo(fileName);

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"File size: {fileInfo.Length}");
            Console.WriteLine($"File extension: {fileInfo.Extension}");
            Console.WriteLine($"File name: {fileInfo.Name}");
            Console.WriteLine("--------------------------------");

            Notify?.Invoke($"Action: Get file size.\nFile name: {fileName}\nTime: {DateTime.Now}");
        }

        //  дата создания, изменения
        public static void GetDateOfFile()
        {
            string fileName = @"JustAFile.txt";
            FileInfo fileInfo = new FileInfo(fileName);

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine($"Creation time: {fileInfo.CreationTime}");
            Console.WriteLine($"Last write time: {fileInfo.LastWriteTime}");
            Console.WriteLine("--------------------------------");

            Notify?.Invoke($"Action: Get date of file.\nFile name: {fileName}\nTime: {DateTime.Now}");
        }
    }
}
