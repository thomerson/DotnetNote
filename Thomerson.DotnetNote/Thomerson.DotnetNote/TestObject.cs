using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote
{
    public class TestObject
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public TestObject(string name)
        {
            this.Name = name;
        }
    }
}
