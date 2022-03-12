using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class StudentInfo
    {
        [Key]
        public string Id { get; set; }
        public string StudentId { get; set; }
        [MaxLength(50, ErrorMessage ="plase, enter your email"), MinLength(4)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string ParentEmail { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public int ParentPhoneNumber { get; set; }
        [MaxLength(100, ErrorMessage = "Adress must be 100 characters or less"), MinLength(5)]
        public string AddressLine1 { get; set; }
        [MaxLength(100, ErrorMessage = "Adress must be 100 characters or less")]
        public string AddressLine2 { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Country must be 50 characters or less")]
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string StudentPhoto { get; set; }
        [MaxLength(50, ErrorMessage = "plaese, enter your attended school"), MinLength(3)]
        public string AttendedSchool { get; set; }
        [MaxLength(50)]
        public string InteresOrtHobby { get; set; }
        public bool LoginRequired { get; set; }
        [MaxLength(400)]
        public string NoteAboutStudent { get; set; }
        public bool ParentLoginRequired { get; set; }
        public MaritalStatus StudentStatus { get; set; }
        [ForeignKey ("StudentId")]
        public Student Student { get; set; }
    }
    public enum MaritalStatus
    {
        Married,
        Single
    }

}
