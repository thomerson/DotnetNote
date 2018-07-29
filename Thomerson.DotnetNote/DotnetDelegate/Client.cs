using System;

namespace DotnetDelegate
{

    //http://www.cnblogs.com/JiYF/p/6867412.html

    // 委托：函数作为参数传递
    // 用于实现事件和回调方法
    // 派生自 System.Delegate 类
    // 申明委托delegate 
    // 实例化委托 参数是函数
    // 多播 返回类型一般为void，这样才能将委托的单个实例合并为一个多播委托  按顺序执行函数


    /// <summary>
    /// 调用委托的实例就相当于调用方法本身，
    /// 因为委托存储的是一个方法列表，调用委托的实例就相当于依次调用方法列表的内容
    /// </summary>
    public class Client
    {
        public delegate int Calculate(int a, int b);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }

        void Test()
        {
            var addCalculate = new Calculate(Add);

            var minusCalculate = new Calculate(Minus);

            var result = addCalculate(3, 9);
            Console.WriteLine(result);
            result = minusCalculate(5, 1);
            Console.WriteLine(result);

        }
    }
}

/******************************委托
 * 委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递
 * 使用委托可以将多个方法绑定到同一个委托变量 委托多播
 * 
 * ***************************事件
 * 声明一个事件不过类似于声明一个进行了封装的委托类型的变量而已
 * 
 * **************************Observer设计模式
 * Subject：监视对象，它往往包含着其他对象所感兴趣的内容
 * Observer：监视者，它监视Subject，当Subject中的某件事发生的时候，会告知Observer，而Observer则会采取相应的行动
 * Observer设计模式是为了定义对象间的一种一对多的依赖关系，以便于当一个对象的状态改变时，其他依赖于它的对象会被自动告知并更新。Observer模式是一种松耦合的设计模式。
 * 
 * 
 * *************************.Net Framework中的委托与事件
 *  .Net Framework的编码规范
 *      委托类型的名称都应该以EventHandler结束。
 *      委托的原型定义：有一个void返回值，并接受两个输入参数：一个Object 类型(代表了Subject，也就是监视对象,可以通过它访问触发事件的对象)，一个 EventArgs类型(或继承自EventArgs,包含了Observer所感兴趣的数据)。
 *      事件的命名为 委托去掉 EventHandler之后剩余的部分。
 *      继承自EventArgs的类型应该以EventArgs结尾。
 *      
 *      
 * ******************************/


