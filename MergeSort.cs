namespace GuruDev
{
    public class MergeSort
    {
        public static int[] Sort(int[] arr)
        {
            return Merge_Sort(arr);
        }

        static int[] Merge_Sort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;

            int n = arr.Length;
            int mid = n / 2;

            int[] l = new int[mid];
            for (int i = 0; i < mid; i++)
                l[i] = arr[i];

            int[] r = new int[arr.Length - mid];
            for (int i = 0; i < r.Length; i++)
                r[i] = arr[i + mid];
            l = Merge_Sort(l);
            r = Merge_Sort(r);

            return Merge(l, r);
        }
        static int[] Merge(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int i = 0;
            int l = 0;
            int r = 0;
            while (l < arr1.Length || r < arr2.Length)
            {
                if (l < arr1.Length && r < arr2.Length)
                {
                    if (arr1[l] > arr2[r])
                        arr[i++] = arr2[r++];
                    else
                        arr[i++] = arr1[l++];
                }
                else if (r < arr2.Length)
                    arr[i++] = arr2[r++];
                else if (l < arr1.Length)
                    arr[i++] = arr1[l++];
            }

            return arr;
        }
    }
}