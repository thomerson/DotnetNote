using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEventHandler
{
    class Master
    {
        public string name { get; set; }
        public Master(string name, Cat cat)
        {
            this.name = name;
            cat.CustomEvent += WakeUp;
        }

        public void WakeUp(object sender, EventArgs args)
        {
            Console.WriteLine(this.name + " wake up");
        }
    }
}
