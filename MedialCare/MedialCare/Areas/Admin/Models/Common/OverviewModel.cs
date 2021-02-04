using MedialCare.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Admin.Models.Common
{
    public class OverviewModel
    {
        public int Appointment { get; set; }
        public int TotalPartient { get; set; }
        public int TotalCompany{ get; set; }
        public int Earning { get; set; }
        public List<User> User { get; set; }
    }
}
