using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Class
    {
        [Key]
        public string Id { get; set; }
        public string SubjectId { get; set; }
        public string StaffId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAt { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey ("SubjectId")]
        public Subject Subject { get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }

    }
}
