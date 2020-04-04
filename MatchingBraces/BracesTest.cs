using NUnit.Framework;

namespace MatchingBraces
{
   [TestFixture]
   public class BracesTest
   {
      [Test]
      public void Test_Simple()
      {
         string[] bracesToTest = new[] {"()", "[]", "{}", "(]", "(", "{]"};
         string[] bracesResult = new[] {"YES", "YES", "YES", "NO", "NO", "NO"};

         var retVal = Braces.AllBracesClosed(bracesToTest);
         
         Assert.AreEqual(retVal, bracesResult);
      }

      [Test]
      public void Test_Contents()
      {
         string[] bracesToTest = new[] {"(asdasdasdasd)", "[()]", "{[]([{aas}])}", "(])", "())", "{]}"};
         string[] bracesResult = new[] {"YES", "YES", "YES", "NO", "NO", "NO"};

         var retVal = Braces.AllBracesClosed(bracesToTest);
         
         Assert.AreEqual(retVal, bracesResult);
      }
   }
}