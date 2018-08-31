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
            //The event 'Cat.CustomEvent' can only appear on the left hand side of += or -= (except when used from within the type 'Cat')
            //cat.CustomEvent = new EventHandler(Run_Event); //不能在cat外面对event申明的delegate进行赋值，只能注册+和删除-
            cat.CustomEvent += Run_Event;
        }

        public void Run_Event(object sender, EventArgs args)
        {
            Console.WriteLine(this.name + " Run");
        }
    }
}
