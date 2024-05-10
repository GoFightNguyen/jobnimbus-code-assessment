using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment;

namespace AssessmentTests;

[TestClass]
public class MatchersTest
{
  [TestMethod]
  public void HasMatchingBrackets_ReturnsTrue_WhenEmptyString()
  {
    Assert.IsTrue(Matchers.HasMatchingBrackets(""));
  }

  [TestMethod]
  public void HasMatchingBrackets_ReturnsTrue_WhenThereIsOnlyAnOpeningBracketFollowedByAClosingBracket()
  {
    Assert.IsTrue(Matchers.HasMatchingBrackets("<>"));
  }
}