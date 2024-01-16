using System;
using system.Collections.Generic;

namespace Sphinx.Models
{
    public class SphinxRiddles
    {
        private List<String> riddles = new List<string>
        {
          "I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?",
          "The more you take, the more you leave behind. What am I?",
          "I have keys but no locks. I have space but no room. You can enter, but you can't go inside. What am I?"
        }
        private List<String> riddlesAnswers = new List<string>
        {
          "echo",
          "footsteps",
          "keyboard"
        }

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


public string CheckType()
{
    if ((Side1 > (Side2 + _side3)) || (Side2 > (Side1 + _side3)) || (_side3 > (Side1 + Side2)))
    {
        return "not a triangle";
    }
    else if ((Side1 != Side2) && ((Side1 != _side3)) && ((Side2 != _side3)))
    {
        return "scalene triangle";
    }
    else if ((Side1 == Side2) && (Side1 == _side3))
    {
        return "equilateral triangle";
    }
    else
    {
        return "isosceles triangle";
    }
}