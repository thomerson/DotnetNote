using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.MultiThread.MultiTask
{
    class TaskTest
    {
        public static void Test()
        {
            var task = new Task<string>(() =>
            {
                Console.WriteLine("New Task");
                return "New Task";
            });

            //ContinueWith 需要带参数 是上面Task的返回Action<Task<TResult>>
            task.ContinueWith((obj) =>
            {
                //参数 需要去拿result
                Console.WriteLine("ContinueWith {0}", obj.Result);
            });


            task.Start(); //object function


            Task.Run(() =>  //static function 
            {
                Console.WriteLine("New Task Run");
            });

            var newTask = GetString();
            newTask.Start(); //需要start之后才能拿到result
            var result = newTask.Result;
            Console.WriteLine("Get string result : " + result);

        }

        public static Task<string> GetString()
        {
            return new Task<string>(() =>
            {
                return "string";
            });
        }
    }
}
