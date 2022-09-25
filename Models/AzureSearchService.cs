using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogue.Models
{
    public class AzureSearchService
    {
        public string SearchServiceName { get; set; }
        public string SearchServiceQueryApiKey { get; set; }
        public string SearchServiceIndex { get; set; }
    }
}