using System;

namespace tsback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Hello
    {
        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
    }
}
