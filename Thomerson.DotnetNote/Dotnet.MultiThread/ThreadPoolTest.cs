using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dotnet.MultiThread
{
    class ThreadPoolTest
    {
        public static void Test()
        {
            //设置同时执行最大执行数  和  最大异步I/O线程数
            ThreadPool.SetMaxThreads(5, 10);

            for (int i = 0; i < 20; i++)
            {
                //添加线程  带object参数
                ThreadPool.QueueUserWorkItem(Work, i);
            }

        }

        public static void Work(object state)
        {
            Console.WriteLine("thread:{0} start", state);
            Thread.Sleep(5000);
            Console.WriteLine("thread:{0} end", state);
        }
    }
}
