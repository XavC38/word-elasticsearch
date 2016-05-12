using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Nest;


namespace elasticsearch
{
    class Elasticsearch
    {
        private static ElasticClient client;

        public Elasticsearch()
        {
            /*var nodes = new Uri[]
            {
                new Uri("http://localhost:9200")
            };

            var pool = new StaticConnectionPool(nodes);
            var settings = new ConnectionSettings(pool);
            client = new ElasticClient(settings);*/
        }
        
        public ElasticClient getClient()
        {
            return client;
        }

        // return the status of the cluster elasticsearch
        // 0-> red, 1->yellow, 2->green 
        public int getStatus()
        {
            return 0;
        }
        
        //send a document in the cluster
        public void sendDocument()
        {

        }

        //get documents in function of the search
        public static List<Document> getDocuments(String searchTxt)
        {
            var result = new List<Document>();

            QueryContainer query = new TermQuery
            {
                Field = "corp",
                Value = searchTxt
            };

            var searchRequest = new SearchRequest
            {
                From = 0,
                Size = 10,
                Query = query
            };

            var searchResults = ThisAddIn.client.Search<Document>(searchRequest);
            
            
            foreach (var d in searchResults.Documents)
            {
                result.Add(d);
            }

            return result;
            
        }
    }
}
