using NUnit.Framework;

namespace Text.Tests
{
    ///<summary>Returns the number of words in the string</summary>
    public class Tests
    {
       ///<summary>Returns the number of words in the string</summary>
       [Test]
       public void Test1()
       {
           int result = Text.Str.CamelCase("holbertonSchool");
           Assert.AreEqual(2, result);
       }
    }
}
