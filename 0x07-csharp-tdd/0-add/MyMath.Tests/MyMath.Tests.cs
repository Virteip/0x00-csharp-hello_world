using NUnit.Framework;

namespace MyMath.Tests
{
	///<summary>TEsts class</summary>
	[TestFixture]
    public class Tests
    {
			///<summary>Sum method</summary>
        [Test]
        public void FirstTestSum()
        {
			int result = MyMath.Operations.Add(6, 4);
            Assert.AreEqual(10, result);
        }
    }
}
