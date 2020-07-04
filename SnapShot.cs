using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class SnapShot
    {
        private IReadOnlyCollection<int> readOnlyCollectionData;

        private int[] _array;
        //private IList<int> readonlylist;

        public SnapShot(List<int> data)
        {
            SnapShotList(data);
        }

        public void SnapShotList(List<int> data)
        {
            _array = new int[data.Count];
            data.CopyTo(_array,0);
        }

        public IReadOnlyCollection<int> Restore()
        {
            return _array.ToList();
        }

    }
}