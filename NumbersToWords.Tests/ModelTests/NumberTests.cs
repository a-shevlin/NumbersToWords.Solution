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
    public void SetInputArray_ReturnsInputWordToArray_Word()
    {
      string test = "1234";
      int[] testArray = {1, 2, 3, 4};
      Number newNumber = new Number(test);
      newNumber.SetInputArray();
      for (int i = 0; i < test.Length; i ++) //compares inside each
      {
        Assert.AreEqual(testArray[i], newNumber.InputArray[i]);
      }
    }
    
    // [TestMethod]
    // public void InputArray_ReturnsInputNumberToArray_Array()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   int num = 4;
    //   string[] numArray = { "one", "two", "three", "four" };
    //   Number newNumber = new Number(num);
    //   newNumber.SetInputArray();
    //   for(int i = 0; i < num.Lengths; i ++)
    //   {
    //     Assert.AreEqual(numArray[i], newNumber.InputArray[i]);
    //   }
    // }
  }
}