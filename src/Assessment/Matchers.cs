namespace Assessment;

public static class Matchers
{
  public static bool HasMatchingBrackets(string val)
  {
    var sum = 0;

    foreach (var c in val)
    {
      if (c == '<')
        sum++;
      else if (c == '>')
        sum--;

      if (sum < 0)
        return false;
    }

    return sum == 0;
  }
}
