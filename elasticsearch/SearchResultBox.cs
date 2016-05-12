using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elasticsearch
{
    public partial class SearchResultBox : UserControl
    {
        public SearchResultBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setTitle(string title)
        {
            this.Title.Text = title;
        }

        public void setTags(List<string> tags)
        {

        }

        public void setText(string text)
        {
            this.SearchResultTb.Text = text;
        }
    }
}
