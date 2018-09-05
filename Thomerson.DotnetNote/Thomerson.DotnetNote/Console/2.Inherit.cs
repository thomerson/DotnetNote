using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote.Inherit
{
    public class A
    {
        public virtual void Fun1(int i)
        {
            Console.WriteLine(i);
        }
        public void Fun2(A a)
        {
            a.Fun1(1);
            Fun1(5);
        }
    }

    public class B : A
    {
        public override void Fun1(int i)
        {
            base.Fun1(i + 1);
        }
        public static void Test()
        {
            B b = new B();
            A a = new A();
            a.Fun2(b); //1+1 5
            b.Fun2(a); //1 5+1
        }
    }
}
