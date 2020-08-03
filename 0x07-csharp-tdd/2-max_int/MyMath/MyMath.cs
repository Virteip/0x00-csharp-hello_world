using System;
using System.Collections.Generic;

namespace MyMath
{
  ///<summary>Operations class</summary>
    public class Operations
    {
      ///<summary>Max int</summary>
		public static int Max(List<int> nums)
		{
			int max = 0;
			int lengthLast = nums.Count - 1;
            if (nums.Count > 0)
            {
                nums.Sort();
                max = nums[lengthLast];
            }
            return (max);
		}
    }
}
