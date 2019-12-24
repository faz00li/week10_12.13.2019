using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
  [TestClass]
  public class LeapYearTest
  {
    LeapYear testLeapYear = new LeapYear();

    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_True()
    {
      // LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }

    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_False()
    {
      // LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }

    [TestMethod]
    public void IsLearYear_MultiplesOfFourHundred_True()
    {
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }

  }
}
