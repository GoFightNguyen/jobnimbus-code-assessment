using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment;

namespace AssessmentTests;

[TestClass]
public class MatchersTest
{
  [TestMethod]
  [DataRow("")]
  [DataRow("abc")]
  [DataRow("abc def")]
  public void HasMatchingBrackets_ReturnsTrue_WhenThereAreNoBrackets(string val)
  {
    Assert.IsTrue(Matchers.HasMatchingBrackets(val));
  }

  [TestMethod]
  [DataRow("<>")]
  [DataRow("<abc>")]
  [DataRow("ab<c>")]
  [DataRow("a<b>c")]
  [DataRow("<>abc")]
  [DataRow("abc<>")]
  public void HasMatchingBrackets_ReturnsTrue_WhenThereIsOneBracketPair(string val)
  {
    Assert.IsTrue(Matchers.HasMatchingBrackets(val));
  }

  [TestMethod]
  public void HasMatchingBrackets_ReturnsFalse_WhenThereIsOnlyAClosingBracketFollowedByAnOpeningBracket()
  {
    Assert.IsFalse(Matchers.HasMatchingBrackets("><"));
  }

  [TestMethod]
  public void HasMatchingBrackets_ReturnsFalse_WhenThereIsNotACorrespondingClosingBracketForEveryOpenBracket()
  {
    Assert.IsFalse(Matchers.HasMatchingBrackets("<<>"));
  }
}