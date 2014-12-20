namespace Olympiad_Grading.Wizard
{
    partial class WizardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ScoresListView = new System.Windows.Forms.ListView();
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tiebreaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventSelectionLabel = new System.Windows.Forms.Label();
            this.EventSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.EventSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.AuthenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AuthenticationLabel = new System.Windows.Forms.Label();
            this.SetTiersButton = new System.Windows.Forms.Button();
            this.SetTeamsButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.SetDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TiersLabel = new System.Windows.Forms.Label();
            this.TeamsLabel = new System.Windows.Forms.Label();
            this.TiebreakersLabel = new System.Windows.Forms.Label();
            this.SetScoresButton = new System.Windows.Forms.Button();
            this.SetTiebreakersButton = new System.Windows.Forms.Button();
            this.ScoresLabel = new System.Windows.Forms.Label();
            this.EventSelectionGroupBox.SuspendLayout();
            this.AuthenticationGroupBox.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.SetDataTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(430, 457);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 32);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(342, 457);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 32);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // ScoresListView
            // 
            this.ScoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Score,
            this.Tier,
            this.Tiebreaker});
            this.ScoresListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScoresListView.GridLines = true;
            this.ScoresListView.Location = new System.Drawing.Point(3, 80);
            this.ScoresListView.Name = "ScoresListView";
            this.ScoresListView.Scrollable = false;
            this.ScoresListView.Size = new System.Drawing.Size(494, 260);
            this.ScoresListView.TabIndex = 6;
            this.ScoresListView.UseCompatibleStateImageBehavior = false;
            this.ScoresListView.View = System.Windows.Forms.View.Details;
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 200;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 100;
            // 
            // Tier
            // 
            this.Tier.Text = "Tier";
            this.Tier.Width = 100;
            // 
            // Tiebreaker
            // 
            this.Tiebreaker.Text = "Tiebreaker";
            this.Tiebreaker.Width = 85;
            // 
            // EventSelectionLabel
            // 
            this.EventSelectionLabel.AutoSize = true;
            this.EventSelectionLabel.Location = new System.Drawing.Point(6, 16);
            this.EventSelectionLabel.Name = "EventSelectionLabel";
            this.EventSelectionLabel.Size = new System.Drawing.Size(93, 13);
            this.EventSelectionLabel.TabIndex = 7;
            this.EventSelectionLabel.Text = "Select Your Event";
            // 
            // EventSelectionGroupBox
            // 
            this.EventSelectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventSelectionGroupBox.Controls.Add(this.EventSelectionComboBox);
            this.EventSelectionGroupBox.Controls.Add(this.EventSelectionLabel);
            this.EventSelectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EventSelectionGroupBox.Name = "EventSelectionGroupBox";
            this.EventSelectionGroupBox.Size = new System.Drawing.Size(500, 43);
            this.EventSelectionGroupBox.TabIndex = 8;
            this.EventSelectionGroupBox.TabStop = false;
            this.EventSelectionGroupBox.Text = "Event Selection";
            // 
            // EventSelectionComboBox
            // 
            this.EventSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventSelectionComboBox.FormattingEnabled = true;
            this.EventSelectionComboBox.Items.AddRange(new object[] {
            "Boomilever",
            "Robo-Cop"});
            this.EventSelectionComboBox.Location = new System.Drawing.Point(373, 13);
            this.EventSelectionComboBox.Name = "EventSelectionComboBox";
            this.EventSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.EventSelectionComboBox.TabIndex = 8;
            // 
            // AuthenticationGroupBox
            // 
            this.AuthenticationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationGroupBox.Controls.Add(this.textBox1);
            this.AuthenticationGroupBox.Controls.Add(this.AuthenticationLabel);
            this.AuthenticationGroupBox.Location = new System.Drawing.Point(12, 62);
            this.AuthenticationGroupBox.Name = "AuthenticationGroupBox";
            this.AuthenticationGroupBox.Size = new System.Drawing.Size(500, 39);
            this.AuthenticationGroupBox.TabIndex = 9;
            this.AuthenticationGroupBox.TabStop = false;
            this.AuthenticationGroupBox.Text = "Authentication";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(373, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // AuthenticationLabel
            // 
            this.AuthenticationLabel.AutoSize = true;
            this.AuthenticationLabel.Location = new System.Drawing.Point(6, 16);
            this.AuthenticationLabel.Name = "AuthenticationLabel";
            this.AuthenticationLabel.Size = new System.Drawing.Size(124, 13);
            this.AuthenticationLabel.TabIndex = 0;
            this.AuthenticationLabel.Text = "Enter Authentication Key";
            // 
            // SetTiersButton
            // 
            this.SetTiersButton.Location = new System.Drawing.Point(249, 32);
            this.SetTiersButton.Name = "SetTiersButton";
            this.SetTiersButton.Size = new System.Drawing.Size(117, 23);
            this.SetTiersButton.TabIndex = 13;
            this.SetTiersButton.Text = "Set Tiers";
            this.SetTiersButton.UseVisualStyleBackColor = true;
            this.SetTiersButton.Click += new System.EventHandler(this.SetTiersButton_Click);
            // 
            // SetTeamsButton
            // 
            this.SetTeamsButton.Location = new System.Drawing.Point(3, 32);
            this.SetTeamsButton.Name = "SetTeamsButton";
            this.SetTeamsButton.Size = new System.Drawing.Size(117, 23);
            this.SetTeamsButton.TabIndex = 11;
            this.SetTeamsButton.Text = "Set Teams";
            this.SetTeamsButton.UseVisualStyleBackColor = true;
            this.SetTeamsButton.Click += new System.EventHandler(this.SetTeamsButton_Click);
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGroupBox.Controls.Add(this.SetDataTableLayoutPanel);
            this.DataGroupBox.Controls.Add(this.ScoresListView);
            this.DataGroupBox.Location = new System.Drawing.Point(12, 107);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(500, 343);
            this.DataGroupBox.TabIndex = 10;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Scores";
            // 
            // SetDataTableLayoutPanel
            // 
            this.SetDataTableLayoutPanel.AutoSize = true;
            this.SetDataTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetDataTableLayoutPanel.ColumnCount = 4;
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.Controls.Add(this.TiersLabel, 3, 1);
            this.SetDataTableLayoutPanel.Controls.Add(this.TeamsLabel, 1, 1);
            this.SetDataTableLayoutPanel.Controls.Add(this.TiebreakersLabel, 3, 0);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetScoresButton, 0, 0);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetTeamsButton, 0, 1);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetTiebreakersButton, 2, 0);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetTiersButton, 2, 1);
            this.SetDataTableLayoutPanel.Controls.Add(this.ScoresLabel, 1, 0);
            this.SetDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetDataTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.SetDataTableLayoutPanel.Name = "SetDataTableLayoutPanel";
            this.SetDataTableLayoutPanel.RowCount = 2;
            this.SetDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetDataTableLayoutPanel.Size = new System.Drawing.Size(494, 58);
            this.SetDataTableLayoutPanel.TabIndex = 15;
            // 
            // TiersLabel
            // 
            this.TiersLabel.AutoSize = true;
            this.TiersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiersLabel.Location = new System.Drawing.Point(372, 29);
            this.TiersLabel.Name = "TiersLabel";
            this.TiersLabel.Size = new System.Drawing.Size(119, 29);
            this.TiersLabel.TabIndex = 18;
            this.TiersLabel.Text = "Tiers:";
            this.TiersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TeamsLabel
            // 
            this.TeamsLabel.AutoSize = true;
            this.TeamsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsLabel.Location = new System.Drawing.Point(126, 29);
            this.TeamsLabel.Name = "TeamsLabel";
            this.TeamsLabel.Size = new System.Drawing.Size(117, 29);
            this.TeamsLabel.TabIndex = 17;
            this.TeamsLabel.Text = "Teams:";
            this.TeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TiebreakersLabel
            // 
            this.TiebreakersLabel.AutoSize = true;
            this.TiebreakersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiebreakersLabel.Location = new System.Drawing.Point(372, 0);
            this.TiebreakersLabel.Name = "TiebreakersLabel";
            this.TiebreakersLabel.Size = new System.Drawing.Size(119, 29);
            this.TiebreakersLabel.TabIndex = 16;
            this.TiebreakersLabel.Text = "Tiebreakers:";
            this.TiebreakersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetScoresButton
            // 
            this.SetScoresButton.Location = new System.Drawing.Point(3, 3);
            this.SetScoresButton.Name = "SetScoresButton";
            this.SetScoresButton.Size = new System.Drawing.Size(117, 23);
            this.SetScoresButton.TabIndex = 12;
            this.SetScoresButton.Text = "Set Scores";
            this.SetScoresButton.UseVisualStyleBackColor = true;
            this.SetScoresButton.Click += new System.EventHandler(this.SetScoresButton_Click);
            // 
            // SetTiebreakersButton
            // 
            this.SetTiebreakersButton.Location = new System.Drawing.Point(249, 3);
            this.SetTiebreakersButton.Name = "SetTiebreakersButton";
            this.SetTiebreakersButton.Size = new System.Drawing.Size(117, 23);
            this.SetTiebreakersButton.TabIndex = 14;
            this.SetTiebreakersButton.Text = "Set Tiebreakers";
            this.SetTiebreakersButton.UseVisualStyleBackColor = true;
            this.SetTiebreakersButton.Click += new System.EventHandler(this.SetTiebreakersButton_Click);
            // 
            // ScoresLabel
            // 
            this.ScoresLabel.AutoSize = true;
            this.ScoresLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoresLabel.Location = new System.Drawing.Point(126, 0);
            this.ScoresLabel.Name = "ScoresLabel";
            this.ScoresLabel.Size = new System.Drawing.Size(117, 29);
            this.ScoresLabel.TabIndex = 15;
            this.ScoresLabel.Text = "Scores: ";
            this.ScoresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WizardForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 501);
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.AuthenticationGroupBox);
            this.Controls.Add(this.EventSelectionGroupBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.MinimumSize = new System.Drawing.Size(540, 540);
            this.Name = "WizardForm";
            this.ShowIcon = false;
            this.Text = "Submit Grades";
            this.ResizeEnd += new System.EventHandler(this.WizardForm_ResizeEnd);
            this.EventSelectionGroupBox.ResumeLayout(false);
            this.EventSelectionGroupBox.PerformLayout();
            this.AuthenticationGroupBox.ResumeLayout(false);
            this.AuthenticationGroupBox.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.SetDataTableLayoutPanel.ResumeLayout(false);
            this.SetDataTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListView ScoresListView;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Tier;
        private System.Windows.Forms.ColumnHeader Tiebreaker;
        private System.Windows.Forms.Label EventSelectionLabel;
        private System.Windows.Forms.GroupBox EventSelectionGroupBox;
        private System.Windows.Forms.ComboBox EventSelectionComboBox;
        private System.Windows.Forms.GroupBox AuthenticationGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AuthenticationLabel;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.Button SetTeamsButton;
        private System.Windows.Forms.Button SetTiersButton;
        private System.Windows.Forms.TableLayoutPanel SetDataTableLayoutPanel;
        private System.Windows.Forms.Button SetTiebreakersButton;
        private System.Windows.Forms.Button SetScoresButton;
        private System.Windows.Forms.Label TiersLabel;
        private System.Windows.Forms.Label TeamsLabel;
        private System.Windows.Forms.Label TiebreakersLabel;
        private System.Windows.Forms.Label ScoresLabel;
    }
}