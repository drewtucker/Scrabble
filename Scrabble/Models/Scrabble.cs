using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace ScrabbleApp.Models
{
  public class Scrabble
  {
    public static int wordTotal = 0;
    public static string userWord;
    public static Dictionary<char, int> LetterValues = new Dictionary<char, int>(){{'A', 1}, {'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N', 1}, {'R', 1}, {'S', 1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10} };

    public static int ScrabbleCalc(string userInput)
    {
      char[] userInputArray = userInput.ToUpper().ToCharArray();
      foreach(char i in userInputArray)
      {
        wordTotal += LetterValues[i];
      }
      return wordTotal;
    }
    public static void SetUserWord(string userInput)
    {
      userWord = userInput;
    }
    public static string GetUserWord()
    {
      return userWord;
    }
    public static int GetScore()
    {
      return wordTotal;
    }

    public static void DeleteAll()
    {
      wordTotal = 0;
    }
  }
}
