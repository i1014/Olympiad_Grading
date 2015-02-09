using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.DataConfirmation.Models
{
    public class ScoreModel
    {

        public List<TeamScore> TeamScoreList { get; set; }

        public ScoreModel(TeamScores scores)
        {

            this.TeamScoreList = new List<TeamScore>();

            if( scores.IsRectangular() )
            {
                for(int i = 0; i < scores.Names.Count(); i++)
                {
                    TeamScoreList.Add(new TeamScore(scores.Names[i], scores.Scores[i], scores.Tiers[i], scores.Flags[i]));
                }

            }

        }

    }
}

