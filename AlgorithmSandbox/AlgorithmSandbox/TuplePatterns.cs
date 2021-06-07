using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSandbox
{
    class TuplePatterns
    {
        /// <summary>
        /// Matches the parameters to the tuple expression and returns the result of evaluating the expression
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static string RockPaperScissors( string first, string second )
            => (first, second) switch
            {
                ("rock", "paper" ) => "rock is covered by paper. Paper wins.",
                ("rock", "scissors" ) => "rock breaks scissors. Rock wins.",
                ("paper", "rock" ) => "paper covers rock. Paper wins.",
                ("paper", "scissors" ) => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock" ) => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper" ) => "scissors cuts paper. Scissors wins.",
                (_, _ ) => "tie"
            };
    }
}
