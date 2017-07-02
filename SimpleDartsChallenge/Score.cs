using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dartz;

namespace SimpleDartsChallenge
{
    public class Score
    {
        // Player, Dart, and Score pulled together
        public static void ScoreDart(Player player, Dart dart)
        {
            int score = 0;  // begining score

            // standard, double and tripple scoring
            if (dart.IsTriple) score = dart.Score * 3; // tripple score
            else if (dart.IsDouble) score = dart.Score * 2; //double score
            else score = dart.Score;

            // Bullseye scoring
            if (dart.IsTriple && dart.Score == 0) score = 50;
            else if (dart.Score == 0) score = 25;

            player.Score += score;
        }
    }
}