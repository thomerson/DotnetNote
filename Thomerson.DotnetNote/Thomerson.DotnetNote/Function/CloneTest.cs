using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote.Function
{
    class CloneTest
    {
        public static void Test()
        {
            var obj = new TestCloneObject("test");
            //var clo = 
        }
    }

    public class TestCloneObject : Object, ICloneable
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public object Clone()
        {
            //只有访问是通过子类发生时，父类中的protected变量才能被访问
            return this.MemberwiseClone();
        }

        public TestCloneObject(string name)
        {
            this.Name = name;
        }
    }

}
