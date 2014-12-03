namespace Olympiad_Grading.DataConfirmation
{
    partial class DataConfirmationForm
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
            this.ScoresListView = new System.Windows.Forms.ListView();
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfirmDataLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoresListView
            // 
            this.ScoresListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoresListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Score});
            this.ScoresListView.GridLines = true;
            this.ScoresListView.Location = new System.Drawing.Point(12, 35);
            this.ScoresListView.Name = "ScoresListView";
            this.ScoresListView.Size = new System.Drawing.Size(264, 200);
            this.ScoresListView.TabIndex = 0;
            this.ScoresListView.UseCompatibleStateImageBehavior = false;
            this.ScoresListView.View = System.Windows.Forms.View.Details;
            this.ScoresListView.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.ScoersListView_ColumnWidthChanged);
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 160;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 100;
            // 
            // ConfirmDataLabel
            // 
            this.ConfirmDataLabel.AutoSize = true;
            this.ConfirmDataLabel.Location = new System.Drawing.Point(12, 9);
            this.ConfirmDataLabel.Name = "ConfirmDataLabel";
            this.ConfirmDataLabel.Size = new System.Drawing.Size(115, 13);
            this.ConfirmDataLabel.TabIndex = 1;
            this.ConfirmDataLabel.Text = "Confirm the data below";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(106, 241);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(82, 32);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(194, 241);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 32);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DataConfirmationForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 285);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ConfirmDataLabel);
            this.Controls.Add(this.ScoresListView);
            this.Name = "DataConfirmationForm";
            this.ShowIcon = false;
            this.Text = "Score Confirmation";
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ScoresListView;
        private System.Windows.Forms.Label ConfirmDataLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Score;
    }
}