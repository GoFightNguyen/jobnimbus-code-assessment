namespace Assessment;

public static class Matchers
{
  public static bool HasMatchingBrackets(string val)
  {
    if (val.StartsWith(">")) return false;

    var numOfOpeningBrackets = val.Count(c => c == '<');
    var numOfClosingBrackets = val.Count(c => c == '>');
    return numOfOpeningBrackets == numOfClosingBrackets;
  }
}
