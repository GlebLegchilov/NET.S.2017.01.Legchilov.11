﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Test
{
    class ComparerInt : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y) return 1;
            else if (x < y) return -1;
            else return 0;
        }
    }
}
