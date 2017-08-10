using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleGameTest
  {

    [TestMethod]
    public void GetScore_Return0Points_0()
    {
      ScrabbleGame newWord = new ScrabbleGame("");
      int expected = 0;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnOnePoint_1()
    {
      ScrabbleGame newWord = new ScrabbleGame("I");
      int expected = 1;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnTwoPoint_2()
    {
      ScrabbleGame newWord = new ScrabbleGame("AI");
      int expected = 2;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnUpperCaseThreePoint_3()
    {
      ScrabbleGame newWord = new ScrabbleGame("aeI");
      int expected = 3;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnTwoPointsLetter_2()
    {
      ScrabbleGame newWord = new ScrabbleGame("d");
      int expected = 2;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnThreePoints2Lists_3()
    {
      ScrabbleGame newWord = new ScrabbleGame("do");
      int expected = 3;
      int actual = newWord.GetScore();
      Console.WriteLine(actual);
      Assert.AreEqual(expected, actual);
    }


    // public void Dispose()
    // {
    //   ScrabbleGame.ClearAll();
    // }
  }
}
