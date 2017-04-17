using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2Test
{
    [TestFixture]
    public class BinarySearcherTest
    {
        [TestCase( new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = 2)]
        public int? BinarySearch_PositivTestInt(int[] array, int element)
        {
            BinarySearcher<int> binarySearcher = new BinarySearcher<int>(new ComparerInt());
            return binarySearcher.BinarySearch(array, element);
        }

        [TestCase(new string[] {"", " ", "  ", "   ", "    "}, "  ", ExpectedResult = 2)]
        public int? BinarySearch_PositivTestString(string[] array, string element)
        {
            BinarySearcher<string> binarySearcher = new BinarySearcher<string>(new ComparerString());
            return binarySearcher.BinarySearch(array, element);
        }
    }
}
