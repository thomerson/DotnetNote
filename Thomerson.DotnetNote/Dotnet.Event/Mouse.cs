using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event
{
    public class Mouse
    {
        public string name { get; set; }
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine(this.name + " mouse start running");
        }
    }
}
