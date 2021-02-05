using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Models.Common
{
    public class RequestPoliciesModel
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public string Policies { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public Status Status { get; set; }
    }
}
