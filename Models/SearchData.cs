using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksCatalogue.Models
{
    public class SearchData
    {
        // The text to search for.
        public string searchText { get; set; }
 
 
        // The list of results.
        public DocumentSearchResult<Book> resultList;
    }
}