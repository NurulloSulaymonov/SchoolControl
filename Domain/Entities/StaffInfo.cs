using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class StaffInfo
    {
        [Key]
        public string Id { get; set; }
        public string StaffId { get; set; }
        [MaxLength (100, ErrorMessage = "Adress must be 100 characters or less"), MinLength (5)]
        public string AdressLine1 { get; set; }
        [MaxLength(100, ErrorMessage = "Address must be 100 characters or less")]
        public string AdressLine2 { get; set; }
        [MaxLength (50)]
        public string City { get; set; }
        [MaxLength (50)]
        public string State { get; set; }
        [Required]
        [MaxLength (50, ErrorMessage = "Country must be 50 characters or less")]
        public string Country { get; set; } 
        public int PostalCode { get; set; }

        [ForeignKey ("StaffId")]
        public Staff Staff { get; set; }

    }
}
