//Prompt
  //console app that takes a word and returns the scrabble score for that word.
  //A, E, I, O, U, L, N, R, S, T == 1
  //D, G                         == 2
  //B, C, M, P                   == 3
  //K                            == 5
  //J, X                         == 8
  //Q, Z                         == 10

//Requirements

//Further Exploration




using System;

namespace NumbersToWords
{
  public class Word
  {
    public string Input { get; set; }
    public char[] InputArray { get; set;}
    public int WordScore { get; set; }
    // properties, constructors, methods, etc. go here
    public Word(string input)
    {
      char[] arrayed = new char[input.Length];
      Input = input.ToLower();
      InputArray = arrayed;
      WordScore = 0;
    }

    public bool IsWord()
    {
      if(this.Input != "") 
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public void SetInputArray()
    {
      for (int i = 0; i < this.Input.Length; i++)
      {
        this.InputArray[i] = this.Input[i];
      }
    }

    public void AddScore()
    {
      string one = "aeioulnrst";
      string two = "dg";
      string three = "bcmp";
      string four = "fhvwy";
      string five = "k";
      string eight = "jx";
      string ten = "qz";
      foreach (char letter in InputArray)
      {
        if (one.Contains(letter))
        {
          WordScore ++;
        }
        else if (two.Contains(letter))
        {
          WordScore += 2;
        }
        else if (three.Contains(letter))
        {
          WordScore += 3;
        }
        else if (four.Contains(letter))
        {
          WordScore += 4;
        }
        else if (five.Contains(letter))
        {
          WordScore += 5;
        }
        else if (eight.Contains(letter))
        {
          WordScore += 8;
        }
        else if (ten.Contains(letter))
        {
          WordScore += 10;
        }
      }
    }
  }
}