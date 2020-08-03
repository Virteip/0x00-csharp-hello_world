using NUnit.Framework;

namespace Text.Tests
{
   ///<summary>Tests class</summary>
    public class Tests
    {
      ///<summary>return index</summary>
      [Test]
      public void TestIndex()
      {
        string s = "HHEELLOOWOORRLLDD";
        int result = Str.UniqueChar(s);
        Assert.AreEqual(2, result);
      }
    }
}
