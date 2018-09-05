using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote.AbstractConstract
{
    public abstract class A
    {
        public A()
        {
            Console.WriteLine('A');
        }
        public virtual void Fun()
        {
            Console.WriteLine("A.Fun()");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine('B');
        }
        public new void Fun()
        {
            Console.WriteLine("B.Fun()");
        }

        public static void Test()
        {
            A a = new B();
            a.Fun();
        }
    }
}
