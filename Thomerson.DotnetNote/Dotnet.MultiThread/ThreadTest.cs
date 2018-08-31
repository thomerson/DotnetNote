using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.MultiThread
{
    class ThreadTest
    {
        public static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread newThread = new Thread(Work);
                // 开启新线程
                newThread.Start(i);
            }
        }
        public static void Work()
        {
            int i = 0;
            Console.WriteLine("线程{0}开始", i);
            // 模拟做了一些工作，耗费5s时间
            Thread.Sleep(5000);
            Console.WriteLine("线程{0}结束", i);
        }
    }
}
