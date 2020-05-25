using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    static class MergeSort
    {
        public static int CountComps { get; set; } = 0;
        public static int CountMoves { get; set; } = 0;
        public static int[] SortUnsorted(int[] a, int lo, int hi)
        {
            if (hi <= lo)
                return a;
            int mid = lo + (hi - lo) / 2;
            SortUnsorted(a, lo, mid);
            SortUnsorted(a, mid + 1, hi);
            List<int> buf = new List<int>(a);
            buf.ToArray();

            for (int k = lo; k <= hi; k++)
                buf[k] = a[k];

            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {

                if (i > mid)
                {
                    CountMoves++;
                    a[k] = buf[j];
                    j++;
                }
                else if (j > hi)
                {
                    CountMoves++;
                    a[k] = buf[i];
                    i++;
                }
                else if (buf[j] < buf[i])
                {
                    CountComps++;
                    CountMoves++;
                    a[k] = buf[j];
                    j++;
                }
                else
                {
                    CountComps++;
                    CountMoves++;
                    a[k] = buf[i];
                    i++;
                }
            }
            return a;
        }
    }
}
