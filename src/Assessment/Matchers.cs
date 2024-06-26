﻿using System.Text.RegularExpressions;

namespace Assessment;

public static class Matchers
{
  public static bool HasMatchingBrackets(string val)
  {
    var sum = 0;

    foreach (var c in KeepOnlyBrackets())
    {
      sum += c == '<' ? 1 : -1;
      if (sum < 0)
        break;
    }

    return sum == 0;

    string KeepOnlyBrackets() => Regex.Replace(val, "[^<>]", "");
  }
}
