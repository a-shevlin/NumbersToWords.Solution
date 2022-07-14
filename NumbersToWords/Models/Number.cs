//Prompt
  //Console app that translates numbers in numeric form into written words.

//Requirements
  //Working for numbers up to 1 trillion (1000000000000)
  //Use multiple dictionaries

//Further Exploration


//Notes
  //split into array, eg: 1089 [1, 0, 8, 9]
  // if ( 60 - 99 ) { append ty }
  //{"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
  // if (number < 20)
  // {
  //   word += ones[number];
  // }
  // else
  // {
  //   words += tens[number];
  //   if ((number % 10) > 0)
  //   {
  //     word += "-" + ones[number % 10];
  //   }
  // }

  // {"twenty", "thirty, "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
  // if input is 302 break string into {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 2,} i=2  which also = hundreth 
  
  // if input is 302 break string into {"", "", "", "", "", "", "", "", "", "", "three - hundred", "and", "two",} i=2  which also = hundreth ;
  
  
//   for (i=0 i < length -2){

//   }

// if((302 / 100) > 0) 
// {
//   word += "hundred";
// }
// if((num >= 0))
// {
//   if(word != "")
//   {
//     word += "and ";
//   }
// }
using System;
using System.Collections.Generic;

//Actual code
namespace NumbersToWords
{
  public class Number
  {
    public int Input { get; set; }
    public string InputStr { get; set; }
    public int[] InputArray { get; set; }
    public string[] OutputArray { get; set; }
    public static Dictionary<int, string> Digits = new Dictionary<int, string>() { {0, ""}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"} };
    public static Dictionary<int, string> NumPlaces = new Dictionary<int, string>() { {0, ""}, {1, ""}, {2, "hundred"}, {3, "thousand"}, {4, "-thousand"}, {5, "hundred-thousand"}, {6, "million"}, {7, "-million"}, {8, "hundred-million"}, {9, "billion"}, {10, "-billion"}, {11, "hundred-billion"}, {12, "trillion"} };
    public static Dictionary<int, string> TensPlace = new Dictionary<int, string>() { {1, "tenty"}, {2, "twenty"}, {3, "thirty"}, {4, "forty"}, {5, "fifty"}};
    
    public Number(string input)
    {
      int[] arrayed = new int[input.Length];
      //alt: int[] arrayed = new int[12];
      string[] outputArray = new string[input.Length]; 
      InputStr = input;
      Input = int.Parse(input);
      InputArray = arrayed;
      OutputArray = outputArray;
    }

    public void TensConvert(int place)
    {
      if (TensPlace.ContainsKey(InputArray[place]))
      {
        OutputArray[place] = TensPlace[InputArray[place]];
      }
      else
      {
        OutputArray[place] = Digits[InputArray[place]];
        OutputArray[place] += "ty";
      }
    }

    public void BasicConvert()
    {
      int l = InputStr.Length;
      for (int i = 0; i < l; i++)
      {
        if (Digits.ContainsKey(InputArray[i]))
        {
          OutputArray[i] = Digits[InputArray[i]];
        }
      }
    }

    public void SetInputArray()
    {
      int l = InputStr.Length;
      for (int i = 0; i < l; i++)
      {
        InputArray[i] = Convert.ToInt32(Char.GetNumericValue(InputStr[i]));
      }
    }

//char foo = '2';
//int bar = foo - '0';
  }
}