namespace elasticsearch
{
    partial class SearchResultBox
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
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchResultTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(43, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 37);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-2, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 24);
            this.panel2.TabIndex = 3;
            // 
            // SearchResultTb
            // 
            this.SearchResultTb.Location = new System.Drawing.Point(5, 58);
            this.SearchResultTb.Multiline = true;
            this.SearchResultTb.Name = "SearchResultTb";
            this.SearchResultTb.ReadOnly = true;
            this.SearchResultTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchResultTb.Size = new System.Drawing.Size(282, 115);
            this.SearchResultTb.TabIndex = 4;
            // 
            // SearchResultBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.SearchResultTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchResultBox";
            this.Size = new System.Drawing.Size(290, 176);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchResultTb;
    }
}
