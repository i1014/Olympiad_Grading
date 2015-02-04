using Olympiad_Grading.AvaComm;
using Olympiad_Grading.AvaComm.Poco;
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

        public string authKey = "";
        public string urlEnd = ""; // need to set to used in the DataConfirmationForm
        private const string TEMP_URL = "http://requestb.in/12p2cv01"; // current end point for testing

        public WizardForm()
        {
            InitializeComponent();
            this.TeamScores = new TeamScores();
        }

        private void WizardForm_Load(object sender, EventArgs e)
        {

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

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            this.WindowState = FormWindowState.Minimized;

            ws.SelectionChange += Scores_SelectionChange;

        }

        private void SetTeamsButton_Click(object sender, EventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            this.WindowState = FormWindowState.Minimized;

            ws.SelectionChange += Teams_SelectionChange;
        }

        private void SetTiebreakersButton_Click(object sender, EventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            this.WindowState = FormWindowState.Minimized;

            ws.SelectionChange += Tiebreakers_SelectionChange;
        }

        private void SetTiersButton_Click(object sender, EventArgs e)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            this.WindowState = FormWindowState.Minimized;

            ws.SelectionChange += Tiers_SelectionChange;
        }

        private IEnumerable<String> ParseSelection(Excel.Range range)
        {
            var currentApp = Globals.ThisAddIn.Application as Excel.Application;
            var selected = range;

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
                for (int i = 0; i < this.TeamScores.Names.Count(); i++)
                {
                    this.ScoresListView.Items.Add(new ListViewItem(new string[] { this.TeamScores.Names[i], Convert.ToString(this.TeamScores.Scores[i]), Convert.ToString(this.TeamScores.Tiers[i]), Convert.ToString(this.TeamScores.Tiebreakers[i]) }));
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.MakeRequest();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Press \"Cancel\" to remain on this page or press \"OK\" to close the wizard.", "Are You Sure", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MakeRequest()
        {
            var jsonRequest = new JsonRequest(TEMP_URL, "POST", new ApiAuth(this.AuthenticationTextBox.Text));
            var response = jsonRequest.Execute(this.TeamScores);
            MessageBox.Show(response.ToString());
        }

        void Teams_SelectionChange(Excel.Range range)
        {

            this.TeamScores.Names = this.ParseSelection(range).ToArray<String>();

            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Teams_SelectionChange;
        }

        void Scores_SelectionChange(Excel.Range range)
        {

            double[] scores;
            try
            {
                scores = this.ParseSelection(range)
                    .Select<string, double>(x => Convert.ToDouble(x))
                    .ToArray<double>();

                if (scores.Length == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Scores = scores;
                    this.UpdateScoresListView();
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
            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Scores_SelectionChange;
        }

        void Tiers_SelectionChange(Excel.Range range)
        {

            int[] tiers;
            try
            {
                tiers = this.ParseSelection(range)
                    .Select<string, int>(x => Convert.ToInt32(x))
                    .ToArray<int>();

                if (tiers.Length == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Tiers = tiers;
                    this.UpdateScoresListView();
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
            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Tiers_SelectionChange;
        }

        void Tiebreakers_SelectionChange(Excel.Range range)
        {

            int[] tiebreakers;
            try
            {
                tiebreakers = this.ParseSelection(range)
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
            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Tiebreakers_SelectionChange;
        }

    }
}

