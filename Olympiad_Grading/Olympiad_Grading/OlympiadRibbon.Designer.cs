namespace Olympiad_Grading
{
    partial class OlympiadRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public OlympiadRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlympiadRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.gradeButton = this.Factory.CreateRibbonButton();
            this.nameButton = this.Factory.CreateRibbonButton();
            this.SubmitButton = this.Factory.CreateRibbonButton();
            this.AuthenticatonButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Olympiad";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.gradeButton);
            this.group1.Items.Add(this.nameButton);
            this.group1.Items.Add(this.SubmitButton);
            this.group1.Items.Add(this.AuthenticatonButton);
            this.group1.Label = "Submit";
            this.group1.Name = "group1";
            // 
            // gradeButton
            // 
            this.gradeButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.gradeButton.Label = "Set Grades";
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.ShowImage = true;
            this.gradeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gradeButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.nameButton.Label = "Set Team Name";
            this.nameButton.Name = "nameButton";
            this.nameButton.ShowImage = true;
            this.nameButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.nameButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SubmitButton.Image = global::Olympiad_Grading.Properties.Resources.old_edit_redo;
            this.SubmitButton.Label = "Submit";
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.ShowImage = true;
            this.SubmitButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Submit_Click);
            // 
            // AuthenticatonButton
            // 
            this.AuthenticatonButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AuthenticatonButton.Image = ((System.Drawing.Image)(resources.GetObject("AuthenticatonButton.Image")));
            this.AuthenticatonButton.Label = "Authentication";
            this.AuthenticatonButton.Name = "AuthenticatonButton";
            this.AuthenticatonButton.ShowImage = true;
            this.AuthenticatonButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Authentication_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SubmitButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AuthenticatonButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gradeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton nameButton;
    }

    partial class ThisRibbonCollection
    {
        internal OlympiadRibbon Ribbon1
        {
            get { return this.GetRibbon<OlympiadRibbon>(); }
        }
    }
}
