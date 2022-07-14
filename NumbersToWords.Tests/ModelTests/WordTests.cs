using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;
using System; 

namespace NumbersToWords.Tests
{
  [TestClass]
  public class WordTests
  {
    // Test methods go here
    [TestMethod]
    public void IsWord_ReturnsInputWordToString_True()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string test = "test";
      Word newWord = new Word(test);
      Assert.AreEqual(true, newWord.IsWord());
    }

    [TestMethod]
    public void IsWord_ReturnsInputWordToString_False()
    {
      string test = "";
      Word newWord = new Word(test);
      Assert.AreEqual(false, newWord.IsWord());
    }

    [TestMethod]
    public void SetInputArray_ReturnsInputWordToArray_Word()
    {
      string test = "test";
      char[] testArray = {'t', 'e', 's', 't'};
      Word newWord = new Word(test);
      newWord.SetInputArray();
      for (int i = 0; i < test.Length; i ++) //compares inside each
      {
      Assert.AreEqual(testArray[i], newWord.InputArray[i]);
      }
    }

    [TestMethod]
    public void AddScore_ReturnsScoreBasedOnLetter_Int()
    {
      string test = "test";
      Word newWord = new Word(test);
      newWord.SetInputArray();
      newWord.AddScore();
      Assert.AreEqual(4, newWord.WordScore);
    }

    [TestMethod]
    public void AddScore_ReturnsLargerScoreBasedOnLetter_Int()
    {
      string test = "Oxyphenbutazone";
      Word newWord = new Word(test);
      newWord.SetInputArray();
      newWord.AddScore();
      Assert.AreEqual(41, newWord.WordScore);
    }
  }
}