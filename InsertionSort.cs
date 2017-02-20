
namespace GuruDev
{
    public class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        public static string Sort(string str)
        {           
            char[] arr=str.ToCharArray(); 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        char temp = arr[i];
                        arr[i]= arr[j];
                        arr[j]= temp;
                    }
                }
            }
            return new string(arr);
        }
    }
}
