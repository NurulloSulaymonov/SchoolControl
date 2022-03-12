using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    /// <summary>
    /// for semester and other events 
    /// </summary>
    public class Section
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength (50)]
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
}
