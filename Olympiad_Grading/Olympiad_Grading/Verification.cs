using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Olympiad_Grading
{
    class Verification
    {
        public Verification()
        {

        }

        public string[] ConvertToStringArray(System.Array values)
        {
            string[] ret = new string[values.Length];

            for (int i = 0; i < values.GetLength(0); i++)
            {
                ret[i] = values.GetValue(i + 1, 1) != null ? values.GetValue(i + 1, 1).ToString() : "";
            }

            return ret;
        }

        public bool verifyName(string[] nameData)
        {
            for(int i = 0; i < nameData.Length; i++)
            {
                if(string.IsNullOrWhiteSpace(nameData[i]))
                {
                    MessageBox.Show("Names are not all filled.");
                    return false;
                }
                for(int j = i+1; j < nameData.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(nameData[j]))
                    {
                        MessageBox.Show("Names are not all filled.");
                        return false;
                    }
                    if(nameData[i].ToLower().Equals(nameData[j].ToLower()))
                    {
                        MessageBox.Show("Names are not all unique.");
                        return false;
                    }
                }
            }
            return true;
        }

        public bool verifyData(string[] testData)
        {
            double blank;
            for (int i = 0; i < testData.Length; i++ )
            {
                if(!double.TryParse(testData[i],out blank))
                {
                    MessageBox.Show("Data is not all numbers.");
                    return false;
                }
                if(blank <= 0)
                {
                    MessageBox.Show("Data is not all positive.");
                    return false;
                }
            }
            return true;
        }
    }

    
}
