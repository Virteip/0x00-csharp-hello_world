using NUnit.Framework;

namespace MyMath.Tests
{
	///<summary>Tests class</summary>
	[TestFixture]
    public class Tests
    {
				///<summary>Operations class</summary>
        [Test]
        public void TestDivision()
        {
           	int[,] matrix = new int[2, 2] { { 50, 15 }, { 20, 45 } };

			int num = 5;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 10, 3 }, { 4, 9 } }, output);
        }

		[Test]
		public void TestDivisionNull()
		{
			int[,] result = Matrix.Divide(null, 55);
			Assert.AreEqual(null, result);
		}

		[Test]
		public void TestDivisionZero()
		{
           	int[,] matrix = new int[2, 2] { { 50, 15 }, { 20, 45 } };

			int[,] result = Matrix.Divide(matrix, 0);

			Assert.AreEqual(null, result);
		}
    }
}
