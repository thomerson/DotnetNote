using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event
{
    public delegate void DeleSay();

    public class Cat
    {
        public DeleSay ev;
        public Cat()
        {
            ev = new DeleSay(Say);
        }
        public void Say()
        {
            Console.WriteLine("Cat say");
        }
    }
}
