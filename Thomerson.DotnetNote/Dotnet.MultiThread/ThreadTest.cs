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
                var newThread = new Thread(Work);

                //Thread newThread = new Thread(new ThreadStart(() =>
                //{
                //    Work();
                //}));
                Console.WriteLine("线程ID{0}结束", newThread.ManagedThreadId);
                newThread.Start();

                //ParameterizedThreadStart有参 参数类型必须为object
                var nnt = new Thread(new ParameterizedThreadStart(WorkWithParm));
                Console.WriteLine("线程ID{0}结束", nnt.ManagedThreadId);
                // 开启新线程
                nnt.Start(i);
            }
        }

        /// <summary>
        /// 无参数
        /// </summary>
        public static void Work()
        {
            int i = 0;
            Console.WriteLine("线程{0}开始", i);
            // 模拟做了一些工作，耗费5s时间
            Thread.Sleep(5000);
            Console.WriteLine("线程{0}结束", i);
        }

        /// <summary>
        /// 有参 参数类型必须为object
        /// </summary>
        /// <param name="i"></param>
        public static void WorkWithParm(object i)
        {
            Console.WriteLine("线程{0}开始", i);
            // 模拟做了一些工作，耗费5s时间
            Thread.Sleep(5000);
            Console.WriteLine("线程{0}结束", i);
        }
    }
}
