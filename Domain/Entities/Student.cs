using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;
using System.Text;

namespace Domain.Entities
{
    public class Student
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength (50)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string FathersName { get; set; }
        [Required]
        [MaxLength(50)]
        public string MothersName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string PlaceOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; }
        [Required]
        [MaxLength(50)]
        public string Language { get; set; }
        [Required]
        public string PassportNumber { get; set; }
        public int SectionId { get; set; }
        [ForeignKey ("SectionId")]
        public Section Section { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
