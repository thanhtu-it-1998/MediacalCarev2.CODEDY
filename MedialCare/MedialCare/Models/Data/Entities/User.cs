using MedialCare.Models.Data.Entities;
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

        [EnumDataType(typeof(Level))]
        public Level Level { get; set; }
        public string Image { get; set; }
        public string Designation { get; set; }

        [Display(Name = "BOD")]
        public DateTime JoinDate { get; set; }


        [Range(1, 999999999999)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Salary { get; set; }

        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public string Version { get; set; }

        public bool Deleted { get; set; }

        public List<PolicyOnEmployee> PolicyOnEmployees { get; set; }
        public List<EmailFormModel> EmailFromModels { get; set; }

    }
}
