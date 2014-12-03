using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.DataConfirmation.Models
{
    public class TeamScores
    {

        public Dictionary<string, double> Scores { get; set; }

        public TeamScores()
        {
            this.Scores = new Dictionary<string, double>();
        }

        public TeamScores(Dictionary<string, double> scores)
        {
            this.Scores = scores;
        }

    }
}
