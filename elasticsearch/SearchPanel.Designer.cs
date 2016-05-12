namespace elasticsearch
{
    partial class SearchPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SearchFLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.AcceptsReturn = true;
            this.SearchBar.Location = new System.Drawing.Point(15, 14);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(193, 20);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.SearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_KeyPress);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(133, 40);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.Search_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(150, 100);
            this.splitContainer2.TabIndex = 0;
            // 
            // SearchFLP
            // 
            this.SearchFLP.AutoScroll = true;
            this.SearchFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchFLP.Location = new System.Drawing.Point(8, 69);
            this.SearchFLP.Name = "SearchFLP";
            this.SearchFLP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchFLP.Size = new System.Drawing.Size(200, 419);
            this.SearchFLP.TabIndex = 2;
            this.SearchFLP.WrapContents = false;
            // 
            // SearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchFLP);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchBar);
            this.Name = "SearchPanel";
            this.Size = new System.Drawing.Size(226, 525);
            this.Load += new System.EventHandler(this.SearchPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel SearchFLP;
    }
}
