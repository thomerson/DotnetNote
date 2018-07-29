using System;

namespace Dotnet.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // 左边指定字段名称
            (int one, int two) tuple = (1, 2);
            Console.WriteLine($"first：{tuple.one}, second：{tuple.two}");

            // 右边指定字段名称
            var tuple2 = (one: 1, two: 2);
            Console.WriteLine($"first：{tuple2.one}, second：{tuple2.two}");

            // 左右两边同时指定字段名称
            (int one, int two) tuple3 = (first: 1, second: 2);    /* 此处会有警告：由于目标类型（xx）已指定了其它名称，因为忽略元组名称xxx */
            Console.WriteLine($"first：{tuple3.one}, second：{tuple3.two}");

            Console.WriteLine("Hello World!");
        }
    }
}
