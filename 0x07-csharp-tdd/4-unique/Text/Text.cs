using System;


namespace Text
{
    ///<summary>Str class</summary>
    public class Str
    {
      ///<summary>Return unique item's index</summary>
      public static int UniqueChar(string s)
      {
        char point = s[0];
        for (int i = 0; i < s.Length; i++)
        {
          if (s[i] != point){
            return i;}

          point = s[i]; }
        return -1; }

      }
}
