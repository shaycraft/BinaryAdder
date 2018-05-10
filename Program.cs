using System;

namespace BinaryAdder
{
    public class Program
    {
        public struct bnode
        {
            public char r;
            public char carry;
        }

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

            bstring a = new bstring("101");
            bstring b = new bstring("11");

            bstring result = add_bstring(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, result);

            Console.WriteLine("11 + 11 = " + add_bstring(new bstring("11"), new bstring("11")));
            Console.WriteLine("111 + 110 = " + add_bstring(new bstring("111"), new bstring("110")));

        }

        private static bstring add_bstring(bstring a, bstring b)
        {
            int n = (a.length > b.length) ? a.length : b.length;
            bstring result = new bstring(n + 1);
            char carry = '0';
            for (int i = 0; i < n; i++)
            {
                bnode badd_result = badd(a[i], b[i], carry);
                result[i] = badd_result.r;
                carry = badd_result.carry;
            }
            result[n] = carry;

            return result;
        }

        private static bnode badd(char c1, char c2, char carry)
        {
            int z = int.Parse(c1.ToString()) + int.Parse(c2.ToString()) + int.Parse(carry.ToString());
            bstring bstring = new bstring(Convert.ToString(z, 2).ToString());

            bnode result;
            result.r = bstring[1];
            result.carry = bstring[0];

            return result;
        }
    }
}
