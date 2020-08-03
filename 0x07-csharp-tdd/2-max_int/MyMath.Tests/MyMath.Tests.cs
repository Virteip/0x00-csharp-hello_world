using NUnit.Framework;
using System.Collections.Generic;


namespace MyMath.Tests
{
	///<summary>Operations class</summary>
	[TestFixture]
    public class Tests
    {
			///<summary>Operations class</summary>
        [Test]
        public void TestMaxInt()
        {
            List<int> nums = new List<int>() {1,2,3,4,5,6,7,8,98,100,-1,0};

			int result = MyMath.Operations.Max(nums);

			Assert.AreEqual(100, result);
        }

		[Test]
        public void Max_List()
        {
            List<int> nums = new List<int>() {};
			int result = MyMath.Operations.Max(nums);
			Assert.AreEqual(0, result);
        }
    }
}
