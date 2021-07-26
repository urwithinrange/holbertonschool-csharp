using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Operations class for determining the highest number in a list</summary>
    public class Operations
    {
        /// <summary>Gets the max number in a list</summary>
        public static int Max(List<int> nums)
        {
            int temp;
            if (nums.Count == 0)
                temp = 0;
            else
                temp = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > temp)
                    temp = nums[i];
            }
            return temp;
        }
    }
}
