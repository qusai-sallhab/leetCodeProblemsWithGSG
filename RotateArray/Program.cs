using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int []arr = new int[] { 1, 2, 3, 4, 5 };
            Rotate1(arr,2);

            foreach(int num in arr)
            Console.Write(num+",");
        }

            
        public static void Rotate1(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n; 

            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = temp[i];
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;

            Reverse(nums, 0, n - 1);   
            Reverse(nums, 0, k - 1);  
            Reverse(nums, k, n - 1); 
        }

        public static void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                (nums[left], nums[right]) = (nums[right], nums[left]); 
                left++;
                right--;
            }
        }




    }






    //public void Rotate(int[] nums, int k)
    //{
    //    int temp;
    //    int length = nums.Length - 1;
    //    k %= (length + 1);
    //    for (int i = 0; i < k; i++)
    //    {
    //        temp = nums[length];
    //
    //      for (int j = length; j > 0; j--)
    //        {
    //            nums[j] = nums[j - 1];
    //        }
    //        nums[0] = temp;
    //    }
    //}

}
