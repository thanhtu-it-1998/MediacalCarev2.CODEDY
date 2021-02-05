using MedialCare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Catalog
{
    public class RequetModel
    {
        public IEnumerable<Policy> Policies { get; set; }
        public Company Company { get; set; }
        public PagingModel PagingModel { get; set; }
         
        public string Key { get; set; }
    }
}
