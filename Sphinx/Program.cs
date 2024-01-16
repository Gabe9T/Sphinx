using System;
using Sphinx.Models;
using System.Threading;

// using ConsoleColors;

namespace Sphinx
{
  class Program
  {
    static void Main()
    {

      Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--");
      Console.WriteLine("Welcome to Sphinx Riddles");
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine(@"                              .sSSSSSSSs
                              sSS=''^^^'s
                  /\       , /  \_\_\|_/_)
                 /';;     /| \\\/.-. .-./
                / \;|    /. \,S'  -   - |
               / -.;|    | '.SS     _|  ;
              ; '-.;\,   |'-.SS\   __  /S
              | _  ';\\.  \' SSS\_____/SS
              |  '- ';\\.  \_SSS[_____]SS
              \ '--.-';;-. __SSS/\    SSS
               \  .--' ';;'.=SSS`\\_\_SSS
                `._ .-'` _';;..=.=.=.\.=\
                   ;-._-'  _.;\.=.=.=.|.=|
         ,     _.-'    `'=._  ;\=.=__/__/
         )\ .'`   __        '.;|.=.=.=./
         (_\   .-`  '.   |    \/=.=.=/`
          /\\         \-,|     |.--'|
         /  \`,       //  \    | |  |
        ( (__) )  _.-'--,  \   | |  '--,
         ;----' -'--,__}}}  \  '--, __}}}
         \_________}}}       \___}}}");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("The sphinx will ask you a question and you must answer if you value your life");
      Console.WriteLine("Type 'begin' to start, or enter anything else to flee");
      Console.WriteLine("--#--#--#--#--#--#--#--#--#--#--");
      string userResponse = Console.ReadLine();
      if (userResponse == "begin" || userResponse == "Begin" || userResponse == "BEGIN")
      {
        StartRiddle();
      }
      else
      {
        Console.WriteLine("Farewell!");
      }
    }

    static void StartRiddle()
    {
      SphinxRiddles sphinxRiddles = new SphinxRiddles();

      Random rnd = new Random();
      int index = rnd.Next(sphinxRiddles.AmountOfRiddles);

      string newRiddle = sphinxRiddles.GetRiddle(index);
      string newAnswer = sphinxRiddles.GetAnswer(index);

      Console.WriteLine(newRiddle);

      string userResponse = Console.ReadLine();

      if (userResponse == newAnswer)
      {
        Console.WriteLine("You win!");
        ColorfulAnimation("You win!");
      }
      else
      {
        Console.WriteLine("You Lose!");
        ColorfulAnimation("You lose!");
      }
    }

    static void ColorfulAnimation(string statusMessage)
    {
        Thread.Sleep(2000);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Console.Clear();

                // steam
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("       . . . . o o o o o o");
                for (int s = 0; s < j / 2; s++)
                {
                    Console.Write(" o", ConsoleColor.White);
                }
                Console.WriteLine();

                var margin = "".PadLeft(j);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(margin + "                _____      o", ConsoleColor.Magenta);
                Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", ConsoleColor.Magenta);
                Console.WriteLine(margin + "      [________]_|__|________)< ", ConsoleColor.Magenta);
                Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", ConsoleColor.Magenta);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", ConsoleColor.Magenta);
                Console.WriteLine("");
                Console.WriteLine(statusMessage);
                Console.WriteLine("Press CTRL+C to Exit");

                Thread.Sleep(200);
            }
        }
    }
  }
}
