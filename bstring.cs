using System;
using System.Linq;

namespace BinaryAdder
{
    public class bstring
    {
        private char[] _vals;

        // note that index is the offset from the end, not a zero-based index
        public char this[int index]
        {
            get
            {
                if (index > _vals.Length)
                {
                    return '0';
                }
                else
                {
                    return _vals[index];
                }
            }

            set
            {
                if (index > _vals.Length)
                {
                    int oldLength = _vals.Length;
                    Array.Resize(ref _vals, index + 1);
                    for (int i = oldLength; i < index; i++)
                    {
                        _vals[i] = '0';
                    }
                }
                _vals[index] = value;
            }
        }

        public bstring(string s)
        {
            if (s.Any(x => x != '0' && x != '1'))
            {
                throw new ArgumentException("String value must be binary (only a '1' or a '0'");
            }

            // store in reverse order
            _vals = s.Reverse().ToArray();
        }

        override public string ToString()
        {
            return string.Join(string.Empty, _vals.Reverse());
        }
    }
}