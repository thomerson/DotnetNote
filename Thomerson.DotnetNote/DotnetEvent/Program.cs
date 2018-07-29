using System;

namespace Thomerson.DotnetEvent
{
    class Program
    {
        //声明一个委托
        delegate void MyDel(int n, int m);

        static void Main(string[] args)
        {
            //使用静态方法 Print 作为参数实例化委托
            //MyDel del = Print;

            //使用匿名方法
            MyDel del = (int m, int n) =>
              {
                  Console.Write(m - n + " ");
              };
            Console.WriteLine("准备好了哦，要开始调用委托了哦！");

            for (int i = 0; i < 10; i++)
            {
                del(i, 1);
            }

            Console.Read();
        }
    }
}
