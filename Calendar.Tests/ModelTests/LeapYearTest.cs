using Microsoft.VisualStudio.TestTools.UnitTesting; // This line imports the functionality from the project (we installed MSTest into project with $ dotnet restore command) into this specific testing file.
using Calendar; //imports the Calendar namespace from the Calendar project for use in our tests.

namespace Calendar.Tests
{
  [TestClass] //tells MSTest that the following class contains tests to be run.
  public class LeapYearTest
  {
    [TestMethod]//tells the compiler that the following code block is an individual test that should be run by MSTest
    public void IsLeapYear_NumberDivisibleByFour_True() //public = should be accessible to the tools to run our tests. void = because they don't explicitly return anything.
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012)); //AreEqual checks whether true and testLeapYear.IsLeapYear(2012) are equal. The first argument is what we expect the result of the test to be and the second is the expression to be evaluated.
    }
    [TestMethod]
    public void IsLeapYear_NumberDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
    Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
