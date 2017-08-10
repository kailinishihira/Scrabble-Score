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
    private static List<char> threePoint = new List<char> (){'B', 'C', 'M', 'P'};
    private static List<char> fourPoint = new List<char> (){'F', 'H', 'V', 'W', 'Y'};
    private static List<char> fivePoint = new List<char> (){'K'};
    private static List<char> eightPoint = new List<char> (){'J', 'X'};
    private static List<char> tenPoint = new List<char> (){'Q', 'Z'};

    public ScrabbleGame(string inputWord)
    {
      _inputWord = inputWord;
    }

    public int GetScore()
    {
      _keepScore = 0;
      string inputWordUpper = _inputWord.ToUpper();

      for (int i = 0; i < inputWordUpper.Length; i++)
      {
        for (int j = 0; j < onePoint.Count; j++)
        {
          if (inputWordUpper[i] == onePoint[j])
          {
            _keepScore += 1;
          }
        }
      }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int k = 0; k < twoPoint.Count; k++)
          {
            if (inputWordUpper[i] == twoPoint[k])
            {
              _keepScore += 2;
            }
          }
        }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int l = 0; l < threePoint.Count; l++)
          {
            if (inputWordUpper[i] == threePoint[l])
            {
              _keepScore += 3;
            }
          }
        }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int m = 0; m < fourPoint.Count; m++)
          {
            if (inputWordUpper[i] == fourPoint[m])
            {
              _keepScore += 4;
            }
          }
        }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int n = 0; n < fivePoint.Count; n++)
          {
            if (inputWordUpper[i] == fivePoint[n])
            {
              _keepScore += 5;
            }
          }
        }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int o = 0; o < eightPoint.Count; o++)
          {
            if (inputWordUpper[i] == eightPoint[o])
            {
              _keepScore += 8;
            }
          }
        }

        for (int i = 0; i < inputWordUpper.Length; i++)
        {
          for (int p = 0; p < tenPoint.Count; p++)
          {
            if (inputWordUpper[i] == tenPoint[p])
            {
              _keepScore += 10;
            }
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
