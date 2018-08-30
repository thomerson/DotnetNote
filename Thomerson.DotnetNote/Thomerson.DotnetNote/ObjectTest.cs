using System;
using System.Collections.Generic;
using System.Text;

namespace Thomerson.DotnetNote
{
    class ObjectTest
    {
        public void Test()
        {
            var i = 10;
            intTest(i);
            Console.WriteLine(i);

            var user = new User() { age = 10 };
            Console.WriteLine("WithoutRef");
            ClassTest(user);
            Console.WriteLine(user.age);
            Console.WriteLine((user is User).ToString());


            var user2 = new User() { age = 10 };
            Console.WriteLine("WithRef");
            ClassTestWithRef(ref user2);
            Console.WriteLine(user2.age);
            Console.WriteLine((user2 is User).ToString());

        }

        public void TestwithRef()
        {

            var user = new User() { age = 10 };
            ClassTestWithRef(ref user);
            Console.WriteLine(user.age);

        }

        public void Test2()
        {
            Thing x = new Animal();

            Switcharoo(ref x);
            Console.WriteLine("WithRef");
            Console.WriteLine(
              "x is Animal    :   "
              + (x is Animal).ToString());

            Console.WriteLine(
                "x is Vegetable :   "
                + (x is Vegetable).ToString());
        }

        public void Test3()
        {
            Thing x = new Animal();

            SwitcharooWithoutRef(x);
            Console.WriteLine("WithoutRef");
            Console.WriteLine(
              "x is Animal    :   "
              + (x is Animal).ToString());

            Console.WriteLine(
                "x is Vegetable :   "
                + (x is Vegetable).ToString());
        }

        public void Switcharoo(ref Thing pValue)
        {
            pValue = new Vegetable();
        }

        public void SwitcharooWithoutRef(Thing pValue)
        {
            pValue = new Vegetable();
        }

        public void intTest(int a)
        {
            a = a + 5;
        }

        public void ClassTest(User user)
        {
            user.age = user.age + 5;
        }

        public void ClassTestWithRef(ref User user)
        {
            user.age = user.age + 5;
        }

    }

    public class User
    {
        public int age { get; set; }
    }


    public class Thing
    {
    }

    public class Animal : Thing
    {
        public int Weight;
    }

    public class Vegetable : Thing
    {
        public int Length;
    }

}
