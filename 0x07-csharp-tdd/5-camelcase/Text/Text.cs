
using System;

namespace Text
{
 ///<summary>Str class</summary>
 public class Str
 {
   ///<summary>Camel case counter</summary>
   public static int CamelCase(string s)
   {
      int c = 1;

      if (s == null || s.Length == 0){return (0);}

      foreach (char charac in s)
      {
          if (Char.IsUpper(charac)){
              c++;} }
      return c; }
} }
