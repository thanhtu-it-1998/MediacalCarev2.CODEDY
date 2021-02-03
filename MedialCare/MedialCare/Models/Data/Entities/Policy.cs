using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Entities
{
    public class Policy
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Company")]
        [Display(Name ="Name Company")]
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public Decimal Amount { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public Decimal Emi { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public string Version { get; set; }

        public bool Deleted { get; set; }

        public List<PolicyOnEmployee> PolicyOnEmployee { get; set; }

        public Company Company { get; set; }

    }
}
