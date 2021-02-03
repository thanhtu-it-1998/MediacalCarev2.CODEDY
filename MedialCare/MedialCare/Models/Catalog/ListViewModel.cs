using MedialCare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Catalog
{
    public class ListViewModel
    {
        public IEnumerable<Company> Company { get; set; }
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Policy> Policy { get; set; }
        public IEnumerable<PolicyOnEmployee> PolicyOnEmployee { get; set; }
        public PagingModel PagingModel { get; set; }
    }
}
