namespace Assessment;

public static class Matchers
{
  public static bool HasMatchingBrackets(string val)
  {
    return !val.StartsWith(">");
  }
}
