using NUnit.Framework;

namespace Text.Tests
{
	///<summary>Operations class</summary>
	[TestFixture]
    public class Tests
    {

		///<summary>Operations class</summary>
    [Test]
    public void TestWordTrue()
    {
      string str = "arepera";

			bool result = Str.IsPalindrome(str);

			Assert.IsTrue(result);
    }

		///<summary>Operations class</summary>
		[Test]
		public void TestWordFalse()
		{
			string str = "sergio";

			bool result = Str.IsPalindrome(str);

			Assert.IsFalse(result);
		}

		///<summary>Operations class</summary>
		[Test]
		public void TestSentenceTrue()
		{
			string str = "A man, a plan, a canal: Panama.";

			bool result = Str.IsPalindrome(str);

			Assert.IsTrue(result);
		}

		///<summary>Operations class</summary>
		[Test]
		public void TestSentenceFalse()
		{
			string str = "The man, the myth, the legend";

			bool result = Str.IsPalindrome(str);

			Assert.IsFalse(result);
		}



    }
}
