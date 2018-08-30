using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEvent
{
    public delegate void Dele_Cry();
    class Cat
    {
        public string name { get; set; }
        public event Dele_Cry Eve_Cry;
        public Cat(string name, List<IObserve> list)
        {
            Eve_Cry = new Dele_Cry(Cry);
            this.name = name;
            foreach (var item in list)
            {
                Eve_Cry += item.Response;
            }
        }

        public void Cry()
        {
            Console.WriteLine(this.name + " start to run");
        }

        public void Cry_Event()
        {
            this.Eve_Cry?.Invoke();
        }
    }
}
