using System;
using System.Linq;
using System.Collections.Generic;

namespace Dotnet.Linq
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
        }

        static void Sort()
        {
            var words = new[] { "the", "quick", "brown", "fox", "jumps" };
            var query = from word in words
                        orderby word.Length
                        select word;

            foreach (var word in query)
            {
                Console.WriteLine(word);
            }

        }
    }

    class User
    {
        int id { get; set; }
        string name { get; set; }

    }
}
