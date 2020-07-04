using System.Collections.Generic;
using System.Linq;
using AscendTest.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AscentTest.Library.Tests
{
    [TestClass]
    public class SnapshotTest
    {
        [TestMethod]
        public void Test_Snapshot_Restore_Returns_Without_ModifiedList()
        {
            var list = new List<int> { 1, 2, 3 };

            var sp = new SnapShot(list);

            list.Add(4); 

            var restoreList = sp.Restore();

            Assert.IsNotNull(restoreList);
            Assert.AreNotEqual(list.Count, restoreList.Count);
        }
        [TestMethod]
        public void Test_Snapshot_Restore_Returns_Not_ModifiedList()
        {
            List<int> list = new List<int> { 1, 2, 3 };

            SnapShot sp = new SnapShot(list);

            list[0] = 10;

            var restoreList = sp.Restore();

            Assert.IsNotNull(restoreList);
            Assert.AreNotEqual(list[0], restoreList.ToList()[0]);
        }
    }
}
