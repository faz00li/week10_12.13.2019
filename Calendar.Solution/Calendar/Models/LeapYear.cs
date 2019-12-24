


using System;
using System.Collections.Generic

namespace Calendar
{



  public class LeapYear
  {
    Dictionary<string, string> dictionaryName = new Dictionary<string, string>() {};

      public bool IsLeapYear(int year)
      {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0) {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }
  }
}
