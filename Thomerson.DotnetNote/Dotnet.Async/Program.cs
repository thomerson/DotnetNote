using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.Async
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Hello World!");
        //    Console.ReadLine();
        //}


        //static async Task<string> BackAsync()
        //{
        //    return await Task.Run(() =>
        //    {
        //        return "Async";
        //    });
        //}

        #region MyRegion
        static void Main(string[] args)
        {
            try
            {
                Say();
                Console.WriteLine("Hello World!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        static async Task<string> TestAsync()
        {
            return await Task.Run(() =>
            {
                var dd = 0;
                var jj = 100 / dd;
                Thread.Sleep(4000);
                return "Hello World";
            });
        }

        private async static void Say()
        {
            var t = TestAsync();
            Thread.Sleep(1100);                                     //主线程在执行一些任务
            Console.WriteLine("Main Thread");                       //主线程完成标记
            Console.WriteLine(await t);                             //await 主线程等待取异步返回结果
        }

        static async Task ThrowAfter(int timeout, Exception ex)
        {
            await Task.Delay(timeout);
            throw ex;
        }

        static async void Test()
        {
            Task all = null;
            try
            {
                await (all = Task.WhenAll(
                    ThrowAfter(1000, new Exception("Ex1")),
                    ThrowAfter(2000, new Exception("Ex2"))));
            }
            catch
            {
                foreach (var ex in all.Exception.InnerExceptions)
                {

                }
            }
        }
        #endregion
    }
}
