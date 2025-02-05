using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(string.Join(",", TwoSum(new int[] { 3,2,4}, 6)));
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            int[] resultArray=new int[2];
            int firstNumIndex=0;
            int secondNumIndex=0;
            bool flag = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i) continue;
                    if (nums[i] + nums[j] == target) { firstNumIndex = i;secondNumIndex = j; flag = true;break; }
                }

                if (flag) break;
            }

            resultArray[0] = firstNumIndex;
            resultArray[1] = secondNumIndex;
            return resultArray;
        }


        
    }
}
