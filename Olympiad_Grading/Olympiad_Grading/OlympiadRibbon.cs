using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Olympiad_Grading.DataConfirmation.Models;
using Olympiad_Grading.Wizard;

namespace Olympiad_Grading
{
    public partial class OlympiadRibbon
    {
        Verification verify;
        double[] grades = new double[0];
        string[] teams = new string[0];
        public string authKey = "";
        public string urlEnd = ""; // need to set to used in the DataConfirmationForm
        public string tempUrlEnd = "http://requestb.in/1ivqad81"; // current end point for testing

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            verify = new Verification();
        }

        private void Submit_Click(object sender, RibbonControlEventArgs e)
        {
            if (grades.Length < teams.Length)
            {
                MessageBox.Show("Teams do not all have a corresponding score.\nRe-select the grades or team names.");
                return;
            }
            else if (grades.Length > teams.Length)
            {
                MessageBox.Show("Grades do not all have a corresponding team.\nRe-select the grades or team names.");
                return;
            }
            else if (grades.Length == 0)
            {
                MessageBox.Show("Grades are not selected.\nRe-select the grades.");
                return;
            }
            else if (teams.Length == 0)
            {
                MessageBox.Show("Teams are not selected.\nRe-select the teams.");
                return;
            }
            // Launches the Data Confirmation Form for the user to read over
            // Needs a string double dictionary to be valid
            Dictionary<string, double> testDic = new Dictionary<string, double>();
            for (int i = 0; i < grades.Length; i++)
            {
                testDic.Add(teams[i], grades[i]);
            }
            
        }

        private void Authentication_Click(object sender, RibbonControlEventArgs e)
        {
            var authEntryForm = new AuthenticationEntryForm(this);
            authEntryForm.Show();
        }

        private void nameButton_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application currentApp = Globals.ThisAddIn.Application as Excel.Application;
            Excel.Range selected = currentApp.Selection as Excel.Range;
            
            string[] nameData;
            try
            {
                System.Array myvalues = (System.Array)selected.Cells.Value;
                nameData = verify.ConvertToStringArray(myvalues);
            }
            catch
            {
                string a = selected.Cells.Value.ToString();
                nameData = new string[] {a};
            }
            
            if (verify.verifyName(nameData))
            {
                teams = nameData;
            }
        }

        private void gradeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application currentApp = Globals.ThisAddIn.Application as Excel.Application;
            Excel.Range selected = currentApp.Selection as Excel.Range;
            string[] testData;
            try
            {
                System.Array myvalues = (System.Array)selected.Cells.Value;
                testData = verify.ConvertToStringArray(myvalues);
            }
            catch
            {
                string a = selected.Cells.Value.ToString();
                testData = new string[] { a };
            }
            if (verify.verifyData(testData))
            {
                grades = new double[testData.Length];
                for (int i = 0; i < testData.Length; i++)
                {
                    grades[i] = Double.Parse(testData[i]);
                }
            }
        }

        private void LaunchWizardButton_Click(object sender, RibbonControlEventArgs e)
        {

            var wizardForm = new WizardForm();
            wizardForm.Show();
        }
    }
}
