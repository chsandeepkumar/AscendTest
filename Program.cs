using System;
using System.Collections.Generic;
using AscendTest.Library;

namespace AscendTest.ReadOnlyCollection
{
    class Program
    {
        private static void Main()
        {
            var list = new List<int> { 1, 2, 3 };

            var sp = new SnapShot(list);

            list.Add(4);

            var restoreList = sp.Restore();
            //restoreList is IReadOnlyCollection, so we can not add to the ReadOnlyCollection

            Console.WriteLine(string.Join(",", restoreList));
            Console.ReadLine();
        }
    }
}
