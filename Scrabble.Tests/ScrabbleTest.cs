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
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnThreePoints_3()
    {
      ScrabbleGame newWord = new ScrabbleGame("p");
      int expected = 3;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnSixPoints3Lists_6()
    {
      ScrabbleGame newWord = new ScrabbleGame("pad");
      int expected = 6;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnFourPoints_4()
    {
      ScrabbleGame newWord = new ScrabbleGame("f");
      int expected = 4;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnFourPoints4List_10()
    {
      ScrabbleGame newWord = new ScrabbleGame("adbf");
      int expected = 10;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnFivePoint_5()
    {
      ScrabbleGame newWord = new ScrabbleGame("k");
      int expected = 5;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnEightPoint_8()
    {
      ScrabbleGame newWord = new ScrabbleGame("j");
      int expected = 8;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_Return23Points6Lists_23()
    {
      ScrabbleGame newWord = new ScrabbleGame("abdfkj");
      int expected = 23;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnTenPoints_10()
    {
      ScrabbleGame newWord = new ScrabbleGame("Q");
      int expected = 10;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_Return33Points7Lists_10()
    {
      ScrabbleGame newWord = new ScrabbleGame("abdfkjq");
      int expected = 33;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnPointForEpicodus_13()
    {
      ScrabbleGame newWord = new ScrabbleGame("epicodus");
      int expected = 13;
      int actual = newWord.GetScore();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetScore_ReturnScoreForLongWord_56()
    {
      ScrabbleGame newWord = new ScrabbleGame("supercalifragilisticexpialidocious");
      int expected = 56;
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
