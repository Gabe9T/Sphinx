using System;
using System.Collections.Generic;

namespace Sphinx.Models
{
    public class SphinxRiddles
    {

        public int AmountOfRiddles
        { get {return riddles.Count;}}
        private List<String> riddles = new List<string>
        {
          "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?",
          "The more you take, the more you leave behind. What am I?",
          "I have keys but no locks. I have space but no room. You can enter, but you can't go inside. What am I?"
        };
        private List<String> riddlesAnswers = new List<string>
        {
          "echo",
          "footsteps",
          "keyboard"
        };

      public string GetRiddle(int index)
        {
            return riddles[index];
        }

          public string GetAnswer(int index)
        {
            return riddlesAnswers[index];
        }
    }
}