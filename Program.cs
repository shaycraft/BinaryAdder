using System;

namespace BinaryAdder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BAdder adder = new BAdder("101", "11");

            Console.WriteLine(adder.AddIt());
        }
    }
}
