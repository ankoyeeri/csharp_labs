using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Lab15
{
    class FunctionController
    {
        public static void Task1()
        {
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
        }

        public static void Task2()
        {
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
        }

        public static void Task3()
        {
            Console.WriteLine("\nTask 3\n");
            Console.WriteLine("Creating thread");

            Thread thread = new Thread(new ThreadStart(CountOperator.CountSimpleNumTo));
            thread.Name = "CountingSimpleNums";

            thread.Start();

            Thread.Sleep(3000);
            thread.Suspend();

            Console.WriteLine($"\nThread Info:");
            Console.WriteLine($"Thread name: {thread.Name}");
            Thread.Sleep(500);
            Console.WriteLine($"Thread ID: {thread.ManagedThreadId}");
            Thread.Sleep(500);
            Console.WriteLine($"Thread priority: {thread.Priority}");
            Thread.Sleep(500);

            thread.Resume();
        }

        public static void Task4()
        {
            int num = 10;
            string message;

            StreamWriter sw = new StreamWriter("Task4.txt", false);

            #region EvenThread hight priority:
            message = "EvenThread hight priority:";

            Console.WriteLine(message);
            sw.WriteLine(message);

            Thread evenThread = new Thread(new ParameterizedThreadStart(Even));
            Thread oddThread = new Thread(new ParameterizedThreadStart(Odd));

            evenThread.Priority = ThreadPriority.Highest;

            oddThread.Start(num);
            evenThread.Start(num);

            Thread.Sleep(500);

            Console.WriteLine();
            sw.WriteLine();
            #endregion

            #region FirstEven
            message = "\nFirst Even numbers. Then - Odd numbers:";
            
            Console.WriteLine(message);
            sw.WriteLine(message);

            Thread evenHightPr = new Thread(new ParameterizedThreadStart(Even));
            Thread oddLowPr = new Thread(new ParameterizedThreadStart(Odd));

            evenHightPr.Start(num);
            evenHightPr.Join();
            oddLowPr.Start(num);

            Thread.Sleep(500);

            Console.WriteLine();
            sw.WriteLine();
            #endregion

            #region Sequence of Even and Odd

            message = "\nSequence of Even and Odd:";
            
            Console.WriteLine(message);
            sw.WriteLine(message);
            Mutex mutex = new Mutex();

            Thread evenThr = new Thread(new ParameterizedThreadStart(MutexEven));
            Thread oddThr = new Thread(new ParameterizedThreadStart(MutexOdd));

            evenThr.Start(num);
            oddThr.Start(num);
            oddThr.Join();
            Thread.Sleep(500);
            sw.WriteLine();
            #endregion

            void Even(object n)
            {
                for (int i = 2; i <= (int)n; i += 2)
                {
                    Console.Write($"{i} ");
                    sw.Write($"{i} ");
                    Thread.Sleep(100);
                }
            }
            void Odd(object n)
            {
                for (int i = 1; i <= (int)n; i += 2)
                {
                    Console.Write($"{i} ");
                    sw.Write($"{i} ");
                    Thread.Sleep(80);
                }
            }

            void MutexEven(object n)
            {
                for (int i = 2; i <= (int)n; i += 2)
                {
                    mutex.WaitOne();

                    Console.Write($"{i} ");
                    sw.Write($"{i} ");
                    Thread.Sleep(100);

                    mutex.ReleaseMutex();
                }
            }
            void MutexOdd(object n)
            {
                for (int i = 1; i <= (int)n; i += 2)
                {
                    mutex.WaitOne();

                    Console.Write($"{i} ");
                    sw.Write($"{i} ");
                    Thread.Sleep(80);

                    mutex.ReleaseMutex();
                }
            }

            Console.WriteLine("\nClosing stream...");
            sw.Close();
        }
    
        public static void Task5()
        {
            int num = 0;

            TimerCallback tm = new TimerCallback(CountOperator.ClockFunc);

            var timer = new Timer(tm, 0, 100, 1000);

            Console.ReadKey();
            timer.Dispose();
        }
    }
}
