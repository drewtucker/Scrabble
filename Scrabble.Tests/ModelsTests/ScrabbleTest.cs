using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleApp;
using System.Collections.Generic;
using ScrabbleApp.Models;

namespace ScrabbleApp.Tests
{
  [TestClass]
  public class ScrabbleAppTest
  {
    [TestMethod]
    public void TestScrabbleFunction()
    {
      char[] userInput = new char[] {};
      int testScore = 0;
      Assert.AreEqual(testScore, Scrabble.ScrabbleCalc(userInput));


    }
  }
}
