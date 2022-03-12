using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class ParentInfo
    {
        [Key]
        public string Id { get; set; }
  
        [MaxLength (50)]
        public string MothersName { get; set; }
        [MaxLength(50)]
        public string FathersName { get; set; }
        [MaxLength(100)]
        public string MotherOccupation { get; set; }
        [MaxLength(50)]
        public string FatherOccupation { get; set; }
        public int MothersPhone { get; set; }
        public int FathersPhone { get; set; }
        public string MothersEmail { get; set; }
        public string FathersEmail { get; set; }
        public string StudentId { get; set; }
        [ForeignKey ("StudentId")]
        public Student Student { get; set; }
    }
}
