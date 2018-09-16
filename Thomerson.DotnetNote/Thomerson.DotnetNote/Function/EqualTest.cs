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
            /* 值类型 */
            Console.WriteLine("值类型");
            int aa = 1;
            int bb = 1;
            int cc = bb;
            Console.WriteLine(aa == bb); //结果为true
            Console.WriteLine(aa.Equals(bb));//结果为true
            Console.WriteLine(int.ReferenceEquals(aa, bb));//结果为false
            Console.WriteLine(int.ReferenceEquals(cc, bb));//结果为false

            Console.WriteLine("****************************************");
            Console.WriteLine("string new");
            //C#中的string类型是引用类型，赋值操作则是按值类型操作。
            string a = new string(new char[] { 'w', 'j', 'g', 'b', 'a', 'b', 'y', '.', 'c', 'o', 'm' });
            string b = new string(new char[] { 'w', 'j', 'g', 'b', 'a', 'b', 'y', '.', 'c', 'o', 'm' });
            Console.WriteLine(a == b); //结果为true
            Console.WriteLine(a.Equals(b));//结果为true
            Console.WriteLine(string.ReferenceEquals(a, b));//结果为false

            Console.WriteLine("****************************************");
            Console.WriteLine("string to object: new object");
            object g = a;
            object h = b;
            Console.WriteLine(g == h);//结果为false
            Console.WriteLine(g.Equals(h));//结果为true
            Console.WriteLine(object.ReferenceEquals(g, h));//结果为false

            Console.WriteLine("****************************************");
            Console.WriteLine("引用类型 New object");
            People p1 = new People("wjg");
            People p2 = new People("wjg");
            Console.WriteLine(p1 == p2);//结果为false
            Console.WriteLine(p1.Equals(p2));//结果为false
            Console.WriteLine(object.ReferenceEquals(p1, p2));//结果为false

            Console.WriteLine("****************************************");
            Console.WriteLine("引用类型 copy");
            People p3 = new People("wjg");
            People p4 = p3;
            Console.WriteLine(p3 == p4);//结果为true
            Console.WriteLine(p3.Equals(p4));//结果为true
            Console.WriteLine(object.ReferenceEquals(p3, p4));//结果为true


            //==操作符：
            //如果两个基本数据类型的操作数，它们的数值相等，它们就被认为是相等的
            //如果两个object类型的表达式都指向相同的对象或者都是空，它们被认为是相等的
            //如果字符串实例有相同的长度并且在每个字符的位置都相同或者都为空，它们被认为是相等的


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
