namespace elasticsearch
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.ElasticsearchTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Export = this.Factory.CreateRibbonButton();
            this.ElasticsearchTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElasticsearchTab
            // 
            this.ElasticsearchTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.ElasticsearchTab.Groups.Add(this.group1);
            this.ElasticsearchTab.Label = "Elasticsearch";
            this.ElasticsearchTab.Name = "ElasticsearchTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Export);
            this.group1.Label = "Share";
            this.group1.Name = "group1";
            // 
            // Export
            // 
            this.Export.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Export.Image = ((System.Drawing.Image)(resources.GetObject("Export.Image")));
            this.Export.Label = "Export Selection";
            this.Export.Name = "Export";
            this.Export.ShowImage = true;
            this.Export.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Export_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.ElasticsearchTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.ElasticsearchTab.ResumeLayout(false);
            this.ElasticsearchTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab ElasticsearchTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Export;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
