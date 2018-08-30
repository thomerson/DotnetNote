using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEvent
{
    class Test
    {
        public static void TestWithEvent()
        {

            var list = new List<IObserve>() {
                new Mouse("a"),
                new Mouse("b"),
                new Mouse("c"),
                new Master("ss")
            };

            var cat = new Cat("CC", list);

            cat.Cry_Event();
        }
    }
}
