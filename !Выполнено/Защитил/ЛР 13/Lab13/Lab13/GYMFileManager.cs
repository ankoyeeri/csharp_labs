using System;

using System.IO;
using System.IO.Compression;

namespace Lab13
{
    class GYMFileManager : EventListener
    {
        public static event Handler Notify;

        /// <summary>
        /// Создание директории с заполенными файлами
        /// </summary>
        public static void CreateDirectoryWithFilledFile()
        {
            string dirName = @"E:\TestFolder\GYMInspect\";
            string fileName = "GYMdirinfo.txt";

            Directory.CreateDirectory(dirName);
            Console.WriteLine("Директория создана");

            Notify?.Invoke($"Action: Create directory.\nDirectory name: {dirName}.\nTime: {DateTime.Now}");

            File.WriteAllText(dirName + fileName, "Здесь находится какой-то текст");
            Console.WriteLine("Файл создан");
            Notify?.Invoke($"Action: Create file with text inside.\nDirectory name: {dirName + fileName}.\nTime: {DateTime.Now}");
        }

        /// <summary>
        /// Создает файл, копирует его в другую папку и удаляет
        /// </summary>
        public static void CreateFileCopyAndRename()
        {
            string dirName = @"E:\TestFolder\GYMInspect\";
            string fileName = "GYMdirinfo.txt";

            File.Copy(dirName + fileName, dirName + "GYMdirinfo(copy).txt");
            Console.WriteLine("Файл скопирован");
            Notify?.Invoke($"Action: Copy file into {dirName}.\nDirectory name: {dirName + fileName}.\nTime: {DateTime.Now}");

            File.Delete(dirName + fileName);
            Console.WriteLine("Удаление первоначального файла");
            Notify?.Invoke($"Action: Delete file.\nDirectory name: {dirName + fileName}.\nTime: {DateTime.Now}");

        }

        /// <summary>
        /// Создает второй директорий Files
        /// </summary>
        public static void CreateSecondDirectory()
        {
            string dirName = @"E:\TestFolder\GYMFiles\";

            Directory.CreateDirectory(dirName);
            Notify?.Invoke($"Action: Create directory.\nDirectory name: {dirName}.\nTime: {DateTime.Now}");
        }

        /// <summary>
        /// Копирует файлы из специальной папки, с указанием искомого типа
        /// </summary>
        /// <param name="specType"></param>
        public static void CopyFilesFromSpecialFolder(string specType)
        {
            string dirName = @"E:\TestFolder\GYMFiles\";
            string specFolder = @"E:\TestFolder\SpecialFolder\";


            foreach (var f in Directory.GetFiles(specFolder, "*" + specType))
            {
                FileInfo fileInfo = new FileInfo(f);
                fileInfo.CopyTo(dirName + fileInfo.Name);
            }

            Notify?.Invoke($"Action: Copy file with {specType} format.\nDirectory name: {dirName}.\nTime: {DateTime.Now}");
        }

        /// <summary>
        /// Перемещает файлы из папки Files в папку Inspect
        /// </summary>
        public static void ReplaceFilesToInspect()
        {
            string dirFiles = @"E:\TestFolder\GYMFiles\";
            string dirInspect = @"E:\TestFolder\GYMInspect\";

            foreach (var f in Directory.GetFiles(dirFiles))
            {
                FileInfo fileInfo = new FileInfo(f);
                fileInfo.MoveTo(dirInspect + fileInfo.Name);
            }

            Notify?.Invoke($"Action: Replase files to {dirInspect}.\nDirectory name: {dirFiles}.\nTime: {DateTime.Now}");
        }


        //  Сделайте архив из файлов директория ... . Разархивировать его в другой директорий
        public static void ArchiveAndReplace()
        {
            string dirFiles = @"E:\TestFolder\GYMFiles\";
            string dirInspect = @"E:\TestFolder\GYMInspect\";

            ZipFile.CreateFromDirectory(dirFiles, dirInspect + "GYMFiles.zip");
            
            Notify?.Invoke($"Action: Archive directory {dirInspect + "GYMFiles.zip"}.\nDirectory name: {dirFiles}.\nTime: {DateTime.Now}");
        }

        public static void UnarchiveZip()
        {
            string dirInspect = @"E:\TestFolder\GYMInspect\";

            ZipFile.ExtractToDirectory(dirInspect + "GYMFiles.zip", dirInspect + "GYMFiles");
            Console.WriteLine("Файл разорхивирован");
            Notify?.Invoke($"Action: Archive directory {dirInspect + "GYMFiles"}.\nDirectory name: {dirInspect}.\nTime: {DateTime.Now}");
        }
    }
}
