using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class StudentClass
    {
        [Key]
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string ClassId { get; set; }

        [ForeignKey ("StudentId")]
        public Student Students { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
    }
}
