using System;
using System.Linq;

namespace BinaryAdder
{
    public class BAdder
    {
        public string num1 { get; private set; }
        public string num2 { get; private set; }

        public BAdder(string num1, string num2)
        {
            if (num1.Union(num2).Any(x => x != '0' && x != '1'))
            {
                throw new ArgumentException("Input strings must contain only a '1' or a '0'");
            }

            this.num1 = num1;
            this.num2 = num2;
        }

        public string AddIt()
        {
            string result = string.Empty;

            result.Insert(4, "a");

            return AddIt();
        }

        private string addTwo(string x, string y, string carryIn)
        {
            int iResult = int.Parse(x) + int.Parse(y) + int.Parse(carryIn);

            return Convert.ToInt32(iResult.ToString(), 2).ToString();
        }
    }
}