using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Staff
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public int StaffCode { get; set; }
        [MaxLength (50), MinLength(3)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50), MinLength (3)]
        public string Surname { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public StaffType StaffType { get; set; }
    }
    public enum StaffType
    {
        Teaching,
        NonTeaching
    }
}
