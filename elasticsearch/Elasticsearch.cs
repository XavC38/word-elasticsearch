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
        public List<Document> getDocuments(String searchRequest)
        {
            return null;
        }
    }
}
