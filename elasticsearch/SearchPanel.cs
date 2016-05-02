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
    public partial class SearchPanel : UserControl
    {

        TextBox searchTb;
        

        
        public SearchPanel()
        {
            InitializeComponent();
            searchTb = new TextBox();
            //searchTb.KeyDown += new KeyEventHandler(searchTb_KeyDown);
        }

        private void SearchPanel_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            
            
            //ThisAddIn.client
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                //get the content of the search
                string theText = null;
                TextBox textBox = sender as TextBox;
                if (textBox != null)
                {
                    theText = textBox.Text;
                }
                //send the request on enter
                //print all the value in a new object each time
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
