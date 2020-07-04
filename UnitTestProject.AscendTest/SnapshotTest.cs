using System.Collections.Generic;
using System.Linq;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject.AscendTest
{
    [TestClass]
    public class SnapshotTest
    {
        [TestMethod]
        public void Test_Snapshot_Restore_Returns_Without_ModifiedList()
        {
            List<int> list = new List<int> {1, 2, 3};

            SnapShot sp = new SnapShot(list);

            list.Add(4); //though we added 4, the restoreList can be displayed , since took copy at constructor level

            var resotreList = sp.Restore();
            Assert.AreNotEqual(list.Count,resotreList.Count);
        }
        [TestMethod]
        public void Test_Snapshot_Restore_Returns_Not_ModifiedList()
        {
            List<int> list = new List<int> { 1, 2, 3 };

            SnapShot sp = new SnapShot(list);

            list[0] = 10;

            var resotreList = sp.Restore();
            Assert.AreNotEqual(list[0], resotreList.ToList()[0]);
        }
    }
}
