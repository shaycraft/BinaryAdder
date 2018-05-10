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
                if (index >= _vals.Length)
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
                    Array.Resize(ref _vals, (int)Math.Ceiling(index + index * 0.3));
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

        public bstring(int size)
        {
            _vals = new char[size];
            for (int i = 0; i < _vals.Length; i++)
            {
                _vals[i] = '0';
            }
        }

        public int length
        {
            get
            {
                return _vals.Length;
            }
        }

        override public string ToString()
        {
            var reversed = _vals.Reverse();
            int startIdx = 0;
            // skip leading zero'd
            while (reversed.ElementAt(startIdx) != '1') ++startIdx;

            return string.Join(string.Empty, reversed.Skip(startIdx));
            //return string.Join(string.Empty, _vals.Reverse());
        }
    }
}