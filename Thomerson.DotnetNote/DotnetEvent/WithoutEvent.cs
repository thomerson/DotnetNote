using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetEvent
{
    class MyButton
    {
        public delegate void MyButtonEventHandler(string msg);

        public MyButtonEventHandler Click;
        private string msg;

        
        //构造函数
        public MyButton(string msg)
        {
            this.msg = msg;
        }
    }
}
