using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote.Function
{
    class NewOverrideTest
    {
        public static void Test()
        {
            Father father = new Son();
            father.Fun1(); //new 
            father.Fun2(); //override

            Console.WriteLine("*****************");

            var son = new Son();
            son.Fun1();
            son.Fun2();
        }
    }

    public class Father
    {
        public virtual void Fun1()
        {
            Console.WriteLine("father fun1");
        }

        public virtual void Fun2()
        {
            Console.WriteLine("father fun2");
        }
    }

    public class Son : Father
    {
        public new void Fun1()
        {
            //base.Fun1();
            Console.WriteLine("new son fun1");
        }

        public override void Fun2()
        {
            //base.Fun2();
            Console.WriteLine("new son fun2");
        }
    }
}
