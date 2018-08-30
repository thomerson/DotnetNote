using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEvent
{
    class Master : IObserve
    {
        public string name { get; set; }
        public Master(string name)
        {
            this.name = name;
        }

        public void Response()
        {
            Console.WriteLine(this.name + " wake up");
        }
    }
}
