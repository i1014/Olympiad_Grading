namespace Olympiad_Grading
{
    partial class AuthenticationEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationEntryForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitCancelTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AuthEntryLabel = new System.Windows.Forms.Label();
            this.SubmitCancelTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 1;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 42);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(28, 13);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Key:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(3, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(137, 36);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(146, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(136, 36);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitCancelTableLayout
            // 
            this.SubmitCancelTableLayout.ColumnCount = 2;
            this.SubmitCancelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SubmitCancelTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SubmitCancelTableLayout.Controls.Add(this.CancelButton, 1, 0);
            this.SubmitCancelTableLayout.Controls.Add(this.SubmitButton, 0, 0);
            this.SubmitCancelTableLayout.Location = new System.Drawing.Point(12, 65);
            this.SubmitCancelTableLayout.Name = "SubmitCancelTableLayout";
            this.SubmitCancelTableLayout.RowCount = 1;
            this.SubmitCancelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SubmitCancelTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SubmitCancelTableLayout.Size = new System.Drawing.Size(287, 42);
            this.SubmitCancelTableLayout.TabIndex = 5;
            // 
            // AuthEntryLabel
            // 
            this.AuthEntryLabel.AutoSize = true;
            this.AuthEntryLabel.Location = new System.Drawing.Point(12, 9);
            this.AuthEntryLabel.Name = "AuthEntryLabel";
            this.AuthEntryLabel.Size = new System.Drawing.Size(286, 13);
            this.AuthEntryLabel.TabIndex = 6;
            this.AuthEntryLabel.Text = "Please enter your authentication key provided by Avogadro";
            // 
            // AuthenticationEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 119);
            this.Controls.Add(this.AuthEntryLabel);
            this.Controls.Add(this.SubmitCancelTableLayout);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthenticationEntryForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Authentication";
            this.SubmitCancelTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TableLayoutPanel SubmitCancelTableLayout;
        private System.Windows.Forms.Label AuthEntryLabel;

    }
}