using MedialCare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Models.Common
{
    public class OverviewModel
    {
        public int FeedBackTotal { get; set; }
        public int RequestTotal { get; set; }
        public List<User> User { get; set; }
    }
}
