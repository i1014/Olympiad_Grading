using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.DataConfirmation.Models
{
    public class TeamScore
    {

        public string Name { get; set; }

        public double Score { get; set; }

        public int Tier { get; set; }

        public TeamScore(string name, double score, int tier)
        {
            this.Name = name;
            this.Score = score;
            this.Tier = tier;
        }

    }
}
