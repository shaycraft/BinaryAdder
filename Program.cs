using System;

namespace BinaryAdder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bstring b1 = new bstring("1011");

            Console.WriteLine(b1);
            // TODO:  make these unit tests:
            b1[3] = '0';
            Console.WriteLine(b1);
            Console.WriteLine($"b1[1] = {b1[1]}");
            Console.WriteLine($"b1[2] = {b1[2]}");
            Console.WriteLine($"b1[1000] = {b1[1000]}");

            Console.WriteLine("DEBUG: Inserting at position 10: 1");
            b1[10] = '1';
            Console.WriteLine(b1);

            //BAdder adder = new BAdder("101", "11");

            //Console.WriteLine(adder.AddIt());
        }
    }
}
