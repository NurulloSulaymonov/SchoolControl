using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class AccountInformation
    {
        [Key]
        public string Id { get; set; }
        public string StudentId { get; set; }
        [MaxLength(50)]
        public string BankName { get; set; }
        public int BankAccountNumber { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
