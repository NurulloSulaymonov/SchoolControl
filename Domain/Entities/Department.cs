using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;

namespace Domain.Entities
{
    public class Department
    {
        [Key]
        public string Id { get; set; }
        
        [Required]
        [MaxLength (50)]
        public string Name { get; set; }
        [Required]
        public int Code { get; set; }
        public string StaffId { get; set; }
        public bool Enabled { get; set; }
        [ForeignKey ("StaffId")]
        public Staff Staff { get; set; }
    }
}
