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
            this.EventSelectionLabel = new System.Windows.Forms.Label();
            this.EventSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.EventSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.AuthenticationGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthenticationTextBox = new System.Windows.Forms.TextBox();
            this.AuthenticationLabel = new System.Windows.Forms.Label();
            this.SetTiersButton = new System.Windows.Forms.Button();
            this.SetTeamsButton = new System.Windows.Forms.Button();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.SetDataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SetScoresButton = new System.Windows.Forms.Button();
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
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ScoresListView
            // 
            this.ScoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Score,
            this.Tier});
            this.ScoresListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScoresListView.GridLines = true;
            this.ScoresListView.Location = new System.Drawing.Point(3, 51);
            this.ScoresListView.Name = "ScoresListView";
            this.ScoresListView.Scrollable = false;
            this.ScoresListView.Size = new System.Drawing.Size(494, 289);
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
            this.Score.Width = 150;
            // 
            // Tier
            // 
            this.Tier.Text = "Tier";
            this.Tier.Width = 190;
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
            this.EventSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventSelectionComboBox.FormattingEnabled = true;
            this.EventSelectionComboBox.Items.AddRange(new object[] {
            "Boomilever",
            "Code Busters",
            "Anthropology",
            "Criminology"});
            this.EventSelectionComboBox.Location = new System.Drawing.Point(373, 13);
            this.EventSelectionComboBox.Name = "EventSelectionComboBox";
            this.EventSelectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.EventSelectionComboBox.TabIndex = 8;
            // 
            // AuthenticationGroupBox
            // 
            this.AuthenticationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationGroupBox.Controls.Add(this.AuthenticationTextBox);
            this.AuthenticationGroupBox.Controls.Add(this.AuthenticationLabel);
            this.AuthenticationGroupBox.Location = new System.Drawing.Point(12, 62);
            this.AuthenticationGroupBox.Name = "AuthenticationGroupBox";
            this.AuthenticationGroupBox.Size = new System.Drawing.Size(500, 39);
            this.AuthenticationGroupBox.TabIndex = 9;
            this.AuthenticationGroupBox.TabStop = false;
            this.AuthenticationGroupBox.Text = "Authentication";
            // 
            // AuthenticationTextBox
            // 
            this.AuthenticationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationTextBox.Location = new System.Drawing.Point(373, 13);
            this.AuthenticationTextBox.Name = "AuthenticationTextBox";
            this.AuthenticationTextBox.Size = new System.Drawing.Size(121, 20);
            this.AuthenticationTextBox.TabIndex = 1;
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
            this.SetTiersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetTiersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetTiersButton.Location = new System.Drawing.Point(331, 3);
            this.SetTiersButton.Name = "SetTiersButton";
            this.SetTiersButton.Size = new System.Drawing.Size(160, 23);
            this.SetTiersButton.TabIndex = 13;
            this.SetTiersButton.Text = "Set Tiers";
            this.SetTiersButton.UseVisualStyleBackColor = true;
            this.SetTiersButton.Click += new System.EventHandler(this.SetTiersButton_Click);
            // 
            // SetTeamsButton
            // 
            this.SetTeamsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetTeamsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetTeamsButton.Location = new System.Drawing.Point(3, 3);
            this.SetTeamsButton.Name = "SetTeamsButton";
            this.SetTeamsButton.Size = new System.Drawing.Size(158, 23);
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
            this.SetDataTableLayoutPanel.ColumnCount = 3;
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SetDataTableLayoutPanel.Controls.Add(this.SetTeamsButton, 0, 0);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetTiersButton, 2, 0);
            this.SetDataTableLayoutPanel.Controls.Add(this.SetScoresButton, 1, 0);
            this.SetDataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetDataTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.SetDataTableLayoutPanel.Name = "SetDataTableLayoutPanel";
            this.SetDataTableLayoutPanel.RowCount = 1;
            this.SetDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetDataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetDataTableLayoutPanel.Size = new System.Drawing.Size(494, 29);
            this.SetDataTableLayoutPanel.TabIndex = 15;
            // 
            // SetScoresButton
            // 
            this.SetScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetScoresButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetScoresButton.Location = new System.Drawing.Point(167, 3);
            this.SetScoresButton.Name = "SetScoresButton";
            this.SetScoresButton.Size = new System.Drawing.Size(158, 23);
            this.SetScoresButton.TabIndex = 12;
            this.SetScoresButton.Text = "Set Scores";
            this.SetScoresButton.UseVisualStyleBackColor = true;
            this.SetScoresButton.Click += new System.EventHandler(this.SetScoresButton_Click);
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
            this.Load += new System.EventHandler(this.WizardForm_Load);
            this.ResizeEnd += new System.EventHandler(this.WizardForm_ResizeEnd);
            this.EventSelectionGroupBox.ResumeLayout(false);
            this.EventSelectionGroupBox.PerformLayout();
            this.AuthenticationGroupBox.ResumeLayout(false);
            this.AuthenticationGroupBox.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.SetDataTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListView ScoresListView;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader Tier;
        private System.Windows.Forms.Label EventSelectionLabel;
        private System.Windows.Forms.GroupBox EventSelectionGroupBox;
        private System.Windows.Forms.ComboBox EventSelectionComboBox;
        private System.Windows.Forms.GroupBox AuthenticationGroupBox;
        private System.Windows.Forms.TextBox AuthenticationTextBox;
        private System.Windows.Forms.Label AuthenticationLabel;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private System.Windows.Forms.Button SetTeamsButton;
        private System.Windows.Forms.Button SetTiersButton;
        private System.Windows.Forms.TableLayoutPanel SetDataTableLayoutPanel;
        private System.Windows.Forms.Button SetScoresButton;
    }
}