using System;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[]{1,1,2,2,1,3,1,3,3,3,3,3,3}));
        }

        public static int MajorityElement(int[] nums)
        {
            int majorityElement=0;
            int counter = 0;
            int temp;
            bool foundFlag=false;

            for (int i = 0; i < nums.Length; i++)
            {
                counter = 0;
                temp = nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (temp == nums[j]) counter++;
                    if (counter > nums.Length / 2.0f) { majorityElement = temp; foundFlag = true; break; }
                }

                if (foundFlag) break;
            }


            return majorityElement;

        }
    }
}
