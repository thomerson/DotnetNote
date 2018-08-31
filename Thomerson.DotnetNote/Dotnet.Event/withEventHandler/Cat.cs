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

        //CustomEventArgs:EventArgs
        //public event EventHandler<CustomEventArgs> CustomEvent;

        public Cat(string name)
        {
            this.name = name;
            CustomEvent = new EventHandler(Cry_Event); // 不能在Cat外面对event修饰的delegate赋值
            //CustomEvent += Cry_Event;
        }

        public void Cry_Event(object sender, EventArgs args)
        {
            Console.WriteLine(this.name + " Cry");
        }

        public void Cry()
        {
            this.CustomEvent?.Invoke(this, new EventArgs());
        }

    }
}
