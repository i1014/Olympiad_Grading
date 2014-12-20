using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.DataConfirmation.Models
{
    public class TeamScores
    {
        public string[] Names { get; set; }

        public double[] Scores { get; set; }

        public int[] Tiers { get; set; }

        public int[] Tiebreakers { get; set; }

        public TeamScores()
        {
            this.Names = new string[] { };
            this.Scores = new double[] { };
            this.Tiers = new int[] { };
            this.Tiebreakers = new int[] { };
        }

        public TeamScores(string[] names, double[] scores, int[] tiers, int[] tiebreakers)
        {
            this.Names = names;
            this.Scores = scores;
            this.Tiers = tiers;
            this.Tiebreakers = tiebreakers;
        }

        public bool IsRectangular()
        {
            return (this.Names.Length == this.Scores.Length && this.Names.Length == this.Tiers.Length && this.Names.Length == this.Tiebreakers.Length);
        }

    }
}
