using System;

namespace DotnetEvent
{
    public class Client
    {
        void TestWithoutEvent()
        {
            MyButton mb = new MyButton("MyButton对象");
            //指定点击按钮后的处理方法
            mb.Click += MyButton_Click;
            mb.Click("Click为公共委托对象，可任意触发执行委托方法，而无需触发OnClick方法");

            Console.ReadKey();
        }

        private void MyButton_Click(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
