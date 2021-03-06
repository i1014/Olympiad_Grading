﻿using Olympiad_Grading.DataConfirmation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Olympiad_Grading.DataConfirmation
{
    public partial class DataConfirmationForm : Form
    {
        public TeamScores TeamScores { get; set; }

        public DataConfirmationForm(TeamScores teamScores)
        {
            this.TeamScores = teamScores;
            InitializeComponent();
            AddDataToList();
        }

        private void AddDataToList()
        {
            foreach (var S in this.TeamScores.Scores) 
            {
                ListViewItem score = new ListViewItem(S.Key);
                score.SubItems.Add(S.Value.ToString());
                this.ScoresListView.Items.Add(score);
            }
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            this.ResizeColumns();        
        }

        private void ScoersListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            this.ResizeColumns();        
        }

        private void ResizeColumns()
        {
            this.ScoresListView.Columns[1].Width = -2; // The rest of the availible size
        }
    }
}
