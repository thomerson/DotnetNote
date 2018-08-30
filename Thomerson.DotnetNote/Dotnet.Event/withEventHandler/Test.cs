using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event.withEventHandler
{
    public class Test
    {

        public static void TestWithEventHander()
        {
            var cat = new Cat("CC");

            var mouse1 = new Mouse("a", cat);
            var mouse2 = new Mouse("b", cat);
            var mouse3 = new Mouse("c", cat);

            var master = new Master("MM", cat);

            cat.Cry_Event();

        }
    }
}
