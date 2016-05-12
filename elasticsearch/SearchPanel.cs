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
            
        }
        private void CreateSearchBox(String title, List<String> tags, String text)
        {
            SearchResultBox newSearchBox = new SearchResultBox();
            //add a search box
            //TODO add the scroll to the list and not limited
            newSearchBox.setTitle(title);
            newSearchBox.setTags(tags);
            newSearchBox.setText(text);
            SearchFLP.Controls.Add(newSearchBox);


        }

        private void Search()
        {
            //get the content of the search
            string currSearch = null;
            List<Document> response = new List<Document>();
            currSearch = SearchBar.Text;
            

            // the text is not null then we send the search
            if (currSearch != null)
            {
                //System.Windows.Forms.MessageBox.Show(currSearch);
                response = Elasticsearch.getDocuments(currSearch);
                //System.Windows.Forms.MessageBox.Show(response.Count.ToString());

                if (response.Count > 0)
                {
                    //we clear the interface
                    SearchFLP.Controls.Clear();
                }

                foreach (Document d in response)
                {
                    //System.Windows.Forms.MessageBox.Show(d.Title);
                    CreateSearchBox(d.Title, null, d.Corp);
                }

                
            } 
            
            
            //send the request on enter
            //print all the value in a new object each time
        }
            
       


    }

}
