using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Olympiad_Grading.DataConfirmation;
using Olympiad_Grading.DataConfirmation.Models;

namespace Olympiad_Grading
{
    public partial class Ribbon1
    {
        Verification verify;
        double[] grades = new double[0];
        string[] teams = new string[0];

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            verify = new Verification();
        }

        private void Submit_Click(object sender, RibbonControlEventArgs e)
        {
            if(grades.Length != teams.Length)
            {
                MessageBox.Show("Teams do not all have a corresponding score.\nRe-select the grades or team names.");
            }
            // Launches the Data Confirmation Form for the user to read over
            // Needs a string double dictionary to be valid
            Dictionary<string, double> testDic = new Dictionary<string, double>();
            testDic.Add("Leopard HS", 123.22);
            testDic.Add("Jaguar HS", 150.0);
            testDic.Add("Lion HS", 0.62);
            var test = new DataConfirmationForm(new TeamScores(testDic));
            test.Show();
        }

        private void Authentication_Click(object sender, RibbonControlEventArgs e)
        {
            var authEntryForm = new AuthenticationEntryForm();
            authEntryForm.Show();
        }

        private void nameButton_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application currentApp = Globals.ThisAddIn.Application as Excel.Application;
            Excel.Range selected = currentApp.Selection as Excel.Range;
            System.Array myvalues = (System.Array)selected.Cells.Value;
            string[] nameData = verify.ConvertToStringArray(myvalues);
            if (verify.verifyName(nameData))
            {
                teams = nameData;
            }
        }

        private void gradeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Application currentApp = Globals.ThisAddIn.Application as Excel.Application;
            Excel.Range selected = currentApp.Selection as Excel.Range;
            System.Array myvalues = (System.Array)selected.Cells.Value;
            string[] testData = verify.ConvertToStringArray(myvalues);
            if (verify.verifyData(testData))
            {
                grades = new double[testData.Length];
                for (int i = 0; i < testData.Length; i++)
                {
                    grades[i] = Double.Parse(testData[i]);
                }
            }
        }
    }
}
