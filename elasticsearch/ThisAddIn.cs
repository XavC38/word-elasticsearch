using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Elasticsearch.Net;
using Nest;



namespace elasticsearch
{
    
    public partial class ThisAddIn
    {

        public static ElasticClient client;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            var nodes = new Uri[]
            {
                new Uri("http://localhost:9200")
            };

            var pool = new StaticConnectionPool(nodes);
            var settings = new ConnectionSettings(pool);
            client = new ElasticClient(settings);

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
