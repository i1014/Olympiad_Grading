﻿using Olympiad_Grading.AvaComm;
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
            var jsonRequest = new JsonRequest(TEMP_URL, "POST",new BasicAuth(this.UsernameTextbox.Text, this.AuthenticationTextBox.Text));
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
                
                foreach(string score in scores)
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

    }
}

 