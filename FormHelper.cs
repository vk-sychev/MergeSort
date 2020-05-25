using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    static class FormHelper
    {
        public static List<int> InputData(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++ )
            {
                arr[i] = random.Next(0, 100);
            }
            return arr.ToList();
        }

        public static void MatrToGRid(DataGridView dg, List<int> mass, int n)
        {
            for (int i = 0; i < n; i++)
            {
                dg.Rows[0].Cells[i].Value = mass[i];
            }
        }

        public static List<int> OutputResultMergeSort(int[] arr)
        {
            return MergeSort.SortUnsorted(arr, 0, arr.Length - 1).ToList();
        }

        public static List<int> OutputResultNaturalMergeSort(int[] arr)
        {
            return NaturalMergeSort.Sort(arr).ToList();
        }

  
    }
}
