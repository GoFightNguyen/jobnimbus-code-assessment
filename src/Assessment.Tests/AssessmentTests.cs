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
  [DataRow("<<>>")]
  [DataRow("<><>")]
  [DataRow("<>abc<>")]
  [DataRow("<abc<def>>")]
  public void HasMatchingBrackets_ReturnsTrue_WhenAllBracketPairsAreProperlyOpenedAndClosed(string val)
  {
    Assert.IsTrue(Matchers.HasMatchingBrackets(val));
  }

  [TestMethod]
  [DataRow("><")]
  [DataRow("a><")]
  public void HasMatchingBrackets_ReturnsFalse_WhenBracketsAreOutOfOrder(string val)
  {
    Assert.IsFalse(Matchers.HasMatchingBrackets(val));
  }

  [TestMethod]
  [DataRow("<")]
  [DataRow("<<>")]
  [DataRow("<>>")]
  [DataRow("<a>b>")]
  [DataRow("b>")]
  public void HasMatchingBrackets_ReturnsFalse_WhenThereIsNotACorrespondingClosingBracketForEveryOpenBracket(string val)
  {
    Assert.IsFalse(Matchers.HasMatchingBrackets(val));
  }
}