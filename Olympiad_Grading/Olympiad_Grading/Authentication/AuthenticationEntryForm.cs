using Olympiad_Grading.DataConfirmation;
using Olympiad_Grading.DataConfirmation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Olympiad_Grading
{
    public partial class AuthenticationEntryForm : Form
    {
        OlympiadRibbon dataStore;
        public AuthenticationEntryForm(OlympiadRibbon main)
        {
            dataStore = main;
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            dataStore.authKey = this.textBox1.Text;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
