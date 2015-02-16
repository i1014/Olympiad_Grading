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

        public readonly static int DEFAULT_TIER = 10;

        public string authKey = "";
        public string urlEnd = ""; // need to set to used in the DataConfirmationForm
        private const string TEMP_URL = "http://requestb.in/17iwh9m1"; // current end point for testing

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
            var singleColumnWidth = this.ScoresListView.Width / 3.0;
            this.ScoresListView.Columns[0].Width = (int)singleColumnWidth;
            this.ScoresListView.Columns[1].Width = (int)singleColumnWidth;
            this.ScoresListView.Columns[2].Width = -2;
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
                    this.ScoresListView.Items.Add(new ListViewItem(new string[] { this.TeamScores.Names[i], this.TeamScores.Scores[i] == null ? this.TeamScores.Flags[i] : Convert.ToString(this.TeamScores.Scores[i]), Convert.ToString(this.TeamScores.Tiers[i]) }));
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ContainsDuplicates(this.TeamScores.Scores, this.TeamScores.Tiers))
            {
                this.MakeRequest();
            }
            else
            {
                MessageBox.Show("The scores submitted have a tie, please add a small decimal (0.1) to one of the scores to break the tie.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Press \"Cancel\" to close this dialog or press \"OK\" to close the wizard.", "Are You Sure", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MakeRequest()
        {
            var jsonRequest = new JsonRequest(TEMP_URL, "POST", new BasicAuth(this.UsernameTextbox.Text, this.AuthenticationTextBox.Text));
            ScoreModel scoreModel = new ScoreModel(this.TeamScores);
            var response = jsonRequest.Execute(scoreModel);
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

            List<double?> rawScores = new List<double?>();
            List<string> flags = new List<string>();
            try
            {
                IEnumerable<String> scores = this.ParseSelection(range);

                foreach (string score in scores)
                {
                    if (score.Equals(Flags.DQ))
                    {
                        rawScores.Add(null);
                        flags.Add(Flags.DQ);
                    }
                    else if (score.Equals(Flags.NS))
                    {
                        rawScores.Add(null);
                        flags.Add(Flags.NS);
                    }
                    else if (score.Equals(Flags.P))
                    {
                        rawScores.Add(null);
                        flags.Add(Flags.P);
                    }
                    else
                    {
                        rawScores.Add(Convert.ToDouble(score));
                        flags.Add(null);
                    }
                }
                //.Select<string, double?>(x => Convert.ToDouble(x))
                //.ToArray<double?>();

                if (rawScores.Count == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Scores = rawScores.ToArray();
                    this.TeamScores.Flags = flags.ToArray();
                    this.UpdateScoresListView();
                }
                else
                {
                    MessageBox.Show(String.Format("There has to be the same number of team scores as team names.\n\n currently there are {0} team names and you have selected {1} scores", this.TeamScores.Names.Length, scores.Count()));
                }

            }
            catch
            {
                MessageBox.Show("The data entered is not all numbers or valid non-numeric values.\nThe availible non-numeric values are NS, DQ, and P");
            }
            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Scores_SelectionChange;
        }

        void Tiers_SelectionChange(Excel.Range range)
        {

                IEnumerable<String> rawTiers = this.ParseSelection(range);
                var tiers = new List<int>();
                foreach (String tier in rawTiers)
                {
                    try
                    {
                        tiers.Add( Convert.ToInt32(tier) );
                    } 
                    catch //(Exception e)
                    {
                        tiers.Add( DEFAULT_TIER );
                    }

                }

                if (tiers.Count() == this.TeamScores.Names.Length)
                {
                    this.TeamScores.Tiers = tiers.ToArray();
                    this.UpdateScoresListView();
                }
                else
                {
                    MessageBox.Show(String.Format("There has to be the same number of tier values as teams.\n\n currently there are {0} teams and you have selected {1} tier values", this.TeamScores.Names.Length, tiers.Count()));
                }

            
            
            this.WindowState = FormWindowState.Normal;
            this.Activate();

            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            ws.SelectionChange -= Tiers_SelectionChange;
        }

        private bool ContainsDuplicates(double?[] scores, int[] tiers)
        {
            var duplicateDictionary = new Dictionary<double?, int>();

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] != null && duplicateDictionary.ContainsKey(scores[i]) && duplicateDictionary[scores[i]] == tiers[i])
                {
                    return false;
                }
                else if ( scores[i] != null )
                {
                    duplicateDictionary.Add(scores[i], tiers[i]);
                }
            }

            return true;
        }

        private void GetEventListButton_Click(object sender, EventArgs e)
        {
            this.EventSelectionComboBox.Items.Add("This");
            this.EventSelectionComboBox.Items.Add("is");
            this.EventSelectionComboBox.Items.Add("just");
            this.EventSelectionComboBox.Items.Add("a");
            this.EventSelectionComboBox.Items.Add("Test");
        }

    }
}

