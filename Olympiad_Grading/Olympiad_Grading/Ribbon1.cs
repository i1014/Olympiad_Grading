﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Olympiad_Grading
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void Submit_Click(object sender, RibbonControlEventArgs e)
        {
            Verification verify = new Verification();
            if(verify.verifyData())
            {
                
            }
        }

        private void Authentication_Click(object sender, RibbonControlEventArgs e)
        {
            var authEntryForm = new AuthenticationEntryForm();
            authEntryForm.Show();
        }
    }
}
