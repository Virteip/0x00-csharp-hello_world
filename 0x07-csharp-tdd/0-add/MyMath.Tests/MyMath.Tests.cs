using NUnit.Framework;

namespace MyMath.Tests
{
	[TestFixture]
    public class Tests
    {
        [Test]
        public void FirstTestSum()
        {
			int result = MyMath.Operations.Add(6, 4);
            Assert.AreEqual(10, result);
        }
    }
}
