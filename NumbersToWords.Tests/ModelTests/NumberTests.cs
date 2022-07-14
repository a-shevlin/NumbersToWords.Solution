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
      CollectionAssert.AreEqual(numArray, newNumber.OutputArray);
    }
    
    [TestMethod]
    public void TensConvert_ReturnsTensInputAsTenty_String()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string num = "10";
      string ten = "tenty";
      Number newNumber = new Number(num);
      newNumber.SetInputArray();
      newNumber.TensConvert(0);
      Console.WriteLine(newNumber.OutputArray[0]);
      Assert.AreEqual(ten, newNumber.OutputArray[0]);
    }

    [TestMethod]
    public void TensConvert_ReturnsTensInputAsWordSixty_string()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string num = "60";
      string ten = "sixty";
      Number newNumber = new Number(num);
      newNumber.SetInputArray();
      newNumber.TensConvert(0);
      Console.WriteLine(newNumber.OutputArray[0]);
      Assert.AreEqual(ten, newNumber.OutputArray[0]);
    }
  }
}