using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello World!");
            int[] testArray = PlusOne(new int[] { 9,9, 9,9,9,9 ,1});
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.Write(testArray[i]+" ");
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            int[] answerArray;
            int originalLength = digits.Length;
            int newLength;


            newLength = originalLength + 1;
            for (int i = 0; i < originalLength; i++)
            {
                if (digits[i] != 9) { newLength--; break; }
            }
            answerArray = new int[newLength];


            if (newLength != originalLength)
            {
                answerArray[0] = 1;
                for (int i = 1; i < newLength; i++)
                {
                    answerArray[i] = 0;
                }
            }
            else if (digits[originalLength - 1] != 9)
            {
                answerArray[newLength - 1] = ++digits[originalLength - 1];
                for (int i = 0; i < newLength-1; i++)
                {
                    answerArray[i] = digits[i];
                }
            }
            else
            {
                bool carryFlag = true;
                for (int i = 0; i < newLength ; i++)
                {
                    if (carryFlag)
                    {
                        if (digits[originalLength - 1 - i] == 9)
                            answerArray[newLength - 1 - i] = 0;
                        else
                        { answerArray[newLength - 1 - i] = digits[originalLength - 1 - i] + 1; carryFlag = false; }
                    }
                    else
                    {
                        answerArray[newLength - 1 - i] = digits[originalLength - 1 - i];
                    }
                }
            }

               

            return answerArray;
        }
    }
}
