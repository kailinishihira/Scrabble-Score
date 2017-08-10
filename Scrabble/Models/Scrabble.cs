using System.Collections.Generic;
using System;

namespace Scrabble.Models
{

  public class ScrabbleGame
  {
    private string _inputWord;
    private static int _keepScore;
    private static List<char> onePoint = new List<char> (){'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    private static List<char> twoPoint = new List<char> (){'D', 'G'};

    public ScrabbleGame(string inputWord)
    {
      _inputWord = inputWord;
    }
    //
    // public int GetKeepScore()
    // {
    //   return _keepScore;
    // }
    //
    // public void SetKeepScore(int keepScore)
    // {
    //   _keepScore = keepScore;
    // }

    public int GetScore()
    {
      // string upperCaseWord = _inputWord.ToUpper();
      // Dictionary<string, int> letterScore = new Dictionary<string, int>() { {"A", 1}, {"E", 1}, {"I", 1}, {"O", 1}, {"U", 1}, {"L", 1}, {"N", 1}, {"R", 1}, {"S", 1}, {"T", 1} };

      _keepScore = 0;
      string inputWordUpper = _inputWord.ToUpper();

      for (int i = 0; i < inputWordUpper.Length; i++)
      {
        // for (int j = 0; j < onePoint.Count; j++)
        // {
          for (int k = 0; k < twoPoint.Count; k++)
          {
            if (inputWordUpper[i] == twoPoint[k])
            {
              Console.WriteLine("got to two point");
              _keepScore += 2;
            }
            // if (inputWordUpper[i] == onePoint[j])
            // {
            //   Console.WriteLine("got to one point");
            //   _keepScore += 1;
            // }
          // }
        }
      }
      return _keepScore;
    }

    public static void ClearAll()
    {
      _keepScore = 0;
    }
  }
}
