using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBraces
{
   public class Braces
   {
      public static string[] AllBracesClosed(string[] values)
      {
         string[] retArr = new string[values.Length];
         int retIdx = 0;
         foreach (string s in values)
         {
            Stack<char> stack = new Stack<char>();
            var answer = "YES";
            for (int i = 0; i < s.Length; i++)
            {
               char c1 = s[i];
               if (IsOpeningBrace(c1))
                  stack.Push(c1);
               else if (IsClosingBrace(c1))
               {
                  if (!stack.Any())
                  {
                     answer = "NO";
                     break;
                  }

                  char opBr = stack.Pop();
                  if (!MatchingBraces(opBr, c1))
                     answer = "NO";
               }
            }

            if (stack.Any())
               answer = "NO";
            retArr[retIdx++] = answer;
         }

         return retArr;
      }

      static bool IsOpeningBrace(char c)
      {
         if (c == '(' || c == '[' || c == '{')
            return true;
         return false;
      }

      static bool IsClosingBrace(char c)
      {
         if (c == ')' || c == ']' || c == '}')
            return true;
         return false;
      }

      static bool MatchingBraces(char c1, char c2)
      {
         if ((c1 == '(' && c2 == ')') ||
             (c1 == '[' && c2 == ']') ||
             (c1 == '{' && c2 == '}'))
            return true;

         return false;
      }
   }
}