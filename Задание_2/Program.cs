using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2,7,11,15};
            int target = 9;
            int j = 0;
            int i = 0;

            int y = 0; // Выход из цикла

            for(j = 0; j<nums.Length && y == 0;j++)
            {
                
                for(i = j + 1;i<nums.Length;i++)
                {
                    if(nums[i]+nums[j] == target)
                    {
                        y = 1;
                        break;
                    }
                }

                
            }
            Console.WriteLine("[" + i + "],[" + (j - 1) + "]");

        }
    }
}
