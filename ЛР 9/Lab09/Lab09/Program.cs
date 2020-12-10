using System;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallDelegates.Start();
            Func<string, char> op;
            op = StringProc.DeleteCurrentSymbol;
        }
    }
}
