using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Data.Entities
{
    public class RequestPolicy
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PolicyID { get; set; }
        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string Version { get; set; }
        public bool Deleted { get; set; }

    }
}
