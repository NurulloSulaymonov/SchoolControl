using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Attendance
    {
        [Key]
        public string Id { get; set; }
        public string StudentId { get; set; }
        [Required]
        public int Date { get; set; }
        public string ClassId { get; set; }
        public AttendanceType AttendanceType { get; set; }
        [MaxLength (400, ErrorMessage = "Comment must be 400 characters or less")]
        public string Comment { get; set; }
        public int Mark { get; set; }
        [ForeignKey("StudentId")]
        public Student Students { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }

    }
    public enum AttendanceType
    {
        Present,
        Absent

    }
}
