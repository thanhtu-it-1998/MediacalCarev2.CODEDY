using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public Level Level { get; set; }

        public string Designation { get; set; }

        [Display( Name ="BOD")]
        public DateTime JoinDate { get; set; }

        [Column(TypeName = "Decimal(8,2)")]
        public Decimal Salary { get; set; }

        public Gender Gender { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public string Version { get; set; }

        public bool Deleted { get; set; }

        public List<PolicyOnEmployee> PolicyOnEmployees { get; set; }

    }
}
