using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;


namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Task 1");
            using (StreamWriter sw = new StreamWriter("ProcessLogFile.txt", false))
            {

                foreach (var process in Process.GetProcesses())
                {
                    sw.WriteLine("----------------------");
                    try
                    {
                        
                        sw.WriteLine($"ID: {process.Id}");
                        sw.WriteLine($"Process name: {process.ProcessName}");
                        sw.WriteLine($"Base priority: {process.BasePriority}");
                        sw.WriteLine($"Start time: {process.StartTime}");
                        sw.WriteLine($"Total processor time{process.TotalProcessorTime}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    sw.WriteLine("----------------------\n");
                }

            }
            Console.WriteLine("Записано в файл.\n");
            #endregion

            #region Task 2
            Console.WriteLine("Task2");
            AppDomain appDomain = AppDomain.CurrentDomain;

            Console.WriteLine("Current domain:");
            Console.WriteLine($"Name: {appDomain.FriendlyName}");
            Console.WriteLine($"Setup info: {appDomain.SetupInformation}");
            Console.WriteLine("Assemblies:");

            foreach (var item in appDomain.GetAssemblies())
            {
                Console.WriteLine($"    Name: {item.GetName().FullName}");
                Console.WriteLine($"    Type: {item.GetType().FullName}\n");
            }

            Console.WriteLine("Creating domain");

            AppDomain newD = AppDomain.CreateDomain("NewDomain");
            Console.WriteLine($"Name: {newD.FriendlyName}");
            newD.Load(Assembly.GetExecutingAssembly().FullName);
            Console.WriteLine($"Loaded assembly: {newD.FriendlyName}");
            AppDomain.Unload(newD);
            Console.WriteLine("Domain unloaded.\n");

            #endregion

            #region Task 3

            Console.WriteLine("\nTask 3\n");
            Console.WriteLine("Creating thread");

            CountOperator.CountNumTo(5);

            #endregion
        }
    }
}
