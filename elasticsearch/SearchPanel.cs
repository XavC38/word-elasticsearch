using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elasticsearch;

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
                Search();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search();
            CreateSearchBox();
        }

        private void Search()
        {
            //get the content of the search
            string currSearch = null;
            currSearch = SearchBar.Text;

            // the text is not null then we send the search
            if (currSearch != null)
            {
                System.Windows.Forms.MessageBox.Show(currSearch);
                
                
            } 
            
            
            //send the request on enter
            //print all the value in a new object each time
        }
            
        private void CreateSearchBox()
        {
            SearchResultBox newSearchBox = new SearchResultBox();
            //add a search box
            //TODO add the scroll to the list and not limited
            SearchFLP.Controls.Add(newSearchBox);

        }


    }

}
