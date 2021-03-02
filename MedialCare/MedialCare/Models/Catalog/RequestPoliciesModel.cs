using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedialCare.Models.Enum;

namespace MedialCare.Models.Catalog
{
    public class RequestPoliciesModel
    {
        public class RequestPoliciesModels
        {
            public int ID { get; set; }
            public string Company { get; set; }
            public string Policies { get; set; }
            public string User { get; set; }
            public DateTime Date { get; set; }
            public Status Status { get; set; }
        }
    }
}
