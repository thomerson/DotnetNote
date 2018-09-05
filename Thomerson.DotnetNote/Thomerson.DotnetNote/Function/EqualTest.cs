using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote
{
    /// <summary>
    /// equal and "=="
    /// </summary>
    class EqualTest
    {
        /// <summary>
        /// ==比较的是栈空间的值，Equal比较的是堆空间的值
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("值类型");
            int aa = 1;
            int bb = 1;
            Console.WriteLine(aa == bb); //结果为true
            Console.WriteLine(aa.Equals(bb));//结果为true

            Console.WriteLine("****************************************");
            Console.WriteLine("string类型");
            //C#中的string类型是引用类型，赋值操作则是按值类型操作。
            string a = new string(new char[] { 'w', 'j', 'g', 'b', 'a', 'b', 'y', '.', 'c', 'o', 'm' });
            string b = new string(new char[] { 'w', 'j', 'g', 'b', 'a', 'b', 'y', '.', 'c', 'o', 'm' });
            Console.WriteLine(a == b); //结果为true
            Console.WriteLine(a.Equals(b));//结果为true

            Console.WriteLine("****************************************");
            Console.WriteLine("引用类型 New");
            object g = a;
            object h = b;
            Console.WriteLine(g == h);//结果为false
            Console.WriteLine(g.Equals(h));//结果为true

            Console.WriteLine("****************************************");
            Console.WriteLine("引用类型 New object");
            People p1 = new People("wjg");
            People p2 = new People("wjg");
            Console.WriteLine(p1 == p2);//结果为false
            Console.WriteLine(p1.Equals(p2));//结果为false

            Console.WriteLine("****************************************");
            Console.WriteLine("引用类型 copy");
            People p3 = new People("wjg");
            People p4 = p3;
            Console.WriteLine(p3 == p4);//结果为true
            Console.WriteLine(p3.Equals(p4));//结果为true

        }
    }

    class People
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public People(string name)
        {
            this.name = name;
        }
    }
}
