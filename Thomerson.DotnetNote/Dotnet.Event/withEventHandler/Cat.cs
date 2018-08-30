using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEventHandler
{
    class Cat
    {
        public event EventHandler CustomEvent;
        public string name { get; set; }

        //public event EventHandler<CustomEventArgs> CustomEvent;

        public Cat(string name)
        {
            CustomEvent += Cry;
        }

        public void Cry(object sender, EventArgs args)
        {
            Console.WriteLine(this.name + " Cry");
        }

        public void Cry_Event()
        {
            this.CustomEvent?.Invoke(this, new EventArgs());
        }

    }
}
