using Olympiad_Grading.DataConfirmation;
using Olympiad_Grading.DataConfirmation.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Olympiad_Grading
{
    public partial class AuthenticationEntryForm : Form
    {
        public AuthenticationEntryForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
