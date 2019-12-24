//a -> 4 b -> 8 c -> < e -> 3

//read phrase letter by letter
//@ each letter -> convert letter to leet char
//concatenate to string
//return string


using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class Translator
  {

    Dictionary<char,char> leetAlphabet = new Dictionary<char,char>()
    {
      {'A', '4'}, {'B', '8'}, {'C', '<'}, {'E', '3'}
    };

    public string Translate(string phrase)
    {
      var upperCasePhrase = phrase.ToUpper();//switch phrase to upper case

      //new character array w/ length of phrase
      char[] leetCharPhrase = new char[phrase.Length];

      //transform phrase into character array
      leetCharPhrase = upperCasePhrase.ToCharArray();

      int counter = 0;
      char charVar = '0';

      foreach(char c in leetCharPhrase)
      {
        charVar = c;
        leetCharPhrase[counter] = leetAlphabet[charVar];
        counter++;
      }

      return phrase = new string(leetCharPhrase);
    }
  }
}
