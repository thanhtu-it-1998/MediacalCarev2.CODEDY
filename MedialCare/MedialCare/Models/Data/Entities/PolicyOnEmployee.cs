using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Entities
{
    public class PolicyOnEmployee
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("User")]
        public int UserId{ get; set; }

        [ForeignKey("Policy")]
        [Display(Name = "Name Policy")]
        public int PolicyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [EnumDataType(typeof(Status))]
        public Status Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public string Version { get; set; }

        public bool Deleted { get; set; }
        public User User { get; set; }
        public Policy Policy  { get; set; }
    }
}
