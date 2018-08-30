using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event
{
    class Boy
    {
        public string name { get; set; }

        public Boy(string name)
        {
            this.name = name;
        }
        public void WakeUp()
        {
            Console.WriteLine("Boy wake up");
        }
    }
}
