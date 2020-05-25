using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    static class NaturalMergeSort
    {
        public static int CountComps { get; set; } = 0;
        public static int CountMoves { get; set; } = 0;
        public static int[] Sort(int[] arr)
        {
            List<Elem> a1 = new List<Elem>();
            List<Elem> a2 = new List<Elem>();
            bool distributeOk = false;
            bool mergeOk = false;
            while (!distributeOk && !mergeOk)
            {
                distributeOk = Distribute(ref arr, ref a1, ref a2);
                if (distributeOk) { return arr; }

                arr = Merge(arr.Length, ref a1, ref a2, out mergeOk);
                if (mergeOk) { return arr; }
            }
            return arr;
        }

        private static int[] Merge(int len, ref List<Elem> a1, ref List<Elem> a2, out bool OK)
        {
            OK = false;
            int[] arr = new int[len];
            int k = 0;
            while (a1.Count != 0 || a2.Count != 0)
            {
                List<Elem> tmp1 = new List<Elem>() { };
                List<Elem> tmp2 = new List<Elem>() { };
                if (a1.Count != 0)
                {
                    tmp1 = GetLimit(ref a1);
                    if (tmp1.Count == len - 1)
                    {
                        OK = true;
                    }
                }
                if (a2.Count != 0)
                {
                    tmp2 = GetLimit(ref a2);
                    if (tmp2.Count == len - 1)
                    {
                        OK = true;
                    }
                }
                SubMerge(ref arr, ref tmp1, ref tmp2, ref k);
            }
            return arr;
        }

        private static List<Elem> GetLimit(ref List<Elem> a)
        {
            int i = 0;
            List<Elem> tmp = new List<Elem>() { };
            while (!a.ElementAt(i).EndOfSubSequence)
            {
                tmp.Add(a.ElementAt(i));
                a.RemoveAt(i);
            }
            if (a.Count != 0 && a.ElementAt(i).EndOfSubSequence)
            {
                tmp.Add(a.ElementAt(i));
                a.RemoveAt(i);
            }
            return tmp;
        }

        private static void SubMerge(ref int[] arr, ref List<Elem> a1, ref List<Elem> a2, ref int k)
        {
            int i = 0; int j = 0;
            while (a1.Count != 0 && a2.Count != 0)
            {
                if (a1.ElementAt(i).Value <= a2.ElementAt(j).Value)
                {
                    CountComps++;
                    CountMoves++;
                    arr[k] = a1.ElementAt(i).Value;
                    a1.RemoveAt(i);
                    k++;
                }
                else
                {
                    CountComps++;
                    CountMoves++;
                    arr[k] = a2.ElementAt(j).Value;
                    a2.RemoveAt(j);
                    k++;
                }
            }

            if (a1.Count == 0)
            {
                Copy(ref arr, ref a2, ref k);
            }

            if (a2.Count == 0)
            {
                Copy(ref arr, ref a1, ref k);
            }
        }

        private static void Copy(ref int[] arr, ref List<Elem> mass, ref int k)
        {
            for (int i = 0; i < mass.Count; k++)
            {
                arr[k] = mass.ElementAt(i).Value;
                mass.RemoveAt(i);
            }
        }


        private static bool Distribute(ref int[] mass, ref List<Elem> a1, ref List<Elem> a2)
        {
            List<int> arr = mass.ToList();
            int order = 1;
            int k = 1;
            while (arr.Count > 2)
            {
                if (arr.ElementAt(k - 1) > arr.ElementAt(k))
                {
                    CountComps++;
                    order = ChangeOrder(ref order, ref a1, ref a2, ref arr, k - 1);

                    if (arr.ElementAt(k - 1) > arr.ElementAt(k))
                    {
                        CountComps++;
                        order = ChangeOrder(ref order, ref a1, ref a2, ref arr, k - 1);
                    }
                }

                if (order == 1)
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(k - 1));
                    a1.Add(el);
                }
                else
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(k - 1));
                    a2.Add(el);
                }
                arr.RemoveAt(k - 1);
            }

            bool ok = false;
            if (arr.Count == 2)
            {
                if (arr.ElementAt(0) > arr.ElementAt(1))
                {
                    CountComps++;
                    order = ChangeOrder(ref order, ref a1, ref a2, ref arr, 0);
                    ok = true;
                }

                if (order == 1)
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(0));
                    a1.Add(el);
                }
                else
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(0));
                    a2.Add(el);
                }
                arr.RemoveAt(0);
            }

            if (!ok && arr.Count != 0)
            {
                if (order == 1)
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(0));
                    a1.Add(el);
                }
                else
                {
                    CountMoves++;
                    Elem el = new Elem(arr.ElementAt(0));
                    a2.Add(el);
                }
            }

            if (a1.Count != 0)
            {
                a1.Last().EndOfSubSequence = true;
            }

            if (a2.Count != 0)
            {
                a2.Last().EndOfSubSequence = true;
            }

            if (a1.Count == 0)
            {
                return true;
            }

            if (a2.Count == 0)
            {
                return true;
            }
            return false;
        }

        private static int ChangeOrder(ref int order, ref List<Elem> a1, ref List<Elem> a2, ref List<int> arr, int k)
        {
            if (order == 1)
            {
                Elem el = new Elem(arr.ElementAt(k));
                el.EndOfSubSequence = true;
                a1.Add(el);
                CountMoves++;
                arr.RemoveAt(k);
                return 2;
            }
            else
            {
                Elem el = new Elem(arr.ElementAt(k));
                el.EndOfSubSequence = true;
                a2.Add(el);
                CountMoves++;
                arr.RemoveAt(k);
                return 1;
            }
        }
    }
}

