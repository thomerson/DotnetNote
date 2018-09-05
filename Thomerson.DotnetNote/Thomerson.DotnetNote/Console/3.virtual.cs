using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote.Virtual
{
    class A
    {
        public A()
        {
            PrintFields();
        }
        public virtual void PrintFields() { }
    }
    internal class B : A
    {
        int x = 1;
        int y;
        public B()
        {
            y = -1;
        }
        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }

        public static void Test()
        {
            B b = new B(); //1 0 
            b.PrintFields();//1 -1
        }
    }
}
