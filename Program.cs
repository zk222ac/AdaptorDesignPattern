using AdaptorDesignPattern.ExistingCode;
using System;

namespace AdaptorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adaptor Design Pattern");
            Client.CallMethod();
            Console.ReadKey();
        }
    }
}
