
namespace WinFormTest.Algorithm
{
    public class MergeSort
    {
        /// <summary>
        /// 归并排序数组
        /// </summary>
        /// <param name="arr"></param>
        public static int[] Sort(int[] arr)
        {
            return SortInner(arr);
        }

        private static int[] SortInner(int[] arr)
        {
            int p = 0;
            int r = arr.Length - 1;
            if (p >= r)
            {
                return new int[] { arr[p] };
            }
            int q = (p + r) >> 1;
            int[] a = SortInner(GetArr(arr, p, q));
            int[] b = SortInner(GetArr(arr, q + 1, r));
            return Merge(a, b);
        }

        private static int[] GetArr(int[] arr, int p, int r)
        {
            int[] ret = new int[r - p + 1];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = arr[p + i];
            }
            return ret;
        }

        private static int[] Merge(int[] a, int[] b)
        {
            int i = 0, j = 0, k = 0;
            int[] ret = new int[a.Length + b.Length];
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    ret[k++] = a[i++];
                }
                else
                {
                    ret[k++] = b[j++];
                }
            }

            if (i < a.Length)
            {
                while (i < a.Length)
                {
                    ret[k++] = a[i++];
                }
            }
            else if (j < b.Length)
            {
                while (j < b.Length)
                {
                    ret[k++] = b[j++];
                }
            }

            return ret;
        }
    }
}
