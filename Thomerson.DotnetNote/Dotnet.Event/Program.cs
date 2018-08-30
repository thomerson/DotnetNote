using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //withEvent.Test.TestWithEvent();
            withEventHandler.Test.TestWithEventHander();
            Console.ReadLine();
        }

        static void Test()
        {
            var cat = new Cat();
            var list = new List<Mouse>() {
                new Mouse("a"),
                new Mouse("b"),
                new Mouse("c")
            };
            foreach (var item in list)
            {
                cat.ev += item.Run;
            }
            var boy = new Boy("ss");
            cat.ev += boy.WakeUp;

            cat.ev?.Invoke();

        }
    }
}
