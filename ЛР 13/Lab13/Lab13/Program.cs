using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            GYMDiskInfo.Notify += GYMLog.WriteEvent;
            GYMFileInfo.Notify += GYMLog.WriteEvent;
            GYMDirInfo.Notify += GYMLog.WriteEvent;
            GYMFileManager.Notify += GYMLog.WriteEvent;

            GYMDiskInfo.GetFreeSpace();
            GYMDiskInfo.GetFileSystem();
            GYMDiskInfo.GetDiskInfo();

            GYMFileInfo.GetFullPath();
            GYMFileInfo.GetFileSize();
            GYMFileInfo.GetDateOfFile();

            GYMDirInfo.GetNumberOfFiles();
            GYMDirInfo.GetTimeOfCreate();
            GYMDirInfo.GetNumOfSubDirrectories();
            GYMDirInfo.ShowParentDirectories();

            //GYMLog.GetNumberOfNotes();
            //GYMLog.DeleteDataByTime();

            bool flag = true;
            int i = 1;
            Console.WriteLine("Выберите, какое вы хотите сделать действие с файлами");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.CreateDirectoryWithFilledFile)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.CreateFileCopyAndRename)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.CreateSecondDirectory)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.CopyFilesFromSpecialFolder)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.ReplaceFilesToInspect)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.ArchiveAndReplace)}");
            Console.WriteLine($"{i++}) {nameof(GYMFileManager.UnarchiveZip)}");
            Console.WriteLine($"{i++}) Выход");
            
            
            while(flag)
            {
                Console.Write("---> ");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        GYMFileManager.CreateDirectoryWithFilledFile();
                        break;
                    case 2:
                        GYMFileManager.CreateFileCopyAndRename();
                        break;
                    case 3:
                        GYMFileManager.CreateSecondDirectory();
                        break;
                    case 4:
                        GYMFileManager.CopyFilesFromSpecialFolder(".txt");
                        break;
                    case 5:
                        GYMFileManager.ReplaceFilesToInspect();
                        break;
                    case 6:
                        GYMFileManager.ArchiveAndReplace();
                        break;
                    case 7:
                        GYMFileManager.UnarchiveZip();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
            }

        }

        public static void ClickToContinue()
        {
            Console.WriteLine("Нажмите, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
