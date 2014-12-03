using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Olympiad_Grading.DataConfirmation;
using Olympiad_Grading.DataConfirmation.Models;

namespace Olympiad_Grading
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Submit_Click(object sender, RibbonControlEventArgs e)
        {
            // Launches the Data Confirmation Form for the user to read over
            // Needs a string double dictionary to be valid
            Dictionary<string, double> testDic = new Dictionary<string, double>();
            testDic.Add("Leopard HS", 123.22);
            testDic.Add("Jaguar HS", 150.0);
            testDic.Add("Lion HS", 0.62);
            var test = new DataConfirmationForm(new TeamScores(testDic));
            test.Show();

            //Verification verify = new Verification();
            //if(verify.verifyData())
            //{
                
            //}
        }

        private void Authentication_Click(object sender, RibbonControlEventArgs e)
        {
            var authEntryForm = new AuthenticationEntryForm();
            authEntryForm.Show();
        }
    }
}
