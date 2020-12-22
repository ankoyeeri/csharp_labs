using System;
using System.IO;

namespace Lab13
{
    class GYMDiskInfo : EventListener
    {
        public static event Handler Notify;
        public static void GetFreeSpace()
        {
            var allDrives = DriveInfo.GetDrives();

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("GetFreeSpace");
            foreach (var d in allDrives)
            {
                Console.WriteLine($"Drive name: {d.Name}");
                Console.WriteLine($"Avaliable: {d.AvailableFreeSpace}");
            }
            Console.WriteLine("--------------------------------");
            
            
            Notify?.Invoke($"Action: Get free disk space.\nTime: {DateTime.Now}");
        }

        public static void GetFileSystem()
        {
            var drives = DriveInfo.GetDrives();

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("GetFileSystem");
            Console.WriteLine($"Drive Format: {drives[0].DriveFormat}");
            Console.WriteLine("--------------------------------");

            Notify?.Invoke($"Action: Get dirve file system.\nDrive name: {drives[0].Name}\nTime: {DateTime.Now}");
        }

        public static void GetDiskInfo()
        {
            var drives = DriveInfo.GetDrives();

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("GetFileSystem");
            foreach (var d in drives)
            {
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Total size: {d.TotalSize}");
                Console.WriteLine($"Avaliavle size: {d.AvailableFreeSpace}");
                Console.WriteLine($"Volume label: {d.VolumeLabel}\n");
            }
            Console.WriteLine("--------------------------------");

            Notify?.Invoke($"Action: Get dirve file system.\nTime: {DateTime.Now}");
        }
    }
}
