using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEventHandler
{
    class Mouse
    {
        public string name { get; set; }
        public Mouse(string name, Cat cat)
        {
            this.name = name;
            cat.CustomEvent += Run;
        }

        public void Run(object sender, EventArgs args)
        {
            Console.WriteLine(this.name + " Run");
        }
    }
}
