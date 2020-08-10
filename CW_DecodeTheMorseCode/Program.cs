using System;

namespace CW_DecodeTheMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.Decode("   .   ."));
            Console.ReadLine();
        }
    }
}
