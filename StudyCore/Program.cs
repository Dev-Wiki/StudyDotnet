using System;
using System.Text.Json.Serialization;

namespace StudyCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(DateTime.Now.ToFileTimeUtc());

            if (a > 9)
            {
                goto Test;
            }
            Console.WriteLine("if ...");

            Test:
            Console.WriteLine("Test");

            Console.ReadKey();
        }
    }

    class Person
    {
        public string name;
    }
}
