using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
  ///<summary>String class</summary>
    public class Str
    {
      ///<summary>Palindrome method</summary>
		public static bool IsPalindrome(string s)
		{
        string r;
        s = Regex.Replace(s, "[^A-Za-z]", "");
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        s = s.ToLower();
        r = new string(array).ToLower();
        bool result = s == r;

        return (result);
		}
    }
}
