using System.Collections.Generic;
using System.Linq;

namespace AscendTest.Library
{
    public class SnapShot
    {
        private int[] _array;

        public SnapShot(List<int> data)
        {

            SnapShotList(data);
        }
        public void SnapShotList(List<int> data)
        {
            _array = new int[data.Count];
            data.CopyTo(_array, 0);
        }

        public IReadOnlyCollection<int> Restore()
        {
            return _array.ToList();
        }

    }
}