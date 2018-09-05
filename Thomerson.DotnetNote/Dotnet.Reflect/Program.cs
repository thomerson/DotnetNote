using System;
using Newtonsoft.Json;


//允许程序创建和控制任何类的对象，无需提前硬编码目标类

//Assembly：定义和加载程序集。

//Module：模块信息（如包含模块的程序集和模块中的类）。 

//ConstructorInfo：构造函数信息（如名称、参数、访问修饰符等）。

//MethodInfo：方法成员信息（如名称、返回类型、参数和访问修饰符等）。

//FieldInfo：字段成员信息（如名称、访问修饰符）。

//EventInfo：事件成员信息（如名称、事件处理程序的数据类型、自定义特性、声明类型以及事件的反射的类型）。

//PropertyInfo：属性成员信息（如名称、数据类型、声明类型，反射的类型和属性的只读或可写状态），并获取或设置属性值。

//ParameterInfo：参数成员信息（如参数名、数据类型以及参数在方法签名中的位置等）。

//CustomAttributeData：自定义特性信息。

namespace Dotnet.Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public static void Test()
        {
            Type type = typeof(TestClass);

            var obj = new TestClass();

            var name = type.Name;
            Console.WriteLine("name:{0}", name);

            //var methodinfos = type.GetMethods();
            var methodinfos = type.GetMethods(System.Reflection.BindingFlags.Public);
            foreach (var method in methodinfos)
            {
                var parms = method.GetParameters();
                foreach (var parm in parms)
                {
                    Console.WriteLine("parm.Name:{0}", parm.Name);
                    Console.WriteLine("parm.ParameterType:{0}", JsonConvert.SerializeObject(parm.ParameterType));
                }

                //通过反射执行函数
                if (parms.Length > 0)
                {
                    var result = method.Invoke(obj, new[] { string.Format("{0}", method.Name) });
                    Console.WriteLine("method.Invoke result :{0}", result);
                }
                else
                {
                    var result = method.Invoke(obj, null);
                    Console.WriteLine("method.Invoke result :{0}", result);
                }

            }

        }

        public static void InstanceTest()
        {
            #region Activator.CreateInstance(t)
            Type t = Type.GetType("System.Data.DataTable,System.Data,Version=1.0.3300.0,  Culture=neutral,  PublicKeyToken=b77a5c561934e089");

            var instance = Activator.CreateInstance(t) as System.Data.DataTable;

            #endregion

            //var tt = typeof(TestClass);
            //var obj = tt.GetConstructor();

            #region 根据构造器创建对象

            #endregion
        }
    }


    class TestClass
    {
        public string name { get; set; }

        public string SetName(string name)
        {
            this.name = name;
            Console.WriteLine("SetName : {0}", name);
            return name;
        }

        public void SetTestName(string name)
        {
            this.name = name;
        }


    }
}
