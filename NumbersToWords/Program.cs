using System;

namespace NumbersToWords 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Scrabble Word Score Calculator");
      Repeat();
    }
    public static void Repeat()
    {
      Console.WriteLine(" What is your word (Press Enter to exit)");
      string inputText = Console.ReadLine();
      Word newWord = new Word(inputText);
      if (newWord.IsWord())
      {
      newWord.SetInputArray();
      newWord.AddScore();
      Console.WriteLine("The word " + newWord.Input + " scores " + newWord.WordScore + " points.");
      Repeat();
      }
    }
  }
}