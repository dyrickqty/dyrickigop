using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FrmBasicThreadLobusta
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopingCount = 0; loopingCount<6; loopingCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopingCount);
                Thread.Sleep(1500);
            }
        }
    }
}
