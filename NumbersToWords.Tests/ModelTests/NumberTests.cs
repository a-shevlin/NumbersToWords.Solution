using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;
using System.Collections.Generic;
using System; 

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTests
  {
    // Test methods go here
    [TestMethod]
    public void SetInputArray_ReturnsInputStringToIntArray_Array()
    {
      string test = "1234";
      int[] testArray = {1, 2, 3, 4};
      Number newNumber = new Number(test);
      newNumber.SetInputArray();
      Console.WriteLine(newNumber.InputArray[1]);
      CollectionAssert.AreEqual(testArray, newNumber.InputArray);
    }
    
    [TestMethod]
    public void BasicConvert_ReturnsInputArrayAsWords_Array()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string num = "1234";
      string[] numArray = { "one", "two", "three", "four" };
      Number newNumber = new Number(num);
      newNumber.SetInputArray();
      newNumber.BasicConvert();
      Console.WriteLine(newNumber.OutputArray[0]);
      CollectionAssert.AreEqual(numArray, newNumber.OutputArray);
    }
  }
}