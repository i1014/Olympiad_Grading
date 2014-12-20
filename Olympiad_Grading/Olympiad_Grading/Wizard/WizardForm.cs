using Olympiad_Grading.DataConfirmation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Olympiad_Grading.Wizard
{
    public partial class WizardForm : Form
    {
        public TeamScores TeamScores { get; set; }

        public WizardForm()
        {
            InitializeComponent();
            this.TeamScores = new TeamScores();
        }

        private void WizardForm_ResizeEnd(object sender, EventArgs e)
        {
            var singleColumnWidth = this.ScoresListView.Width / 5.0;
            this.ScoresListView.Columns[0].Width = (int)(2 * singleColumnWidth);
            this.ScoresListView.Columns[1].Width = (int)singleColumnWidth;
            this.ScoresListView.Columns[2].Width = (int)singleColumnWidth;
            this.ScoresListView.Columns[3].Width = -2;
        }

        private void SetScoresButton_Click(object sender, EventArgs e)
        {
            double[] scores;
            try
            {
                scores = this.ParseCurrentSelection()
                    .Select<string, double>(x => Convert.ToDouble(x))
                    .ToArray<double>();

                if (scores.Length == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Scores = scores;
                }
                else
                {
                    MessageBox.Show(String.Format("There has to be the same number of team scores as team names.\n\n currently there are {0} team names and you have selected {1} scores", this.TeamScores.Names.Length, scores.Length));
                }

            }
            catch
            {
                MessageBox.Show("The data entered is not all numbers");
            }

        }

        private void SetTeamsButton_Click(object sender, EventArgs e)
        {
            this.TeamScores.Names = this.ParseCurrentSelection().ToArray<String>();
        }

        private void SetTiebreakersButton_Click(object sender, EventArgs e)
        {
            int[] tiebreakers;
            try
            {
                tiebreakers = this.ParseCurrentSelection()
                    .Select<string, int>(x => Convert.ToInt32(x))
                    .ToArray<int>();

                if (tiebreakers.Length == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Tiebreakers = tiebreakers;
                    this.UpdateScoresListView();
                }
                else
                {
                    MessageBox.Show(String.Format("There has to be the same number of tiebreaker values as teams.\n\n currently there are {0} teams and you have selected {1} tiebreaker values", this.TeamScores.Names.Length, tiebreakers.Length));
                }

            }
            catch
            {
                MessageBox.Show("The data entered is not all whole numbers");
            }
        }

        private void SetTiersButton_Click(object sender, EventArgs e)
        {
            int[] tiers;
            try
            {
                tiers = this.ParseCurrentSelection()
                    .Select<string, int>(x => Convert.ToInt32(x))
                    .ToArray<int>();

                if (tiers.Length == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Tiers = tiers;
                }
                else
                {
                    MessageBox.Show(String.Format("There has to be the same number of tier values as teams.\n\n currently there are {0} teams and you have selected {1} tier values", this.TeamScores.Names.Length, tiers.Length));
                }

            }
            catch
            {
                MessageBox.Show("The data entered is not all whole numbers");
            }
        }

        private IEnumerable<String> ParseCurrentSelection()
        {
            var currentApp = Globals.ThisAddIn.Application as Excel.Application;
            var selected = currentApp.Selection as Excel.Range;

            IEnumerable<String> nameData = new List<String>();

            if (selected.Cells.Value is System.Array)
            {
                nameData = ((System.Array)selected.Cells.Value).OfType<object>().Select(x => Convert.ToString(x));
            }
            else if (selected.Cells.Value != null)
            {
                nameData = new string[] { selected.Cells.Value.ToString() };
            }

            return nameData;

        }

        private void UpdateScoresListView()
        {
            this.ScoresListView.Items.Clear();

            if (this.TeamScores.IsRectangular())
            {
                MessageBox.Show("This is good");
                for (int i = 0; i < this.TeamScores.Names.Count(); i++)
                {
                    this.ScoresListView.Items.Add(new ListViewItem(new string[] { this.TeamScores.Names[i], Convert.ToString(this.TeamScores.Scores[i]), Convert.ToString(this.TeamScores.Tiers[i]), Convert.ToString(this.TeamScores.Tiebreakers[i]) }));
                }
            }
            else
            {
                MessageBox.Show("no no no");
            }
        }
    }
}

