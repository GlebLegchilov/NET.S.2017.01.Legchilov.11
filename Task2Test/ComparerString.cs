using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Test
{
    class ComparerString : IComparer<String>
    {
        public int Compare(string x, string y)
        {
            if (x == null && y == null) return 0;
            else if (x == null) return -1;
            else if (y == null) return 1;
            else return x.CompareTo(y);
        }
    }
}
