
namespace WinFormTest.Algorithm
{
    public class QuickSort
    {
        /// <summary>
        /// 快排数组
        /// </summary>
        /// <param name="arr"></param>
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int p, int r)
        {
            if (p >= r)
            {
                return;
            }
            int q = Partition(arr, p, r);
            Sort(arr, p, q - 1);
            Sort(arr, q + 1, r);
        }

        private static int Partition(int[] arr, int p, int r)
        {
            int x = arr[r];
            int j = p;

            for (int i = p; i < r; i++)
            {
                if (arr[i] < x)
                {
                    Swap(arr, i, j);
                    j++;
                }
            }
            Swap(arr, r, j);

            return j;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
