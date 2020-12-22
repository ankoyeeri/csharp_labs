using System;
using System.IO;

namespace Lab13
{
    class GYMLog
    {
        const string file = "gymlogfile.txt";

        public static void WriteEvent(string message)
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine("---------------------");
                sw.WriteLine(message);
                sw.WriteLine("---------------------\n");
            }
        }

        public static void GetNumberOfNotes()
        {
            bool flagNote = false;
            string buffer;
            int count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    buffer = sr.ReadLine();

                    if (buffer.Length != 0)
                    {
                        if(buffer[0] == '-')
                        {
                            if (flagNote)
                            {
                                flagNote = false;
                                count++;
                            }
                            else
                            {
                                flagNote = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Number of notes in {file}: {count}");
        }

        public static void DeleteDataByTime()
        {
            string stringBuffer;
            string? buffer = null;
            DateTime dateTime;

            using(StreamReader sr = new StreamReader(file))
            {
                while(!sr.EndOfStream)
                {
                    stringBuffer = sr.ReadLine();
                    buffer += stringBuffer + '\n';

                    if(stringBuffer.Length != 0)
                    {
                        if(stringBuffer[0] == 'T')
                        {
                            dateTime = Convert.ToDateTime(stringBuffer.Substring(6));

                            if(DateTime.Now.Hour != dateTime.Hour)
                            {
                                buffer = null;
                            }
                        }
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(file, false))
            {
                sw.WriteLine(buffer);
            }
        }
    }
}
